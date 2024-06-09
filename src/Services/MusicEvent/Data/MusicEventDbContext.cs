using Microsoft.EntityFrameworkCore;

namespace MusicEvent.Data
{
    public class MusicEventDbContext : DbContext
    {
        public MusicEventDbContext(DbContextOptions<MusicEventDbContext> options) : base(options)
        {
        }

        public DbSet<MusicEvent.Models.MusicEvent> MusicEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MusicEvent.Models.MusicEvent>().ToTable("MusicEvents");
        }
    }
}
