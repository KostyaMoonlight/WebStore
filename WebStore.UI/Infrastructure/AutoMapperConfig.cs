using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebStore.BusinessLogic.Mapping;
using WebStore.BusinessLogic.Services;
using WebStore.BusinessLogic.Services.Base;

namespace WebStore.UI.Infrastructure
{
    public static class AutoMapperConfig
    {
        public static MapperConfiguration GetConfiguration()
        {
            var config = new MapperConfiguration(cnf =>
                {
                    var autoMapperProfileTypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes().Where(p => typeof(Profile).IsAssignableFrom(p) && p.IsPublic && !p.IsAbstract && p.GetConstructor(Type.EmptyTypes) != null));
                    var autoMapperProfiles = autoMapperProfileTypes.Select(p => (Profile)Activator.CreateInstance(p));
                    foreach (var profile in autoMapperProfiles)
                    {
                        cnf.AddProfile(profile);
                    }


                });
            return config;
        }
    }
}