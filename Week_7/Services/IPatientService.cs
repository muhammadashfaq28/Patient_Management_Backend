using Week_7.DTOs;
using Week_7.Repositories;

namespace Week_7.Services
{
    public interface IPatientService
    {
        Task<List<PatientWithAppointmentDto>> GetAllPatientsWithAppointments();
        Task<List<PatientDto>> GetAllPatientsWithNoAppointments();
    }
}
