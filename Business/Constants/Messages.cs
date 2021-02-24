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
        public static string MaintenanceTime = "system is under maintenance";
        public static string ProductsListed = "The products were listed";
        public static string ProductCountOfCategoryError = "Product counts must be less than 10 in same category";
        public static string ProductNameAlreadyExist = "Product name is already exist";
        internal static string CategoryLimitExceded = "Limit of category is exceded, can not add new product";
    }
}
