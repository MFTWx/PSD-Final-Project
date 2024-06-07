using ProjectPSD.Models;
using ProjectPSD.Modules;
using ProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Handler
{
    public class SupplementHandler
    {
        public static Response<List<MsSupplement>> GetAllMsSupplement()
        {
            List<MsSupplement> Supplements = SupplementRepository.GetMsSupplements();

            if(Supplements.Count == 0)
            {
                return new Response<List<MsSupplement>>()
                {
                    Success = false,
                    Message = "Supplements Table is Empty",
                    Payload = null
                };
            }
            else
            {
                return new Response<List<MsSupplement>>()
                {
                    Success = true,
                    Message = "Supplements Table Accessed!",
                    Payload = Supplements
                };
            }
        }
        public static Response<MsSupplementType> GetSupplementType(int key)
        {
            MsSupplementType SupplementType = SupplementRepository.GetMsSupplementType(key);
            
            if(SupplementType == null)
            {
                return new Response<MsSupplementType>()
                {
                    Success = false,
                    Message = "Supplement Type Not Found!",
                    Payload = null
                };
            }
            else
            {
                return new Response<MsSupplementType>()
                {
                    Success = true,
                    Message = "Supplement Type Found!",
                    Payload = SupplementType
                };
            }
        }
    }
}