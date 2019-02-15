using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Back2Checkout
{
    public class Tests
    {
        [Theory]
        [InlineData(new Item("A", 10.0))]
        public void Checkout_ShouldReturnPriceOfItem(Item shoppingItem)
        {
            var expectedResult = shoppingItem.Price;
            var actualResult = CheckoutSystem.Checkout(new List<Item>{shoppingItem});
            
            Assert.Equal(expectedResult, actualResult);
        }
    }

    public class CheckoutSystem
    {
        public static double Checkout(ICollection<Item> items)
        {
            return 0;
        }
    }

    public class Item
    {
        public string SKU { get; set; }
        public double Price { get; set; }

        public Item(string sku, double price)
        {
            SKU = sku;
            Price = price;
        } 
    }
}