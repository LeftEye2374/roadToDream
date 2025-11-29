using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLot.Samples.Models
{
    public class Car : BaseEntity
    {
        public string Color { get; set; }
        public string PetName { get; set; }
        public int MakeId { get; set; }
        public Make MakeNavigations { get; set; }
        public Radio RadioNavigation { get; set; }
        public IEnumerable<Driver> Drivers { get; set; } = new List<Driver>();
    }
}