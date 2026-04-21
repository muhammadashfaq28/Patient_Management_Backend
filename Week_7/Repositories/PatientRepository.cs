using Microsoft.EntityFrameworkCore;
using Week_7.Models;
using Week_7.DTOs;

namespace Week_7.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly AppDbContext context;

        public PatientRepository(AppDbContext context)
        {
            this.context = context;
        }


        public async Task<List<PatientWithAppointmentDto>> GetAllPatientsWithAppointments()
        {
            return await context.Patients
                .Where (p => p.Appointments.Any())
                .Select(p => new PatientWithAppointmentDto
                {
                    PatientId = p.PatientId,
                    FirstName = p.FirstName,

                   
                    Appointments = p.Appointments.Select(a => new AppointmentDto
                    {
                        AppointmentId = a.AppointmentId,
                        AppointmentDate = a.AppointmentDate,
                        DoctorId = a.DoctorId,
                        PatientId = a.PatientId
                    }).ToList()
                })
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<PatientDto>> GetAllPatientsWithNoAppointments()
        {
            return await context.Patients
                .Where(p => !p.Appointments.Any())
                .Select(p => new PatientDto
                {
                    PatientId = p.PatientId,
                    FirstName = p.FirstName
                })
                .AsNoTracking()
                .ToListAsync();
        }
    }
}