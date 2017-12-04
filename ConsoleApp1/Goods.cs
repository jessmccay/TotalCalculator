using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Goods : Item
    {
       public Goods(string itemName, decimal itemPrice)
        {
            this.IsEligibleForSalesTax = true;
            this.Price = itemPrice;
            this.Name = itemName;

            if (itemName.ToLower().Contains("imported"))
            {
                this.IsImport = true;
            }
      
        }
    }
}
