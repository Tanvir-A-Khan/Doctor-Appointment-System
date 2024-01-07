using System.ComponentModel.DataAnnotations;

namespace DoctorApointmentSystem.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        [Display(Name = "Patient Name")]
        public string PatientName { get; set;}

        [Display(Name = "Patient Phone")]
        public string PatientPhone{ get; set;} 

        [Display(Name = "Patient Address")]
        public string PatientAddress { get; set; }

        [Display(Name = "Patient Age")]
        public string PatientAge { get; set; } 

        
    }
}
