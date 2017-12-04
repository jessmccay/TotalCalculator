using System.Collections.Generic;
using ConsoleApp1;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1Tests
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void AddSalesTaxShouldNotAddTaxToBookItems()
        {
            Item newBook = new Book("the book", 10.00M);
            decimal expected = 10.00M;

            newBook.Price += SalesTax.AddSalesTax(newBook);

            Assert.AreEqual(expected, newBook.Price);
        }

        [TestMethod]
        public void AddSalesTaxShouldAddTaxtoGoodsItems()
        {
            Item item = new Goods("Wine", 40.00M);
            decimal expectedPrice = 44.00M;
            item.Price += SalesTax.AddSalesTax(item);

            Assert.AreEqual(expectedPrice, item.Price);
        }

        [TestMethod]
        public void AddSalesTaxShouldNotAddTaxtoMedicalItems()
        {
            Item item = new Medical("heart moniter", 5000M);
            decimal expectedItemPrice = 5000.00M;

            item.Price += SalesTax.AddSalesTax(item);

            Assert.AreEqual(expectedItemPrice, item.Price);
        }

        [TestMethod]
        public void AddSalesTaxShouldNotAddTaxToFoodItems()
        {
            Item item = new Food("berries", 3.50M);
            decimal expectedItemPrice = 3.50M;

            item.Price += SalesTax.AddSalesTax(item);

            Assert.AreEqual(expectedItemPrice, item.Price);
        }

        [TestMethod]
        public void BookShouldSetNameToPassedParameterName()
        {
            Book book = new Book("Mindset", 10M);

            Assert.AreEqual("Mindset", book.Name);
        }

        [TestMethod]
        public void BookShouldSetPriceParameterToBookPrice()
        {
            Book book = new Book("Mindset", 10M);

            Assert.AreEqual(10M, book.Price);
        }

        [TestMethod]
        public void FoodShouldSetNameParameterToFoodName()
        {
            Food food = new Food("rice", 5.0M);

            Assert.AreEqual("rice", food.Name);
        }

        [TestMethod]
        public void FoodShouldSetPriceToPriceParameter()
        {
            Food food = new Food("rice", 5.0M);

            Assert.AreEqual(5.0M, food.Price);
        }

        [TestMethod]
        public void FoodIsImportShouldBeTrueIfFoodNameIncludesImport()
        {
            Food food = new Food("Imported Cheese", 50M);

            Assert.IsTrue(food.IsImport);
        }

        [TestMethod]
        public void FoodIsImportShouldBeFalseIfFoodNameDoesNotIncludeImport()
        {
            Food food = new Food("regular cheese", 15M);

            Assert.IsFalse(food.IsImport);
        }

     
    }
}
