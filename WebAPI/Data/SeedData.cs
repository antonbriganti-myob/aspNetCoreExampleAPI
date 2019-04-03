using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProductsContext(serviceProvider.GetRequiredService<DbContextOptions<ProductsContext>>()))
            {
                if (!context.Products.Any())
                {
                    context.Products.AddRange(
                        new Product { Name = "Rope", Price = 20.99m }
                        );
                    context.SaveChanges();
                }
            }
        }
    }
}
