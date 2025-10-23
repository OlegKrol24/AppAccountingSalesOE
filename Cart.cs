using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAccountingSalesOE
{
    public class Cart
    {
        public List<Goods> GoodsInCart { get; set; }

        public Cart()
        {
            GoodsInCart = new List<Goods>();
        }

        public decimal GetTotalPrice()
        {
            return GoodsInCart.Sum(g => g.Price);
        }

        public void AddToCart(Goods item)
        {
            GoodsInCart.Add(item);
        }

        public void RemoveFromCart(Goods item)
        {
            GoodsInCart.Remove(item);
        }
    }
}
