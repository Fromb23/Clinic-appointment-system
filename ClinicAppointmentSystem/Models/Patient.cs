using ClinicAppointmentSystem.Models;

namespace ClinicAppointmentSystem.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Contact { get; set; }
    }
}