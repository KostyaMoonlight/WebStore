using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;

namespace WebStore.UI.Infrastructure.IoC
{
    public class WebDependencyModule
        :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterControllers(System.Reflection.Assembly.GetExecutingAssembly()).InstancePerRequest();

            builder.Register(cnt => AutoMapperConfig.GetConfiguration()).SingleInstance();
            builder.Register(cnt => cnt.Resolve<MapperConfiguration>().CreateMapper()).SingleInstance();
        }
    }
}