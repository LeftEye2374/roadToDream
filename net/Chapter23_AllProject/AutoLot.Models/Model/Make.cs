using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLot.Model
{
    [Table("Makes", Schema = "dbo")]
    public class Make : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; }

        [InverseProperty(nameof(Car.MakeNavigation))]
        public IEnumerable<Car> Cars { get; set; } = new List<Car>();
    }
}