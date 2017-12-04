using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Food : Item
    {
        
        public Food(string itemName, decimal itemPrice)
        {
            this.IsEligibleForSalesTax = false;
            this.Name = itemName;
            this.Price = itemPrice;

            if (itemName.ToLower().Contains("imported"))
            {
                this.IsImport = true;
            }
        }
    }

  
}
