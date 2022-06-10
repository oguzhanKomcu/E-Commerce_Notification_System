using AutoMapper;
using ECNS.Application.Model.DTOs;
using ECNS.Application.Model.VMs;
using ECNS.Domainn.Enums;
using ECNS.Domainn.Models.Entities;
using ECNS.Domainn.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Application.Service.CartService
{
    public class CartService : ICartService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CartService(IUnitOfWork unitOfWork , IMapper mapper  )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }
        public async Task Create(CartDto model)
        {

            var cart1 = _unitOfWork.CartRepository.GetDefault(x => x.User_Id == model.User_Id);
            if (cart1 == null)
            {
                var cart = _mapper.Map<Cart>(model);
                await _unitOfWork.CartRepository.Create(cart);
            }
            else
            {

                var cart3 = await _unitOfWork.CartRepository.GetDefault(x => x.User_Id == model.User_Id);
                cart3.Quantity += 1;
                await _unitOfWork.Commit();

            }
  
        }

        public async Task Delete(string userId)
        {
            var cart = await _unitOfWork.CartRepository.GetDefault(x => x.User_Id == userId);

            cart.Status = Status.Passive;
            cart.DeleteDate = DateTime.Now;

            await _unitOfWork.Commit();
        }

        public async Task<CartVM> GetById(string userId)
        {
            var cart = await _unitOfWork.CartRepository.GetFilteredFirstOrDefault(
              selector: x => new  CartVM
              {
                  User_Id = x.User_Id,
                  Product_Quantity = x.Quantity,
                  Product_Id = x.Product_Id,
                  Product_Name = x.Product.Name,
                  Product_Price = x.Product.Price,
                  Total_Amount = x.Product.Price * x.Quantity
              },

              expression: x => x.User_Id == userId &&
                              x.Status != Status.Passive);

           

 
            return cart;
        }

        public async Task<List<CartVM>> GetProductByUsers(int productId)
        {
            var cart = await _unitOfWork.CartRepository.GetFilteredList(
              selector: x => new CartVM
              {
                  User_Id = x.User_Id,
                  UserName = x.AppUser.UserName,
                  UserEmail = x.AppUser.Email,
                  Product_Quantity = x.Quantity,
                  Product_Id = x.Product_Id,
                  Product_Name = x.Product.Name,
                  Product_Price = x.Product.Price,
                  Total_Amount = x.Product.Price * x.Quantity
              },

              expression: x => x.Product_Id == productId &&
                              x.Status != Status.Passive);




            return cart;
        }        
    }
}
