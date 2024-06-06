using ProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Factory
{
    public class AdminFactory
    {
        public static MsUser create(string UserName, string UserEmail, DateTime UserDOB, string UserGender, string UserRole)
        {
            return new MsUser()
            {
                UserName = UserName,
                UserEmail = UserEmail,
                UserDOB = UserDOB,
                UserGender = UserGender,
                UserRole = UserRole
            };
        }
    }
}