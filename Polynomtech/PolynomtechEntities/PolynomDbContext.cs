using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polynomtech.PolynomtechEntities
{
    public class PolynomDbContext:DbContext
    {
        public PolynomDbContext(DbContextOptions<PolynomDbContext> options) : base(options)
        {

        }
        public DbSet<Parfume> Parfumes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }

    }
}
