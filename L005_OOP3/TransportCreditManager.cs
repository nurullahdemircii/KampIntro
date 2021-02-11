using System;
using System.Collections.Generic;
using System.Text;

namespace L005_OOP3
{
    class TransportCreditManager : ICreditManager
    {
        public void Calc()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme Planı Hesaplandı.");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
