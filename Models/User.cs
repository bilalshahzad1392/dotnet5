using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class UserModel
    {
        public int ID{ get; set; }
        public String Name { get; set; }

        public static List<UserModel> GetUsers()
        {
            List<UserModel> users = new List<UserModel>();
            users.Add(new UserModel()
            {
                ID = 1,
                Name = "Bilal"
            });
            users.Add(new UserModel()
            {
                ID = 2,
                Name = "Faisal"
            });
            users.Add(new UserModel()
            {
                ID = 3,
                Name = "Waqas"
            });

            return users;
        }

        public static Boolean ValidateUser(String login,String password)
        {
            if(login == "admin" && password == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class LoginInfo
    {
        public String Login { get; set; }
        public String Password { get; set; }
    }
}
