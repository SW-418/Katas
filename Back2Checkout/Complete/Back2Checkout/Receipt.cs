using System.Collections.Generic;

namespace Back2Checkout
{
    public class Receipt
    {
        public readonly IEnumerable<Item> Items;
        public readonly double Total;
        
        public Receipt(List<Item> items, double total)
        {
            Items = items;
            Total = total;
        }
    }
}