using AutoMapper;
using ECNS.Application.Model.DTOs;
using ECNS.Application.Model.VMs;
using ECNS.Application.Notifications;
using ECNS.Domainn.Enums;
using ECNS.Domainn.Models.Entities;
using ECNS.Domainn.UoW;
using Microsoft.EntityFrameworkCore;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Application.Service.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        
        public ProductService(IUnitOfWork unitOfWork, IMapper mapper )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }
        


        public async Task Create(CreateProductDTO model)
        {
            var product = _mapper.Map<Product>(model);



            await _unitOfWork.ProductRepository.Create(product);

            await _unitOfWork.Commit();
        }

        public async Task Delete(int id)
        {
            var product = await _unitOfWork.ProductRepository.GetDefault(x => x.Id == id);

            product.Status = Status.Passive;
            product.DeleteDate = DateTime.Now;

            await _unitOfWork.Commit();
        }

        public async Task<UpdateProductDTO> GetById(int id)
        {
            var product = await _unitOfWork.ProductRepository.GetFilteredFirstOrDefault(
                selector: x => new GetProductVM
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Price = x.Price,
                    ImagePath = x.ImagePath,
                    CategoryName = x.Category.Name,
                    Stock = x.Stock,
                    CategoryId = x.Category_Id,
                    Color = x.Color,
                    Size = x.Size
                },
                expression: x => x.Id == id &&
                                x.Status != Status.Passive);

            var model = _mapper.Map<UpdateProductDTO>(product);


            return model;

        }

        public async Task<List<GetProductVM>> GetProdcutByCategory(int categoryId)
        {
            var products = await _unitOfWork.ProductRepository.GetFilteredList(
                selector: x => new GetProductVM
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Price = x.Price,
                    ImagePath = x.ImagePath,
                    CategoryName = x.Category.Name
                },
                expression: x => x.Category_Id == categoryId &&
                                x.Status != Status.Passive,
                orderBy: x => x.OrderBy(x => x.Name),
                include: x => x.Include(x => x.Category));

            return products;
        }




        public async Task<List<GetProductVM>> GetProducts()
        {


            
            var products = await _unitOfWork.ProductRepository.GetFilteredList(
                selector: x => new GetProductVM
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Price = x.Price,
                    ImagePath = x.ImagePath,
                    CategoryName = x.Category.Name,
                    Stock = x.Stock,
                    CategoryId = x.Category_Id,
                    Color = x.Color,
                    Size = x.Size

                },
                expression: x => x.Status != Status.Passive,
                orderBy: x => x.OrderBy(x => x.Name),
                include: x => x.Include(x => x.Category));

            return products;
        }


        public async Task Update( UpdateProductDTO model)
        {
           
            var product = _mapper.Map<Product>(model);




            _unitOfWork.ProductRepository.Update(product);

            await _unitOfWork.Commit();
        }
    }
}
