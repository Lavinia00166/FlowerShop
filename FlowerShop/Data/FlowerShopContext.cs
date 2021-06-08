using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FlowerShop.Models;

namespace FlowerShop.Data
{
    public class FlowerShopContext : DbContext
    {
        public FlowerShopContext (DbContextOptions<FlowerShopContext> options)
            : base(options)
        {
        }

        public DbSet<FlowerShop.Models.Order> Order { get; set; }

        public DbSet<FlowerShop.Models.Product> Product { get; set; }

        public DbSet<FlowerShop.Models.Shop> Shop { get; set; }
    }
}
