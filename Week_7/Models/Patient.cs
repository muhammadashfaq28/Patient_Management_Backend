using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Week_7.Models;

[Index("Email", Name = "UQ__Patients__A9D105349C7BDD41", IsUnique = true)]
public partial class Patient
{
    [Key]
    public int PatientId { get; set; }

    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [StringLength(50)]
    public string LastName { get; set; } = null!;

    [StringLength(50)]
    public string? Gender { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateOfBirth { get; set; }

    [StringLength(50)]
    public string? City { get; set; }

    [StringLength(50)]
    public string? PhoneNumber { get; set; }

    [StringLength(50)]
    public string? Email { get; set; }

    [InverseProperty("Patient")]
    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
