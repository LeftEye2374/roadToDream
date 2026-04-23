using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AutoLot.Samples
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var OptionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var ConnectionString = @"server=.,5433;Database=AutoLotSamples;User Id=sa;Password=P@ssw0rd;TrustServerCertificate=true;Encrypt=false";
            OptionBuilder.UseSqlServer(ConnectionString);
            Console.WriteLine(ConnectionString);
            return new ApplicationDbContext(OptionBuilder.Options);
        }
    }
}