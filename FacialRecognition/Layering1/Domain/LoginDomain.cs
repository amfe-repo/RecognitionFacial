using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layering1.Domain
{
    public class LoginDomain
    {
        private static DataHelpers dh = new DataHelpers();

        public static string loginValidation(string username, string password) 
        {
            var value = from p in dh.ShowData() where p.NameUser == username && p.Password == password select p;

            if (value.FirstOrDefault() != null) 
            {
                return value.FirstOrDefault().RoleUser.ToString();
            }

            return "NaN";
        }

        public static bool adminValidation(string username, string password)
        {
            var value = from p in dh.ShowData() where p.NameUser == username && p.Password == password && p.RoleUser == true select p;

            if(value.FirstOrDefault() != null)
                return true;
            return false;
        }
    }
}
