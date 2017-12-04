using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Receipt printFirstReceipt = new Receipt(ShoppingCart.FirstItems());
            
            Receipt printSecondReceipt = new Receipt(ShoppingCart.NextItems());

            Receipt printFinalReceipt = new Receipt(ShoppingCart.FinalItems());

            Console.ReadLine();
        }
    }
}
