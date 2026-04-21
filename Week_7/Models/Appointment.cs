using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Week_7.Models;

public partial class Appointment
{
    [Key]
    public int AppointmentId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AppointmentDate { get; set; }

    [StringLength(20)]
    public string? Status { get; set; }

    [StringLength(200)]
    public string? Reason { get; set; }

    public int PatientId { get; set; }

    public int DoctorId { get; set; }

    [ForeignKey("DoctorId")]
    [InverseProperty("Appointments")]
    public virtual Doctor Doctor { get; set; } = null!;

    [ForeignKey("PatientId")]
    [InverseProperty("Appointments")]
    public virtual Patient Patient { get; set; } = null!;
}
