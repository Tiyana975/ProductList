using ProductList.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ProductList.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new ProductViewModel
            {
                Suppliers = ProductRepository.GetSuppliers(),
                Categories = new List<Category>(), 
                Products = ProductRepository.GetProducts()
            };

            return View(viewModel);
        }

        public ActionResult GetCategoriesBySupplier(int supplierId)
        {
            var categories = ProductRepository.GetCategoriesBySupplier(supplierId)
                .Select(c => new { c.CategoryId, c.CategoryName });
                

            var categoryNames = new List<string>();
            var categoryIds = new List<int>();
            foreach (var category in categories)
            {
                categoryNames.Add(category.CategoryName);
                categoryIds.Add(category.CategoryId);
            }

            return Content(
                string.Format("{0};{1}", string.Join(",", categoryNames), string.Join(",", categoryIds)),
                "text/plain"
            );
        }

        public ActionResult GetProductsByCategory(int categoryId)
        {
            var products = ProductRepository.GetProductsByCategory(categoryId)
                .Select(p => new { p.ProductId, p.ProductName });

            var productNames = new List<string>();
            var productIds = new List<int>();
            foreach (var product in products)
            {
                productNames.Add(product.ProductName);
                productIds.Add(product.ProductId);
            }

            return Content(
                string.Format("{0};{1}", string.Join(",", productNames), string.Join(",", productIds)),
                "text/plain"
            );
        }

        public ActionResult AddProduct(int productId, string productName, int value, string serial)
        {
            
            return Content("OK", "text/plain");
        }
    }
}
