using System;
using System.Collections.Generic;
using System.Text;

namespace L005_OOP3
{
    class BuildCreditManager : ICreditManager
    {
        public void Calc()
        {
            // throw new NotImplementedException();

            Console.WriteLine("Konut Kredisi Ödeme Planı Hesaplandı.");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
