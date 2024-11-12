using ClinicAppointmentSystem.Models;

namespace ClinicAppointmentSystem.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int PatientId { get; set; }
        public required Patient Patient { get; set; }
        public int DoctorId { get; set; }
        public required Doctor Doctor { get; set; }
    }
}