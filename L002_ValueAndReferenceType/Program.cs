using System;

namespace L002_ValueAndReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 30;
            num1 = num2;
            num2 = 65;
            Console.WriteLine(num1);
            int[] a = new int[] { 1, 2, 3 };
            int[] b = new int[] { 10, 20, 30 };
            a = b;
            b[0] = 999;
            Console.WriteLine(a[0]);

            Console.ReadLine();
        }
    }
}
