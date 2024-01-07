using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DoctorApointmentSystem.Data;
using DoctorApointmentSystem.Models;

namespace DoctorApointmentSystem.Pages.Appointments
{
    public class CreateModel : PageModel
    {
        private readonly DoctorApointmentSystem.Data.DoctorApointmentSystemContext _context;

        public CreateModel(DoctorApointmentSystem.Data.DoctorApointmentSystemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {

            //var data = new SelectList(_context.Doctor, "DoctorId", "DoctorId");
            ViewData["DoctorId"] = new SelectList(_context.Doctor, "DoctorId", "DoctorId");
        ViewData["PatientId"] = new SelectList(_context.Patient, "PatientId", "PatientId");
            return Page();
        }


        [BindProperty]
        public Appointment Appointment { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (Appointment.PatientId==0 || Appointment.DoctorId==0)
                {
                    return Page();
                }

                _context.Appointment.Add(Appointment);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
            }

            return RedirectToPage("./Index");
        }
    }
}
