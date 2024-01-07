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
    public class IndexModel : PageModel
    {
        private readonly DoctorApointmentSystem.Data.DoctorApointmentSystemContext _context;

        public IndexModel(DoctorApointmentSystem.Data.DoctorApointmentSystemContext context)
        {
            _context = context;
        }

        public IList<Doctor> Doctor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Doctor != null)
            {
                Doctor = await _context.Doctor.ToListAsync();
            }
        }
    }
}
