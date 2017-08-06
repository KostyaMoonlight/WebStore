using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.BusinessLogic.DTO.Category;
using WebStore.BusinessLogic.Services;
using WebStore.BusinessLogic.Services.Base;
using WebStore.Domain.Entities;

namespace WebStore.BusinessLogic.Mapping
{
    public class CategoryProfile
        :Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDTO>()
                .ForMember(dest=>dest.CountOfProducts, 
                opt => opt.MapFrom(src => GetCountOfProducts(src)));
        }

        int GetCountOfProducts(Category _category)
        {
            var category = _category;
            if (category == null)
            {
                return 0;
            }
            int count = category.Products.Count;
            foreach (var subCategory in category.ChildCategories)
            {
                count += GetCountOfProducts(subCategory);
            }
            return count;
        }
    }
}
