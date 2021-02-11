using System;

namespace L004_GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Nurullah");
            isimler.Add("Fatih");
            isimler.Add("Engin");
            isimler.Print();

            Console.ReadLine();
        }
    }
}
