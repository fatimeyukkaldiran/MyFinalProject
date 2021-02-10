using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages //do not new()
    {
        public static string ProductAdded = "Product added!";
        public static string ProductNameInvalid = "Product name invalid";
        internal static string MaintenanceTime = "system is under maintenance";
        internal static string ProductsListed = "The products were listed";
    }
}
