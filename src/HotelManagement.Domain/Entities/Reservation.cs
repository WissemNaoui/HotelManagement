using System;

namespace HotelManagement.Domain.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public ReservationStatus Status { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }

    public enum ReservationStatus
    {
        Pending,
        Confirmed,
        CheckedIn,
        CheckedOut,
        Cancelled
    }
}
