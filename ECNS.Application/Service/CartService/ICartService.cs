using ECNS.Application.Model.DTOs;
using ECNS.Application.Model.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Application.Service.CartService
{
    public interface ICartService
    {
        Task Create(CartDto model);
        Task Delete(string userId);

        Task<CartVM> GetById(string userId);
        Task<List<CartVM>> GetProductByUsers(int productId);
    }
}
