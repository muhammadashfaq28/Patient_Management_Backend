using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Week_7.Models;

[Index("Email", Name = "UQ__Doctors__A9D105349EDE6337", IsUnique = true)]
public partial class Doctor
{
    [Key]
    public int DoctorId { get; set; }

    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [StringLength(50)]
    public string LastName { get; set; } = null!;

    [StringLength(100)]
    public string Specialization { get; set; } = null!;

    [StringLength(10)]
    public string? Gender { get; set; }

    [StringLength(50)]
    public string? City { get; set; }

    [StringLength(20)]
    public string? PhoneNumber { get; set; }

    [StringLength(100)]
    public string? Email { get; set; }

    [InverseProperty("Doctor")]
    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
