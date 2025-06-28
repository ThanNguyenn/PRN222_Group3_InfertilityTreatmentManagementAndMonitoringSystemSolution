using System;
using System.Collections.Generic;

namespace InfertilityTreatmentSystem.DAL.Entities;

public partial class User
{
    public enum UserRole
    {
        Customer,
        Doctor,
        Admin
    }

    public Guid UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? FullName { get; set; }

    public int? Age { get; set; }

    public string? PhoneNumber { get; set; }

    public UserRole Role { get; set; } = UserRole.Customer;

    public bool IsActive { get; set; }

    public virtual ICollection<Appointment> AppointmentCustomers { get; set; } = new List<Appointment>();

    public virtual ICollection<Appointment> AppointmentDoctors { get; set; } = new List<Appointment>();

    public virtual ICollection<Blog> Blogs { get; set; } = new List<Blog>();

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual ICollection<MedicalRecord> MedicalRecordCustomers { get; set; } = new List<MedicalRecord>();

    public virtual ICollection<MedicalRecord> MedicalRecordDoctors { get; set; } = new List<MedicalRecord>();

    public virtual ICollection<PatientRequest> PatientRequestCustomers { get; set; } = new List<PatientRequest>();

    public virtual ICollection<PatientRequest> PatientRequestDoctors { get; set; } = new List<PatientRequest>();

    public virtual ICollection<Schedule> ScheduleCustomers { get; set; } = new List<Schedule>();

    public virtual ICollection<Schedule> ScheduleDoctors { get; set; } = new List<Schedule>();

    public virtual ICollection<TreatmentService> TreatmentServices { get; set; } = new List<TreatmentService>();
}
