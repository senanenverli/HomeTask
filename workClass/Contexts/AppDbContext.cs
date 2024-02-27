using Microsoft.EntityFrameworkCore;
using workClass.Models;

namespace workClass.Contexts
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; } = null!;
    }
}