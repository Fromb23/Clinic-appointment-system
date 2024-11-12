using ClinicAppointmentSystem.Models;

namespace ClinicAppointmentSystem.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Specialization { get; set; }
    }
}