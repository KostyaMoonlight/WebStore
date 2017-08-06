using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.DataAccess.Context;
using WebStore.Domain.Entities;

namespace WebStore.DataAccess.Initializers
{
    public class WebStoreDbInitializer
        : DropCreateDatabaseAlways<WebStoreDbContext>
    {
        protected override void Seed(WebStoreDbContext context)
        {
            context.Categories.AddRange(new List<Category>
            {
                new Category{ Name="Food"},
                new Category{ Name="Fruits", HeadCategoryId = 1},
                new Category{ Name="Junk food", HeadCategoryId = 1}
            });

            context.SaveChanges();

            context.Products.AddRange(new List<Product>
            {
                new Product{ Name="Apple", CategoryId=2, Description="Green", Price=10},
                new Product{ Name="Milk", CategoryId=1, Description="White", Price=25},
                new Product{ Name="Crisps", CategoryId=3, Description="Paper", Price=12},
                new Product{ Name="Cola", CategoryId=3, Description="Paper", Price=22}

            });

            context.SaveChanges();
        }
    }
}
