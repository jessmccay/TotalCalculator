using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace ConsoleApp1
{
    public class Medical : Item
    {
       public Medical(string medicalName, decimal medicalPrice)
       {
           
            this.IsEligibleForSalesTax = false;
            this.Name = medicalName;
            this.Price = medicalPrice;
          
               if (Name.Contains("import"))
               {
                   this.IsImport = true;
               }
               
        }


    }
}
