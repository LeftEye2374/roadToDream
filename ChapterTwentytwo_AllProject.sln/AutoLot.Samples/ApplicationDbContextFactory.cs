using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AutoLot.Samples
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbConxtex>
    {
        public ApplicationDbConxtex CreateDbContext(string[] args)
        {
            var OptionBuilder = new DbContextOptionsBuilder<ApplicationDbConxtex>();
            var ConnectionString = @"server=.,5433;Database=AutoLotSamples;User Id=sa;Password=P@ssw0rd;";
            OptionBuilder.UseSqlServer(ConnectionString);
            Console.WriteLine(ConnectionString);
            return new ApplicationDbConxtex(OptionBuilder.Options);
        }
    }
}