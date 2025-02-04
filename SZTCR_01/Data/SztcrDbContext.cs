using Microsoft.EntityFrameworkCore;
using SZTCR_01.Models.Domain;

namespace SZTCR_01.Data
{
    public class SztcrDbContext : DbContext
    {
        public SztcrDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Radnik> Radnici { get; set; }
    }
}
