using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAccountingSalesOE
{
    public static class Cart
    {
        public static List<CartItem> GoodsInCart { get; } = new List<CartItem>();

        public static void AddToCart(Goods item)
        {
            var existing = GoodsInCart.FirstOrDefault(i => i.Goods.ID == item.ID);

            if (existing != null) existing.Quantity++;

            else GoodsInCart.Add(new CartItem { Goods = item });
        }

        public static void RemoveFromCart(Goods item)
        {
            var existing = GoodsInCart.FirstOrDefault(i => i.Goods.ID == item.ID);

            if (existing != null)
            {
                existing.Quantity--;

                if (existing.Quantity <= 0) GoodsInCart.Remove(existing);
            }
        }
    }
}