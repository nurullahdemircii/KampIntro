using System;

namespace L003_ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Nurullah";
            customer1.LastName = "Demirci";
            customer1.BirthDate = 1990;
            Customer customer2 = new Customer();
            customer2.Id = 1;
            customer2.FirstName = "Engin";
            customer2.LastName = "Demiroğ";
            customer2.BirthDate = 1983;
            Customer customer3 = new Customer();
            customer3.Id = 1;
            customer3.FirstName = "Hami";
            customer3.LastName = "Mandıralı";
            customer3.BirthDate = 1970;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            Console.WriteLine("\n");
            customerManager.List();
            Console.WriteLine("\n");
            customerManager.Delete(customer1);
            Console.WriteLine("\n");
            customerManager.List();
            Console.WriteLine("\n");
            customerManager.Delete(customer2);
            Console.WriteLine("\n");
            customerManager.List();
            Console.WriteLine("\n");
            customerManager.Delete(customer3);

            Console.ReadLine();
        }
    }
}
