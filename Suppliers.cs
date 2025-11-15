using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAccountingSalesOE
{
    public class Suppliers
    {
        private int iD;
        private string full_name;
        private string company_name;
        private string phone_number;
        private string email;

        public int ID { get => iD; }
        public string Full_name { get => full_name; }
        public string Company_name { get => company_name; }
        public string Phone_number { get => phone_number; }
        public string Email { get => email; }

        public Suppliers()
        {
            this.iD = -1;
            this.full_name = "";
            this.company_name = "";
            this.phone_number = "";
            this.email = "";
        }

        public Suppliers(int id, string full_name, string company_name, string phone_number, string email)
        {
            this.iD = id;
            this.full_name = full_name;
            this.company_name = company_name;
            this.phone_number = phone_number;
            this.email = email;
        }

        public Suppliers(string info)
        {
            if (info != null)
            {
                string[] values = info.Split('|');
                if (info.Length >= 4)
                {
                    try { iD = Convert.ToInt32(values[0]); } catch (Exception ex) { iD = -1; }
                    try { full_name = values[1]; } catch (Exception ex) { full_name = ""; }
                    try { company_name = values[2]; } catch (Exception ex) { company_name = ""; }
                    try { phone_number = values[3]; } catch (Exception ex) { phone_number = ""; }
                    try { email = values[4]; } catch (Exception ex) { email = ""; }
                }
            }
        }
    }
}