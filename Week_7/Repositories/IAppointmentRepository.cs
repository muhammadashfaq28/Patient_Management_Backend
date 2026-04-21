using Week_7.DTOs;


namespace Week_7.Repositories
{
    public interface IAppointmentRepository
    {
        Task<List<AppointmentDto>> GetAppointmentByDoctor(int  DoctorId);
    }
}
