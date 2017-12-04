using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp1
{
    public static class ShoppingCart
    {
        static bool import = true;
        static bool local = false;
        
        public static List<Item> FirstItems()
        {
            List<Item> items = new List<Item>
            {
                new Book("Book", 12.49M),
                new Goods("Music CD", 14.99M),
                new Food("Chocolate Bar", 0.85M)
            };
            return items;
        }

        public static List<Item> NextItems()
        {
            List<Item> nextItems = new List<Item>
            {
                new Food("Imported Chocolate", 10.00M),
                new Goods("Imported bottle of perfume", 47.50M)
            };
            return nextItems;
        }

        public static List<Item> FinalItems()
        {
            List<Item> finalItems = new List<Item>
            {
                new Goods("imported bottle of perfume", 27.99M),
                new Goods("bottle of perfume", 18.99M),
                new Medical("packet of headache pills", 9.75M),
                new Food("imported chocolates", 11.25M)
            };
            return finalItems;
        }
    }
}
