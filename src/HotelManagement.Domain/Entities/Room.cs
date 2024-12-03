namespace HotelManagement.Domain.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public RoomType Type { get; set; }
        public string Description { get; set; }
        public RoomStatus Status { get; set; }
        public decimal PricePerNight { get; set; }
    }

    public enum RoomType
    {
        Single,
        Double,
        Suite,
        Deluxe
    }

    public enum RoomStatus
    {
        Available,
        Occupied,
        Maintenance,
        Reserved
    }
}
