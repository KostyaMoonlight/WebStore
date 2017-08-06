using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStore.BusinessLogic.Services.Base;

namespace WebStore.UI.Controllers
{
    public class MainController : Controller
    {
        IProductService productService = null;
        ICategoryService categoryService = null;

        public MainController(IProductService _productService, ICategoryService _categoryService)
        {
            productService = _productService;
            categoryService = _categoryService;
        }

        // GET: Main
        public ActionResult Index()
        {
            var products = productService.GetProducts();

            return View(products);
        }

        public ActionResult GetCategories()
        {
            var categories = categoryService.GetCategories();

            return View(categories);
        }


    }
}