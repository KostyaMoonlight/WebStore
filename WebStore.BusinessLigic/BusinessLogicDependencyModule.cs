﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.BusinessLogic.Services;
using WebStore.BusinessLogic.Services.Base;
using WebStore.BusinessLogic.Services;
using WebStore.BusinessLogic.Services.Base;

namespace WebStore.BusinessLogic
{
    public class BusinessLogicDependencyModule
        :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(ProductService))
                .As(typeof(IProductService))
                .InstancePerRequest();

            builder.RegisterType(typeof(CategoryService))
                .As(typeof(ICategoryService))
                .InstancePerRequest();
        }
    }
}