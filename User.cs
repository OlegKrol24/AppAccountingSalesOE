using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAccountingSalesOE
{
    public class User
    {
        private int iD;
        private string login;
        private string password;
        private string role;

        public int ID { get => iD; }
        public string Login { get => login; }
        public string Password { get => password; }
        public string Role { get => role; }

        public User(int iD, string login, string password, string role)
        {
            this.iD = iD;
            this.login = login;
            this.password = password;
            this.role = role;
        }

        public User(string info)
        {
            if (info != null)
            {
                string[] values = info.Split('|');

                if (values.Length >= 2)
                {
                    try { iD = Convert.ToInt32(values[0]); } catch { iD = -1; }
                    try { login = values[1]; } catch (Exception ex) { login = ""; }
                    try { password = values[2]; } catch (Exception ex) { password = ""; }
                    try { role = values[3]; } catch (Exception ex) { role = ""; }
                }
            }
        }

    }
}
