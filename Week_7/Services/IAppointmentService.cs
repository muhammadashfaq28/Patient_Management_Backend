using Week_7.DTOs;

namespace Week_7.Services
{
    public interface IAppointmentService
    {
        Task<List<AppointmentDto>> GetAppointmentByDoctor(int doctorId);
    }
}
