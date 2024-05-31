using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountNamespace
{
    internal class Cashier : UserAccount
    {
        private string department;
        public Cashier(string name, string uName, string password) : base (name, uName, password)
        {
            this.department = "Finance";
        }
        public override bool validateLogin(string uName, string password)
        {
            if (uName.Equals(user_name) && password.Equals(user_password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string getDepartment()
        {
            return department;
        }
    }
}
