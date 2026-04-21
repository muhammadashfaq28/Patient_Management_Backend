using Microsoft.AspNetCore.Mvc;
using Week_7.Services;

namespace Week_7.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService service;
        public PatientController(IPatientService service)
        {
            this.service = service;
        }

        [HttpGet("with-appointments")]

        public async Task<IActionResult> GetAllPatientsWithAppointments()
        {
            var result = await service.GetAllPatientsWithAppointments();
            return Ok(result);
        }

        [HttpGet("no-appointments")]

        public async Task<IActionResult> GetAllPatientsWithNoAppointments()
        {
            var result = await service.GetAllPatientsWithNoAppointments();
            return Ok(result);
        }


    }
}
