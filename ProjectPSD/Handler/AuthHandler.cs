using ProjectPSD.Models;
using ProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ProjectPSD.Handler
{
    public class AuthHandler
    {
        public static string doRegister(string name, string email, string password, string birthdayString, string gender)
        {
            DateTime birthday = DateTime.Parse(birthdayString);
            string emailfix = email.ToLower();
            string role = "";
            if(email != "admin@gmail.com")
            {
                role = "user";
            }
            else
            {
                role = "admin";
            }
            MsUser user = UserRepository.createUser(name, emailfix, gender, role, birthday, password);

            return user != null ? "" : "Registration failed!";
        }

        public static MsUser doLogin(string name, string password)
        {

           MsUser user = UserRepository.getUser(name, password);

            return user;

        }

        public static string getPassword(string id)
        {
            string password = UserRepository.getPassword(id);
            return password;
            
        }

        public static void doPasswordReset(string id, string newPassword)
        {
            UserRepository.updatePassword(id, newPassword);
        }
    }
}