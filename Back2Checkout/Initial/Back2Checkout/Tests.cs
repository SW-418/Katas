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
        public void Checkout_ShouldReturnPriceOfItem(string sku, double price)
        {
            var shoppingItem = new Item(sku, price);
            var expectedResult = shoppingItem.Price;
            var actualResult = CheckoutSystem.Checkout(new List<Item>{shoppingItem});
            
            Assert.Equal(expectedResult, actualResult);
        }
    }
}