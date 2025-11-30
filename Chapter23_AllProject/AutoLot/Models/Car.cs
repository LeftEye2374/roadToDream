using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLot.Models
{
    public class Car : BaseEntity
    {
        public string Color { get; set; }
        public string PetName { get; set; }
        public string FullName { get; set; }
        public int MakeId { get; set; }
        public Make MakeNavigations { get; set; }
        public Radio RadioNavigation { get; set; }
        public IEnumerable<Driver> Drivers { get; set; } = new List<Driver>();

        private bool? _isDrivable;
        public bool isDrivale 
        {
            get => _isDrivable ?? true;
            set => _isDrivable = value;
        }
    }
}