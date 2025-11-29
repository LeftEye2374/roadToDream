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
        public virtual DbSet<Radio> Radios {  get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity => 
            {
                entity.ToTable("Inventory", "dbo");
                entity.HasKey(e => e.Id);
                entity.HasIndex(e => e.MakeId, "IX_Inventory_MakeId");
                entity.Property(e => e.Color)
                .IsRequired()
                .HasMaxLength(50);
                entity.Property(e => e.PetName)
                .IsRequired()
                .HasMaxLength(50);
                entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}