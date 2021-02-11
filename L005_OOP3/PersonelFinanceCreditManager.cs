using System;
using System.Collections.Generic;
using System.Text;

namespace L005_OOP3
{
    class PersonelFinanceCreditManager : ICreditManager
    {
        public void Calc()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplandı.");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
