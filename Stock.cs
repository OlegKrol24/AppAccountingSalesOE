using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAccountingSalesOE
{
    public class Stock
    {
        private int iD;
        private int iD_goods;
        private int quantity;
        public int ID { get => iD; }
        public int ID_Goods { get => iD_goods; }
        public int Quantity { get => quantity; }

        public Stock()
        {
            iD = -1;
            iD_goods = -1;
            quantity = 0;
        }

        public Stock(int iD, int iD_goods, int quantity)
        {
            this.iD = iD;
            this.iD_goods = iD_goods;
            this.quantity = quantity;
        }

        public Stock(string info)
        {
            if (info != null)
            {
                string[] values = info.Split('|');

                if (info.Length >= 3)
                {
                    try { iD = Convert.ToInt32(values[0]); } catch (Exception ex) { iD = -1; }
                    try { iD_goods = Convert.ToInt32(values[1]); } catch (Exception ex) { iD_goods = -1; }
                    try { quantity = Convert.ToInt32(values[2]); } catch (Exception ex) { quantity = 0; }
                }
            }
        }
    }
}