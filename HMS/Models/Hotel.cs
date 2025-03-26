namespace HMS.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; } // 1-5
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public Manager Manager { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
