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
                .HasMaxLength(50)
                .HasDefaultValue("Black");
                entity.Property(e => e.PetName)
                .IsRequired()
                .HasMaxLength(50);
                entity.Property(e => e.FullName)
                .HasComputedColumnSql("[PetName] + '('+ [Color] + ')'", stored : true);
                entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
                entity.Property(e => e.isDrivale)
                .HasField("_isDrivable")
                .HasDefaultValue(true);
                entity.HasOne(d => d.MakeNavigations)
                .WithMany(p => p.Cars)
                .HasForeignKey(d => d.MakeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inventory_Makes_MakeId");
            });

            modelBuilder.Entity<Radio>(entity => 
            {
                entity.HasIndex(e => e.CarId, "IX_Radios_CarId")
                .IsUnique();
                entity.HasOne(d => d.CarNavigation)
                .WithOne(p => p.RadioNavigation)
                .HasForeignKey<Radio>(d => d.CarId);
            }); 
        }
         
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}