namespace Back2Checkout
{
    public class Item
    {
        public readonly string Sku;
        public readonly double Price;
        
        public Item(string sku, double price)
        {
            Sku = sku;
            Price = price;
        }
    }
}