using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
namespace WebRepo.Models
{
    public class HuronDbContext : DbContext
    {
        public HuronDbContext(DbContextOptions<HuronDbContext> options):base(options) { }
        public DbSet<Customer> Customers { get; set; }
    }
}
