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
    public class IndexModel : PageModel
    {
        private readonly DoctorApointmentSystem.Data.DoctorApointmentSystemContext _context;

        public IndexModel(DoctorApointmentSystem.Data.DoctorApointmentSystemContext context)
        {
            _context = context;
        }

        public IList<Appointment> Appointment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Appointment != null)
            {
                Appointment = await _context.Appointment
                .Include(a => a.DoctorData)
                .Include(a => a.PatientData).ToListAsync();
            }
        }
    }
}
