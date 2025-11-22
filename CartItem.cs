using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAccountingSalesOE
{
    public class CartItem
    {
        public Goods Goods { get; set; }
        public int Quantity { get; set; } = 1;
    }
}
