using ProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace ProjectPSD.Repository
{
    public class TransactionRepository
    {
        private static ProjectDatabaseEntities3 db = Singleton.GetInstance();

        public static void CreateHeader(TransactionHeader header)
        {
            db.TransactionHeaders.Add(header);
            db.SaveChanges();
        }

        public static void CreateDetail(TransactionDetail detail)
        {
            db.TransactionDetails.Add(detail);
            db.SaveChanges();
        }

        public static List<TransactionHeader> GetTransactionHeadersCustomer(int UserID)
        {
            List<TransactionHeader> headers = (from c in db.TransactionHeaders where c.UserID == UserID select c).ToList(); 
            return headers;
        }

        public static List<TransactionDetail> GetTransactionDetailsCustomer(int TransactionID)
        {
            List<TransactionDetail> details = (from c in db.TransactionDetails where c.TransactionID == TransactionID select c).ToList();
            return details;
        }

        public static TransactionHeader getTransactionHeaderByID(int TransactionID)
        {
            return db.TransactionHeaders.Find(TransactionID);
        }
    }
}