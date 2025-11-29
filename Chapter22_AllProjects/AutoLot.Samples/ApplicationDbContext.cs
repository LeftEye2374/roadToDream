using Microsoft.EntityFrameworkCore;
using AutoLot.Samples.Models;

namespace AutoLot.Samples
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Make> Makes { get; set; }
 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<BaseEntity>().ToTable("BaseEntities");
            //modelBuilder.Entity<Car>().ToTable("Cars");
            //OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}