using Microsoft.EntityFrameworkCore;
using WebApplication.Modules;

namespace WebApplication.Context
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
