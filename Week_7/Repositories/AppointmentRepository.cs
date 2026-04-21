using Microsoft.EntityFrameworkCore;
using Week_7.Models;
using Week_7.DTOs;

namespace Week_7.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppDbContext context;
        public AppointmentRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<AppointmentDto>> GetAppointmentByDoctor(int DoctorId)
        {
            return await context.Appointments
                .Where(a =>  a.DoctorId == DoctorId)
                .Select(a => new AppointmentDto {
                    AppointmentId = a.AppointmentId,
                    AppointmentDate = a.AppointmentDate,
                    DoctorId = a.DoctorId,
                    PatientId = a.PatientId,
                })
                .AsNoTracking ()
                .ToListAsync ();
        }
    }
}
