using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DoctorApointmentSystem.Models;
namespace DoctorApointmentSystem.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Display(Name = "Doctor ID")]
        public int DoctorId { get; set; }

        [Display(Name = "Patient ID")]
        public int PatientId { get; set; }

        [ForeignKey(nameof(PatientId))]

        public Patient? PatientData { get; set; }

        [ForeignKey(nameof(DoctorId))]
        public Doctor? DoctorData { get; set; } 
    }
}
