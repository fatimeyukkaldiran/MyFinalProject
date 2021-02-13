using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")] //attribute in c#, 
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //naming convention
        IProductService _productService; //field

        //loosely coupled
        //IoC container -- Inversion of control
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public string Get()
        {
            //Dependency chain
           
            var result = _productService.GetAll();
            return result.Message;
        }
    }
}
