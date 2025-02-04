using DattleAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DattleAPI.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
    }
}
