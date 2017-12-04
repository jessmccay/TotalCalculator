using System;

namespace ConsoleApp1
{
    public class Book : Item
    {
        public Book(string bookName, decimal bookPrice)
        {
            this.IsEligibleForSalesTax = false;
            this.Name = bookName ?? throw new ArgumentNullException(nameof(bookName));
            this.Price = bookPrice;

            if (bookName.ToLower().Contains("imported"))
            {
                this.IsImport = true;
            }
        }
    }
}   