using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Type safety - Tip güvenliği
            // Do not repeat yourself - Kendini tekrarlama
            // Değer tutucu, alias

            // string değişkenlere " ile tanımlama yapılır.
            string categoryLabel = "Kategori"; // kategori etiketi
            int studentNum = 32000; // öğrenci sayısı
            double bankRate = 1.45; // faizoranı
            bool loginControl = true;

            Console.WriteLine(categoryLabel);
            Console.WriteLine(studentNum);
            Console.WriteLine(bankRate);
            Console.WriteLine(loginControl);

            if (loginControl == true)
            {
                Console.WriteLine("Success Login.");
            }
            else if (loginControl == false)
            {
                Console.WriteLine("Fault Login! Please repeat again.");
            }
            else
            {
                Console.WriteLine("Fault Login!");
            }

            Console.ReadLine();
        }
    }
}
