using Week_7.Models;
using Week_7.DTOs;
namespace Week_7.Repositories
{
    public interface IPatientRepository
    {
        Task<List<PatientWithAppointmentDto>> GetAllPatientsWithAppointments();
        Task<List<PatientDto>> GetAllPatientsWithNoAppointments();
    }
}
