using System;

namespace ConsoleApp1
{
    public static class ImportTax 
    {
        public static decimal TaxRate = 0.05M;
        private static decimal total;

        public static decimal AddImportTax(Item item)
        {
            if (item.IsImport)
            {
                return Math.Ceiling(item.Price * TaxRate / .05M) * .05M;

            }
            return 0.0M;
        }
    }
}