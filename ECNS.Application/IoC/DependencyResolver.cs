﻿using Autofac;
using AutoMapper;
using ECNS.Application.AutoMapper;
using ECNS.Application.FluentValidation;
using ECNS.Application.Model.DTOs;
using ECNS.Application.Service.AppUserService;
using ECNS.Application.Service.CartService;
using ECNS.Application.Service.ProductService;
using ECNS.Domainn.UoW;
using ECNS.Infrastructure.UoW;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace ECNS.Application.IoC
{
    public class DependencyResolver : Module
    {
        protected override void Load(ContainerBuilder builder)
        {



            base.Load(builder);

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();






            #region Services

            builder.RegisterType<AppUserService>().As<IAppUserService>().InstancePerLifetimeScope();
            builder.RegisterType<ProductService>().As<IProductService>().InstancePerLifetimeScope();
            builder.RegisterType<CartService>().As<ICartService>().InstancePerLifetimeScope();


            #endregion


            #region Fluent Validation

            builder.RegisterType<LoginValidation>().As<IValidator<LoginDTO>>().InstancePerLifetimeScope();
            builder.RegisterType<RegisterValidation>().As<IValidator<RegisterDTO>>().InstancePerLifetimeScope();

            #endregion


            #region AutoMapper

            builder.Register(context => new MapperConfiguration(cfg =>
            {
                //Register Mapper Profile
                cfg.AddProfile<Mapping>();
            }
            )).AsSelf().SingleInstance();

            builder.Register(c =>
            {
                //This resolves a new context that can be used later.
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            })
            .As<IMapper>()
            .InstancePerLifetimeScope();

            #endregion


        }
    }
}
