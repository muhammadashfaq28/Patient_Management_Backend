using Week_7.DTOs;
using Week_7.Repositories;

namespace Week_7.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository repo;

        public AppointmentService(IAppointmentRepository repo)
        {
            this.repo = repo;
        }

        public async Task<List<AppointmentDto>> GetAppointmentByDoctor(int doctorId)
        {
            if (doctorId <= 0)
                throw new Exception("Invalid doctor id");

            var result = await repo.GetAppointmentByDoctor(doctorId);

            if (result == null || result.Count == 0)
                throw new Exception("No Doctor Found Against this ID");

            return result;
        }
    }
}