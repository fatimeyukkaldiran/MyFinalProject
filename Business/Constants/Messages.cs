using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string CategoryLimitExceded = "Limit of category is exceded, can not add new product";
        public static string AuthorizationDenied = "You do not have authorizantion";
        public static string PasswordError = "The password is false";
        public static string UserNotFound = "The user is not found";
        public static string SuccessfulLogin = "The login is successfull";
        public static string UserAlreadyExists = "This user is already exists";
        public static string AccessTokenCreated = "Access Token Created";
        public static string UserRegistered = "The user was registered";
    }
}
