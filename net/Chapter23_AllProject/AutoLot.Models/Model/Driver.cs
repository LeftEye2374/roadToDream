using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLot.Model
{

    [Table("Drivers", Schema = "dbo")]
    public class Driver : BaseEntity 
    {
        public Person PersonInfo { get; set; } = new Person();
        [InverseProperty(nameof(Car.Drivers))]
        public IEnumerable<Car> Cars { get; set; } = new List<Car>();

        [InverseProperty(nameof(CarDriver.DriverNavigation))]
        public IEnumerable<CarDriver> CarDrivers { get; set; } = new List<CarDriver>();
    }
}