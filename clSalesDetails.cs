using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAccountingSalesOE
{
    public class clSalesDetails
    {
        private int iD;
        private int iD_sale;
        private int iD_goods;
        private int quantity;
        private decimal unit_price;

        public int ID { get => iD; }
        public int ID_Sale { get => iD_sale; }
        public int ID_Goods { get => iD_goods; }
        public int Quantity { get => quantity; }
        public decimal UnitPrice { get => unit_price; }

        public clSalesDetails()
        {
            iD = -1;
            iD_sale = -1;
            iD_goods = -1;
            quantity = 0;
            unit_price = 0;
        }

        public clSalesDetails(int iD, int iD_sale, int iD_goods, int quantity, decimal unit_price)
        {
            this.iD = iD;
            this.iD_sale = iD_sale;
            this.iD_goods = iD_goods;
            this.quantity = quantity;
            this.unit_price = unit_price;
        }

        public clSalesDetails(string info)
        {
            if (info != null)
            {
                string[] values = info.Split('|');

                if (info.Length >= 4)
                {
                    try { iD = Convert.ToInt32(values[0]); } catch (Exception ex) { iD = -1; }
                    try { iD_sale = Convert.ToInt32(values[1]); } catch (Exception ex) { iD_sale = -1; }
                    try { iD_goods = Convert.ToInt32(values[2]); } catch (Exception ex) { iD_goods = -1; }
                    try { quantity = Convert.ToInt32(values[3]); } catch (Exception ex) { quantity = 0; }
                    try { unit_price = Convert.ToDecimal(values[4]); } catch (Exception ex) { unit_price = 0; }
                }
            }
        }
    }
}