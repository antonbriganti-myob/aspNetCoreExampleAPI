using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Product
    {
         
        public Product()
        {

        }

        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        [Range(minimum: 0.01, maximum: (double) decimal.MaxValue)]
        public decimal Price { get; set; }
    }
}
