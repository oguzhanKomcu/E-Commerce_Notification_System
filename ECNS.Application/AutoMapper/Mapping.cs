using AutoMapper;
using ECNS.Application.Model.DTOs;
using ECNS.Application.Model.VMs;
using ECNS.Domainn.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Application.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {


            CreateMap<Cart, UserCartVM>().ReverseMap();
            CreateMap<Cart, CartDto>().ReverseMap();

            CreateMap<Product, CreateProductDTO>().ReverseMap();
            CreateMap<Product, UpdateProductDTO>().ReverseMap();
            CreateMap<Product, GetProductVM>().ReverseMap();
            CreateMap<UpdateProductDTO, GetProductVM>().ReverseMap();

            CreateMap<AppUser, RegisterDTO>().ReverseMap();
            CreateMap<AppUser, LoginDTO>().ReverseMap();
            CreateMap<AppUser, GetAppUserVm>().ReverseMap();
            CreateMap<UpdateProfileDTO, GetAppUserVm>().ReverseMap();
        }
    }
}
