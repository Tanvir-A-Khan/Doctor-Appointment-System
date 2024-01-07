using System.ComponentModel.DataAnnotations;
namespace DoctorApointmentSystem.Models
{
    public class Doctor
    {
        [Display(Name = "ID")]
        public int DoctorId { get; set; }
        public string? Name { get; set; }    
        public string? Consultant { get; set; }
    }
}
