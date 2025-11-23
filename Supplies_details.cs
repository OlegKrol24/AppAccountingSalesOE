using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAccountingSalesOE
{
    public class Supplies_details
    {
        private int iD;
        private int iD_supply;
        private int iD_goods;
        private int quantity;
        private decimal unit_cost;

        public int ID { get => iD; }
        public int ID_supply { get => iD_supply; }
        public int ID_goods { get => iD_goods; }
        public int Quantity { get => quantity; }
        public decimal Unit_cost { get => unit_cost; }

        public Supplies_details()
        {
            this.iD = -1;
            this.iD_supply = -1;
            this.iD_goods = -1;
            this.quantity = 0;
            this.unit_cost = 0;
        }

        public Supplies_details(int id, int id_supply, int id_goods, int quantity, decimal unit_cost)
        {
            this.iD = id;
            this.iD_supply = id_supply;
            this.iD_goods = id_goods;
            this.quantity = quantity;
            this.unit_cost = unit_cost;
        }

        public Supplies_details(string info)
        {
            if (info != null)
            {
                string[] values = info.Split('|');

                if (info.Length >= 4)
                {
                    try { iD = Convert.ToInt32(values[0]); } catch (Exception ex) { iD = -1; }
                    try { iD_supply = Convert.ToInt32(values[1]); } catch (Exception ex) { iD_supply = -1; }
                    try { iD_goods = Convert.ToInt32(values[2]); } catch (Exception ex) { iD_goods = -1; }
                    try { quantity = Convert.ToInt32(values[3]); } catch (Exception ex) { quantity = 0; }
                    try { unit_cost = Convert.ToDecimal(values[4]); } catch (Exception ex) { unit_cost = 0; }
                }
            }
        }
    }
}
