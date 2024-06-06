using ProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Factory
{
    public class HeaderFactory
    {
        public static TransactionHeader create(int UserID, DateTime date, string status)
        {
            return new TransactionHeader()
            {
                UserID = UserID,
                TransactionDate = date,
                Status = status
            };
        }
    }
}