using System;

namespace L005_OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gerçek Müşteri - Tüzel Müşteri
            // SOLID

            // Engin Demiroğ - Gerçek Müşteri
            IndividualCostumer costumer1 = new IndividualCostumer();
            costumer1.Id = 1;
            costumer1.CostumerNumber = "12345";
            costumer1.FirstName = "Engin";
            costumer1.LastName = "Demiroğ";
            costumer1.TcNumber = "11111111111";

            // Kodlama.io - Tüzel Müşteri
            CorporateCostumer costumer2 = new CorporateCostumer();
            costumer2.Id = 2;
            costumer2.CostumerNumber = "54321";
            costumer2.CompanyName = "Kodlama.io";
            costumer2.TaxNumber = "1234567890";

            // Müşteri
            Costumer costumer3 = new IndividualCostumer();
            Costumer costumer4 = new CorporateCostumer();

            CostumerManager costumerManager = new CostumerManager();
            costumerManager.Add(costumer1);
            costumerManager.Add(costumer2);
            costumerManager.Add(costumer3);
            costumerManager.Add(costumer4);


            Console.ReadLine();
        }
    }
}
/*
 * -> Inheritance: Miras Alma
 * -> Bir veride bir bilgi o class için çok uyumlu durmuyorsa, bilinmeliki soyutlama hatası yapılıyor.
 * -> Eğer bir base class mevcutsa o bizim referans tutumuzdur.
*/