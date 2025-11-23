using Microsoft.EntityFrameworkCore;

namespace AutoLot.Samples 
{
    public class ApplicationDbConxtex : DbContext
    {
        public ApplicationDbConxtex(DbContextOptions<ApplicationDbConxtex> options) : base(options)
        {
        } 
    }
}