using System.Collections.Generic;
using System.Linq;

namespace ProductList.Models
{
    public class ProductRepository
    {
        private static List<Supplier> suppliers = new List<Supplier>
        {
            new Supplier { SupplierId = 1, SupplierName = "Supplier A" },
            new Supplier { SupplierId = 2, SupplierName = "Supplier B" },
            new Supplier { SupplierId = 3, SupplierName = "Supplier C" }
        };

        private static List<Category> categories = new List<Category>
        {
            new Category { CategoryId = 1, CategoryName = "Category A1", SupplierId = 1 },
            new Category { CategoryId = 2, CategoryName = "Category A2", SupplierId = 1 },
            new Category { CategoryId = 3, CategoryName = "Category A3", SupplierId = 1 },
            new Category { CategoryId = 4, CategoryName = "Category B1", SupplierId = 2 },
            new Category { CategoryId = 5, CategoryName = "Category B2", SupplierId = 2 },
            new Category { CategoryId = 6, CategoryName = "Category B3", SupplierId = 2 },
            new Category { CategoryId = 7, CategoryName = "Category C1", SupplierId = 3 },
            new Category { CategoryId = 8, CategoryName = "Category C2", SupplierId = 3 },
            new Category { CategoryId = 9, CategoryName = "Category C3", SupplierId = 3 }
        };

        private static List<Product> products = new List<Product>
        {
            new Product { ProductId = 1, ProductName = "Product A1-1", CategoryId = 1 },
            new Product { ProductId = 2, ProductName = "Product A1-2", CategoryId = 1 },
            new Product { ProductId = 3, ProductName = "Product A2-1", CategoryId = 2 },
            new Product { ProductId = 4, ProductName = "Product A2-2", CategoryId = 2 },
            new Product { ProductId = 5, ProductName = "Product A3-1", CategoryId = 3 },
            new Product { ProductId = 6, ProductName = "Product B1-1", CategoryId = 4 },
            new Product { ProductId = 7, ProductName = "Product B1-2", CategoryId = 4 },
            new Product { ProductId = 8, ProductName = "Product B2-1", CategoryId = 5 },
            new Product { ProductId = 9, ProductName = "Product B2-2", CategoryId = 5 },
            new Product { ProductId = 10, ProductName = "Product B3-1", CategoryId = 6 },
            new Product { ProductId = 11, ProductName = "Product C1-1", CategoryId = 7 },
            new Product { ProductId = 12, ProductName = "Product C1-2", CategoryId = 7 },
            new Product { ProductId = 13, ProductName = "Product C2-1", CategoryId = 8 },
            new Product { ProductId = 14, ProductName = "Product C2-2", CategoryId = 8 },
            new Product { ProductId = 15, ProductName = "Product C3-1", CategoryId = 9 },
            new Product { ProductId = 16, ProductName = "Product C3-2", CategoryId = 9 }
        };

        public static List<Supplier> GetSuppliers() => suppliers;
        public static List<Category> GetCategories() => categories;
        public static List<Product> GetProducts() => products;

        public static List<Category> GetCategoriesBySupplier(int supplierId)
        {
            return categories.Where(c => c.SupplierId == supplierId).ToList();
        }

        public static List<Product> GetProductsByCategory(int categoryId)
        {
            return products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}

