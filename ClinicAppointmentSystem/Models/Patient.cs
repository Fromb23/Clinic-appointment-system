using ClinicAppointmentSystem.Models;

namespace ClinicAppointmentSystem.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Gender { get; set; } // Consider using an enum for gender
        public DateTime DateOfBirth { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Address { get; set; }
        public bool IsFirstVisit { get; set; } 
    }
}