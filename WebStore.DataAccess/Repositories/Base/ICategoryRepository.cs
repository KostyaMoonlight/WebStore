using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebStore.Domain.Entities;

namespace WebStore.DataAccess.Repositories.Base
{
    public interface ICategoryRepository
    {
        Category GetCategory(int id);
        IEnumerable<Category> GetCategories();
        IEnumerable<Category> GetCategories(Expression<Func<Category, bool>> func);
    }
}
