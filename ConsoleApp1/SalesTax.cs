using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{
    public static class SalesTax 
    {
        public static decimal TaxRate = 0.10M;

        public static decimal AddSalesTax(Item item)
        {
            if (item.IsEligibleForSalesTax)
            {
                return Math.Round(item.Price * TaxRate * 20.0M) / 20.0M;
            }
            return 0M;
        }
    }


}
