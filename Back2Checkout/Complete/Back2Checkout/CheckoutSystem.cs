using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Back2Checkout
{
    public static class CheckoutSystem
    {
        public static Receipt ScanItems(List<Item> items)
        {
            var total = CalculateTotal(items);
            return new Receipt(items, total);
        }
        
        public static double CalculateTotal(List<Item> items)
        {
            return items.Sum(x => x.Price);
        }

        public static string PrintReceipt(Receipt receipt)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Item  Price");
            foreach (var item in receipt.Items)
            {
                stringBuilder.AppendLine($"{item.Sku}  {item.Price}");
            }

            stringBuilder.Append($"Total: {receipt.Total}");
            return stringBuilder.ToString();
        }
    }
}