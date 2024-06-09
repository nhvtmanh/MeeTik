using Microsoft.EntityFrameworkCore;

namespace Ticket.Data
{
    public class TicketDbContext : DbContext
    {
        public TicketDbContext(DbContextOptions<TicketDbContext> options) : base(options)
        {
        }

        public DbSet<Ticket.Models.Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket.Models.Ticket>().ToTable("Tickets");
        }
    }
}
