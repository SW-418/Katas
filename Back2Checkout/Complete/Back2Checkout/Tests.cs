using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Back2Checkout
{
    public class Tests
    {
        [Theory]
        [InlineData("A", 10.0)]
        [InlineData("B", 20.0)]
        [InlineData("C", 15.0)]
        public void Checkout_ShouldReturnPriceOfItem(string sku, double price)
        {
            var shoppingItem = new Item(sku, price);
            var expectedResult = shoppingItem.Price;
            var actualResult = CheckoutSystem.CalculateTotal(new List<Item>{shoppingItem});
            
            Assert.Equal(expectedResult, actualResult);
        }
        
        [Theory]
        [InlineData("A", 10.0, "A", 10.0, 20.0)]
        [InlineData("B", 20.0, "A", 10.0, 30.0)]
        [InlineData("C", 15.0, "A", 10.0, 25.0)]
        public void Checkout_ShouldReturnSumOfAllItems(string firstSku, double firstPrice, string secondSku, double secondPrice, double expectedResult)
        {
            var shoppingItemOne = new Item(firstSku, firstPrice);
            var shoppingItemTwo = new Item(secondSku, secondPrice);
            
            var actualResult = CheckoutSystem.CalculateTotal(new List<Item>{shoppingItemOne, shoppingItemTwo});
            
            Assert.Equal(expectedResult, actualResult);
        }
        
        [Theory]
        [InlineData("A", 10.0, "A", 10.0)]
        [InlineData("B", 20.0, "A", 10.0)]
        [InlineData("C", 15.0, "A", 10.0)]
        public void PrintReceipt_ReturnsItemsAndTotalAsAString(string firstSku, double firstPrice, string secondSku, double secondPrice)
        {
            var shoppingItemOne = new Item(firstSku, firstPrice);
            var shoppingItemTwo = new Item(secondSku, secondPrice);

            var receipt = CheckoutSystem.ScanItems(new List<Item>{shoppingItemOne, shoppingItemTwo});

            var expectedReceipt =
                $"Item  Price\n{shoppingItemOne.Sku}  {shoppingItemOne.Price}\n{shoppingItemTwo.Sku}  {shoppingItemTwo.Price}\nTotal: {receipt.Total}";

            var actualReceipt = CheckoutSystem.PrintReceipt(receipt);
            
            Assert.Equal(expectedReceipt, actualReceipt);
        }

       
    }
}