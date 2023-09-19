using Microsoft.EntityFrameworkCore;
using Yoo.Models;

namespace User.Work
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {          
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Flower> Flowers { get; set; }
    }
}