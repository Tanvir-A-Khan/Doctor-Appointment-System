using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DoctorApointmentSystem.Models;

namespace DoctorApointmentSystem.Data
{
    public class DoctorApointmentSystemContext : DbContext
    {
        public DoctorApointmentSystemContext (DbContextOptions<DoctorApointmentSystemContext> options)
            : base(options)
        {
        }

        public DbSet<DoctorApointmentSystem.Models.Doctor> Doctor { get; set; } = default!;

        public DbSet<DoctorApointmentSystem.Models.Patient> Patient { get; set; } = default!;

        public DbSet<DoctorApointmentSystem.Models.Appointment> Appointment { get; set; } = default!;
    }
}
