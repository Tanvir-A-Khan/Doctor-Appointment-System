using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DoctorApointmentSystem.Data;
using DoctorApointmentSystem.Models;

namespace DoctorApointmentSystem.Pages.Doctors
{
    public class DetailsModel : PageModel
    {
        private readonly DoctorApointmentSystem.Data.DoctorApointmentSystemContext _context;

        public DetailsModel(DoctorApointmentSystem.Data.DoctorApointmentSystemContext context)
        {
            _context = context;
        }

      public Doctor Doctor { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Doctor == null)
            {
                return NotFound();
            }

            var doctor = await _context.Doctor.FirstOrDefaultAsync(m => m.DoctorId == id);
            if (doctor == null)
            {
                return NotFound();
            }
            else 
            {
                Doctor = doctor;
            }
            return Page();
        }
    }
}
