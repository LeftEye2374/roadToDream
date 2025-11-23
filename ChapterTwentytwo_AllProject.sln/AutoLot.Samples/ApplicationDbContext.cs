using Microsoft.EntityFrameworkCore;
using AutoLot.Samples.Models;

namespace AutoLot.Samples 
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        public DbSet<Car> Cars { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}