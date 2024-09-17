using Microsoft.EntityFrameworkCore;
using MVC.Models;
namespace MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {}
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Enti> Enti { get; set; }
    }
}