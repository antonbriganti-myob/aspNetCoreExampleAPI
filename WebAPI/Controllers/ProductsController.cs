using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsContext _context;
        public ProductsController(ProductsContext context)
        {
            _context = context;
        }

        //GET action
        [HttpGet]
        public ActionResult<List<Product>> GetAll() =>
            _context.Products.ToList();


        //POST action
        [HttpPost]
        public String AddNewItem([FromBody] Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
            String response = "Product added with id " + _context.Products.Count();
            return response;
        }

        //PUT action

        //DELETE action
    }
}
