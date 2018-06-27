using Sparrow_Delivery.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sparrow_Delivery.Helpers
{
    public class SessionHelpers
    {
        public static int userID { get; set; }
        public static string nombre { get; set; }
        public static List<Item> carrito { get; set; }
    }
}