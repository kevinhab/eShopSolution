using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShop.DATA.Entities;

namespace eShop.DATA.EF
{
    public class EShopDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public EShopDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
