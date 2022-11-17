using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NewWalks.API.Models.Domain;

namespace NewWalks.API.Data
{
    public class WalksDbContext:DbContext
    {
        public WalksDbContext(DbContextOptions<WalksDbContext> options):base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
