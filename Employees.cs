using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAccountingSalesOE
{
    public class Employees
    {
        private int iD;
        private string full_name;
        private string position;
        private string phone_number;
        private string email;
        private string address;
        private string sex;

        public int ID { get => iD; }
        public string Full_name { get => full_name; }
        public string Position { get => position; }
        public string Phone_number { get => phone_number; }
        public string Email { get => email; }
        public string Address { get => address; }
        public string Sex { get => sex; }

        public Employees()
        {
            this.iD = -1;
            this.full_name = "";
            this.position = "";
            this.phone_number = "";
            this.email = "";
            this.address = "";
            this.sex = "";
        }

        public Employees(int id, string full_name, string position, string phone_number, string email, string address, string sex)
        {
            this.iD = id;
            this.full_name = full_name;
            this.position = position;
            this.phone_number = phone_number;
            this.email = email;
            this.address = address;
            this.sex = sex;
        }

        public Employees(string info)
        {
            if (info != null)
            {
                string[] values = info.Split('|');

                if (info.Length >= 6)
                {
                    try { iD = Convert.ToInt32(values[0]); } catch (Exception ex) { iD = -1; }
                    try { full_name = values[1]; } catch (Exception ex) { full_name = ""; }
                    try { position = values[2]; } catch (Exception ex) { position = ""; }
                    try { phone_number = values[3]; } catch (Exception ex) { phone_number = ""; }
                    try { email = values[4]; } catch (Exception ex) { email = ""; }
                    try { address = values[5]; } catch (Exception ex) { address = ""; }
                    try { sex = values[6]; } catch (Exception ex) { sex = ""; }
                }
            }
        }
    }
}