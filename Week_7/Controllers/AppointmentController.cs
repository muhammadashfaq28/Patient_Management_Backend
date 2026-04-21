
using Microsoft.AspNetCore.Mvc;
using Week_7.Repositories;
using Week_7.Services;

namespace Week_7.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService service;
        public AppointmentController(IAppointmentService service)
        {
            this.service = service;
        }

        [HttpGet("doctor/{doctorId}")]
        public async Task<IActionResult> GetAppointmentByDoctor(int doctorId)
        {
            var Result = await service.GetAppointmentByDoctor(doctorId);
            return Ok(Result);
        }
    }
}
