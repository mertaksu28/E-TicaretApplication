using Business.Concrete;
using Entity.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            Product product1 = new Product() { ProductName = "Dell", CategoryId = 1, UnitPrice = 1250, UnitsInStock = 2, Description = "Laptop" };

            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine("{0}", product.ProductName);
            }
        }
    }
}
