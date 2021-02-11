using System;
using System.Collections.Generic;
using System.Text;

namespace L005_OOP2
{
    // Inheritance - Miras
    class CorporateCostumer:Costumer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
