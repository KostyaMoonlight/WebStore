using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebStore.DataAccess.Context;
using WebStore.DataAccess.Repositories.Base;
using WebStore.Domain.Entities;
using System.Data.Entity;

namespace WebStore.DataAccess.Repositories
{
    public class CategoryRepository
        : ICategoryRepository
    {
        WebStoreDbContext context = null;
        public CategoryRepository(WebStoreDbContext context)
        {
            this.context = context;
        }

        public Category GetCategory(int id)
        {
            return context.Categories.First(x => x.Id == id);
        }

        public IEnumerable<Category> GetCategories()
        {
            return context.Categories.Include(x=>x.Products).ToArray();
        }

        public IEnumerable<Category> GetCategories(Expression<Func<Category, bool>> func)
        {
            return context.Categories.Include(x => x.Products).Where(func).ToArray();

        }
    }
}
