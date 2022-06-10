using ECNS.Application.Model.DTOs;
using ECNS.Application.Model.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Application.Service.ProductService
{
    public interface IProductService
    {
        Task Create(CreateProductDTO model);
        Task Update(UpdateProductDTO model);
        Task Delete(int id);

        Task<UpdateProductDTO> GetById(int id);

        Task<List<GetProductVM>> GetProducts();

        Task<List<GetProductVM>> GetProdcutByCategory(int categoryId);

    }
}
