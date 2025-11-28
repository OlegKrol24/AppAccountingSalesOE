using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAccountingSalesOE
{
    public class Supplies
    {
        private int iD;
        private int iD_supplier;
        private DateTime delivery_date;
        private decimal total_cost;

        public int ID { get => iD; }
        public int ID_Supplier { get => iD_supplier; set; }
        public DateTime DeliveryDate { get => delivery_date; set; }
        public decimal TotalCost { get => total_cost; set; }

        public Supplies()
        {
            this.iD = -1;
            this.iD_supplier = -1;
            this.delivery_date = DateTime.MinValue;
            this.total_cost = 0;
        }

        public Supplies(int iD, int iD_supplier, DateTime delivery_date, decimal total_cost)
        {
            this.iD = iD;
            this.iD_supplier = iD_supplier;
            this.delivery_date = delivery_date;
            this.total_cost = total_cost;
        }

        public Supplies(string info)
        {
            if (info != null)
            {
                string[] values = info.Split('|');

                if (info.Length >= 3)
                {
                    try { iD = Convert.ToInt32(values[0]); } catch (Exception ex) { iD = -1; }
                    try { iD_supplier = Convert.ToInt32(values[1]); } catch (Exception ex) { iD_supplier = -1; }
                    try { delivery_date = Convert.ToDateTime(values[2]); } catch (Exception ex) { delivery_date = DateTime.Today; }
                    try { total_cost = Convert.ToDecimal(values[3]); } catch (Exception ex) { total_cost = 0; }
                }
            }
        }
    }
}
