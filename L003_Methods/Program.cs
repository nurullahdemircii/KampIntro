using System;

namespace L003_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };
            //Type Safe - Tip Güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("\n");
            }

            Console.WriteLine("----------Metotlar-----------");
            // Instance - Örnek
            // Encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);


            Console.ReadLine();
        }
    }
}
