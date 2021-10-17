using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            // ProductDTO(productManager);
            foreach (var category in categoryManager.GetCategoryDetails())
            {
                Console.WriteLine("Kategori Adı : " + category.CategoryName + " " + " Marka Adı : " + category.BrandName);
            }

        }

        private static void ProductDTO(ProductManager productManager)
        {
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine("Kategori Adı : " + product.CategoryName + " Marka Adı : " + product.BrandName + " Ürün Adı : " + product.ProductName);
            }
        }
    }
}
