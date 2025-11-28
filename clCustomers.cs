using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAccountingSalesOE
{
    public class clCustomers
    {
        private int iD;
        private string full_name;
        private string phone_number;
        private string email;
        private string address;

        public int ID { get => iD; }
        public string Full_name { get => full_name; set; }
        public string Phone_number { get => phone_number; set; }
        public string Email { get => email; set; }
        public string Address { get => address; set; }

        public clCustomers()
        {
            this.iD = -1;
            this.full_name = "";
            this.phone_number = "";
            this.email = "";
            this.address = "";
        }

        public clCustomers(int id, string full_name, string phone_number, string email, string address)
        {
            this.iD = id;
            this.full_name = full_name;
            this.phone_number = phone_number;
            this.email = email;
            this.address = address;
        }

        public clCustomers(string info)
        {
            if (info != null)
            {
                string[] values = info.Split('|');

                if (info.Length >= 4)
                {
                    try { iD = Convert.ToInt32(values[0]); } catch (Exception ex) { iD = -1; }
                    try { full_name = values[1]; } catch (Exception ex) { full_name = ""; }
                    try { phone_number = values[2]; } catch (Exception ex) { phone_number = ""; }
                    try { email = values[3]; } catch (Exception ex) { email = ""; }
                    try { address = values[4]; } catch (Exception ex) { address = ""; }
                }
            }
        }
    }
}
