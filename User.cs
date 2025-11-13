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
        private string first_name;
        private string last_name;
        private string full_name;   // Повне ПІБ для розбору

        public int ID { get => iD; }
        public string Login { get => login; }
        public string Password { get => password; }
        public string Role { get => role; }
        public string FirstName { get => first_name; }
        public string LastName { get => last_name; }

        public User(int iD, string login, string password, string role)
        {
            this.iD = iD;
            this.login = login;
            this.password = password;
            this.role = role;
            this.first_name = "";
            this.last_name = "";
            this.full_name = "";
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
                    try { full_name = values[4]; } catch (Exception ex) { full_name = ""; } // Парсинг full_name

                    // Розбір full_name на прізвище (перше слово) та ім'я (друге слово)
                    if (!string.IsNullOrEmpty(full_name))
                    {
                        string[] nameParts = full_name.Trim().Split(' ');
                        if (nameParts.Length >= 2)
                        {
                            last_name = nameParts[0];
                            first_name = nameParts[1];
                        }
                        else if (nameParts.Length == 1)
                        {
                            last_name = nameParts[0];
                            first_name = "";
                        }
                    }
                }
            }
        }

    }
}
