using System;

namespace L004_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; // Mobilyaya denk gelmektedir varsayalım.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 35
            };

            //Case Sensitive
            // PascalCase  // camelCase
            ProductManager productManager = new ProductManager();
            // Added
            productManager.Add(product1);
            productManager.Add(product2);

            // Updated
            productManager.Update(product1);
            productManager.Update(product2);

            Console.ReadLine();
        }
    }
}
