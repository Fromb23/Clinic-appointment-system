using ClinicAppointmentSystem.Models;

namespace ClinicAppointmentSystem.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int PatientId { get; set; }
        public required Patient Patient { get; set; }
        public int? DoctorId { get; set; }  // Nullable DoctorId in case no preferred doctor is chosen
        public Doctor? Doctor { get; set; }  // Nullable Doctor for preferred doctor
        public required string PurposeOfAppointment { get; set; }
    }
}