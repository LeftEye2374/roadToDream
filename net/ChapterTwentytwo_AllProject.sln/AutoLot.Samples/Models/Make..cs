namespace AutoLot.Samples.Models
{
    public class Make : BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<Car> cars { get; set; } = new List<Car>();
    }
}