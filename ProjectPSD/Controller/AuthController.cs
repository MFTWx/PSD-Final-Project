using ProjectPSD.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Controller
{
    public class AuthController
    {
        public static string checkRegister(string name, string email, string password, string confirmPassword, string birthdayString, string gender)
        {
            string response = "";


            if (email == "" || password == "" || confirmPassword == "" || name == "" || string.IsNullOrEmpty(birthdayString) || gender == "")
            {
                response = "All fields must be filled!";
            }
            else if (password != confirmPassword)
            {
                response = "Password and Confirm Password must be the same!";
            }
            else if (password.Length < 8 || password.Length > 15)
            {
                response = "Password must be between 8 and 15 characters!";
            }
            else
            {
                // no validation for email because the textmode for email is already for email
            }

            return response;
        }

        public static string checkLogin(string email, string password)
        {
            string response = "";

            if (email == "" || password == "")
            {
                response = "All fields must be filled!";
            }

            return response;
        }

        public static string checkPassword(string id, string old_password, string new_password)
        {
            string response = "";
            string password = AuthHandler.getPassword(id);
            if (old_password == password) {
                if (new_password.Length < 8 || new_password.Length > 15)
                {
                    response = "Password must be between 8 and 15 characters!";
                    return response;
                }
                return response;
            } else
            {
                response = "Old password is incorrect!";
                return response;
            }
        }


    }
}