using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Receipt
    {
        private static decimal _pricesOfItems;
        private decimal _postTaxPrice;
        private decimal _postSalesTaxPriceTotal;
        private decimal _postImportTaxPrice;

        public Receipt(List<Item> items)
        {
            SumOfItems(items);

            AddPriceOfItemAndSalesTax(items);

            PrintNameAndPriceOfItemAfterTotalTax(items);

            decimal finalPriceOfTotalBothKindsTax = _postImportTaxPrice + _postSalesTaxPriceTotal;
            Console.WriteLine("Total Tax: " + finalPriceOfTotalBothKindsTax);
            Console.WriteLine("Total: " + (_pricesOfItems + finalPriceOfTotalBothKindsTax));
            
            _pricesOfItems = 0M;
        }

        private void PrintNameAndPriceOfItemAfterTotalTax(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                _postImportTaxPrice += ImportTax.AddImportTax(items[i]);
                _postTaxPrice = ImportTax.AddImportTax(items[i]) + SalesTax.AddSalesTax(items[i]);
                Console.WriteLine("1 {0} : {1}", items[i].Name, (items[i].Price + _postTaxPrice));
            }
        }
        
        private void AddPriceOfItemAndSalesTax(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                _postSalesTaxPriceTotal += SalesTax.AddSalesTax(items[i]);
            }
        }

        public void SumOfItems(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                _pricesOfItems += items[i].Price;
            }
        }
    }
}
