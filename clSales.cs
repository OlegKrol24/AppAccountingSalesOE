using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAccountingSalesOE
{
    public class clSales
    {
        private int iD;
        private DateTime sale_date;
        private int iD_customer;
        private int iD_employee;
        private decimal total_amount;

        public int ID { get => iD; }
        public DateTime SaleDate { get => sale_date; }
        public int ID_Customer { get => iD_customer; }
        public int ID_Employee { get => iD_employee; }
        public decimal TotalAmount { get => total_amount; }

        public clSales()
        {
            iD = -1;
            sale_date = DateTime.MinValue;
            iD_customer = -1;
            iD_employee = -1;
            total_amount = 0;
        }

        public clSales(int iD, DateTime sale_date, int iD_customer, int iD_employee, decimal total_amount)
        {
            this.iD = iD;
            this.sale_date = sale_date;
            this.iD_customer = iD_customer;
            this.iD_employee = iD_employee;
            this.total_amount = total_amount;
        }

        public clSales(string info)
        {
            if (info != null)
            {
                string[] values = info.Split('|');

                if (info.Length >= 4)
                {
                    try { iD = Convert.ToInt32(values[0]); } catch (Exception ex) { iD = -1; }
                    try { sale_date = Convert.ToDateTime(values[1]); } catch (Exception ex) { sale_date = DateTime.Today; }
                    try { iD_customer = Convert.ToInt32(values[0]); } catch (Exception ex) { iD_customer = -1; }
                    try { iD_employee = Convert.ToInt32(values[0]); } catch (Exception ex) { iD_employee = -1; }
                    try { total_amount = Convert.ToDecimal(values[4]); } catch (Exception ex) { total_amount = 0; }
                }
            }
        }
    }
}
