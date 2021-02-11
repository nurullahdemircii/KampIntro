using System;

namespace L002_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlama Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            // Array - Dizi
            string[] kurslar = new string[] {
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlama Başlangıç İçin Temel Kurs",
                "Java",
                "Python"
            };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.ReadLine();
        }
    }
}
