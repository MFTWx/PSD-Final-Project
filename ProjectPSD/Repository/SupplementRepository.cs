using ProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Repository
{
    public class SupplementRepository
    {
        private static ProjectDatabaseEntities3 db = Singleton.GetInstance();

        public static List<MsSupplement> GetMsSupplements()
        {
            return db.MsSupplements.ToList();
        }

        public static MsSupplementType GetMsSupplementType(int key)
        {
            MsSupplementType toFind = (from c in db.MsSupplementTypes where c.SupplementTypeID == key select c).ToList().FirstOrDefault();
            return toFind;
        }

        public static MsSupplement GetSupplementByID(int id)
        {
            return (from c in db.MsSupplements where c.SupplementID == id select c).FirstOrDefault();
        }
    }
}