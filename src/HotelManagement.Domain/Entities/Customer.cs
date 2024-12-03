using System;

namespace HotelManagement.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
