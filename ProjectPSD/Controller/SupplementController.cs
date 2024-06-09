using ProjectPSD.Handler;
using ProjectPSD.Models;
using ProjectPSD.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Controller
{
    public class SupplementController
    {
        public static Response<List<MsSupplement>> getSupplemets()
        {
            Response<List<MsSupplement>> response = SupplementHandler.GetAllMsSupplement();
            return response;
        }

        public static Response<MsSupplementType> getSupplementType(int key)
        {
            Response<MsSupplementType> response = SupplementHandler.GetSupplementType(key);
            return response;
        }

        public static Response<MsSupplement> getSupplementByID(int key)
        {
            Response<MsSupplement> response = SupplementHandler.GetSupplementByID(key);
            return response;
        }
    }
}