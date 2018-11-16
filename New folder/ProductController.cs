using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataLayer;
using BusinessLayer;

namespace WebApiDesign.Controllers
{
    [Route ("api/product")]
    public class ProductController :Controllers
    {
        public ProductController()
        {
        }

        [HttpGet]
        public IEnumerable<string> GetAll(int id)
        {
            return new string { "product" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpDelete("{id}")]
        public string Detele(int id)
        {
        }
    }
}