using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace AutoLot.Samples
{
    public class ApplicationDbContextFactroy : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionalBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = @"server=.,5433;Database=AutoLotSamples;User Id=sa;Password=P@ssw0rd; TrustServerCertificate=true";
            optionalBuilder.UseSqlServer(connectionString);
            return new ApplicationDbContext(optionalBuilder.Options);
        }
    } 
}