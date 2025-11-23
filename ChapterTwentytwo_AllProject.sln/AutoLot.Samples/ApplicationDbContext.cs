using Microsoft.EntityFrameworkCore;

namespace AutoLot.Samples 
{
    public class ApplicationDbConxtex : DbContext
    {
        public ApplicationDbConxtex(DbContextOptions<ApplicationDbConxtex> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial (ModelBuilder modelBuilder);
    }
}