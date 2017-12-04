using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsImport { get; set; }
        public bool IsEligibleForSalesTax { get; set; }
    }
}
