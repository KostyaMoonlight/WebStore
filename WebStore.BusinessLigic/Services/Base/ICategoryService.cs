using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.BusinessLogic.DTO.Category;

namespace WebStore.BusinessLogic.Services.Base
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDTO> GetCategories();
    }
}
