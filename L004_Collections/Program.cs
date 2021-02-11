using System;
using System.Collections.Generic;

namespace L004_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };

            // isimler[4] = "İlker"; // yukarıda tanımlı dizi 4 elemanlıdır.
            // Console.WriteLine(isimler[4]); // 5. eleman değiştirilmek istendiği için hata verir.

            // Dinamik dizi ihtiyacımız olduğunda List ile tanımlı Collectionları kullanırız.
            List<string> name = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            name.Add("Nurullah");
            Console.WriteLine(name[4]);


            Console.ReadLine();
        }
    }
}
/*
 * -> Collections is dinamic arrays.
 * -> Dizileri oluştururken boyutlarını tanımlamamız gerekiyorken bu işlemi dinamik hale getirmek için collection'ları kullanırız.
 * -> List<string> collectionName = new List<string>();
 * collectionName.Add("Engin");
*/