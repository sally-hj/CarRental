namespace CarRental.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Type { get; set; }
        public decimal PricePerDay { get; set; }
        public int Seats { get; set; }
        public string Transmission { get; set; }
        public string Fuel { get; set; }
        public bool IsAvailable { get; set; }
        public List<string> Images { get; set; } = new List<string>();
    }
}
