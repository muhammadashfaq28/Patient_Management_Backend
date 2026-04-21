namespace Week_7.DTOs
{
    public class PatientWithAppointmentDto
    {
        public int PatientId { get; set; }
        public string? FirstName { get; set; }

        public List<AppointmentDto>? Appointments { get; set; }
    }
}
