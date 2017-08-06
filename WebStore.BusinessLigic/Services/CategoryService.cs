using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.BusinessLogic.DTO.Category;
using WebStore.BusinessLogic.Services.Base;
using WebStore.DataAccess.Repositories.Base;

namespace WebStore.BusinessLogic.Services
{
    public class CategoryService
        : ICategoryService
    {
        ICategoryRepository repository = null;
        IMapper mapper = null;

        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        
        public IEnumerable<CategoryDTO> GetCategories()
        {
            return repository.GetCategories().Select(mapper.Map<CategoryDTO>).ToArray();
        }

    }
}
