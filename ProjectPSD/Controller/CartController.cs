using ProjectPSD.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Controller
{
    public class CartController
    {
        public static Response<string> checkQuantity(int quantity)
        {
            if (quantity >= 1)
            {
                return new Response<string>()
                {
                    Success = true,
                    Message = "Quantity valid",
                    Payload = "Request Valid"
                };
            }
            else
            {
                return new Response<string>()
                {
                    Success = false,
                    Message = "Quantity not valid",
                    Payload = "Request not Valid"
                };
            }
        }
    }
}