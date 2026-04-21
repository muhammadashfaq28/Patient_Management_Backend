using Week_7.Repositories;
using Week_7.DTOs;

namespace Week_7.Services
{
    public class PatientService : IPatientService
    {
        readonly IPatientRepository repo;
        public PatientService( IPatientRepository repo) {
            this.repo = repo;
        }
        public async Task<List<PatientWithAppointmentDto>> GetAllPatientsWithAppointments()
        {
            var result = await repo.GetAllPatientsWithAppointments();

            if (result == null || result.Count == 0)

                throw new Exception("No Patient Found");

            return result;
        }

        public async Task<List<PatientDto>> GetAllPatientsWithNoAppointments()
        {
            var result = await repo.GetAllPatientsWithNoAppointments();

            if (result == null || result.Count == 0)
                throw new Exception("No patients without appointments found");

            return result;
        }
    }
}
