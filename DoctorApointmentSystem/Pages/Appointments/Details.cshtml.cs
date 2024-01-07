using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DoctorApointmentSystem.Data;
using DoctorApointmentSystem.Models;

namespace DoctorApointmentSystem.Pages.Appointments
{
    public class DetailsModel : PageModel
    {
        private readonly DoctorApointmentSystem.Data.DoctorApointmentSystemContext _context;

        public DetailsModel(DoctorApointmentSystem.Data.DoctorApointmentSystemContext context)
        {
            _context = context;
        }

      public Appointment Appointment { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Appointment == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointment.FirstOrDefaultAsync(m => m.Id == id);
            if (appointment == null)
            {
                return NotFound();
            }
            else 
            {
                Appointment = appointment;
            }
            return Page();
        }
    }
}
