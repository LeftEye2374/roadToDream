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
            //modelBuilder.Entity<BaseEntity>().ToTable("BaseEntities");
            //modelBuilder.Entity<Car>().ToTable("Cars");
            //OnModelCreatingPartial(modelBuilder);
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

        public virtual DbSet<Make> Makes { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Radio> Radios { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}