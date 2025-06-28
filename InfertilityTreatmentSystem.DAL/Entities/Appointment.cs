using System;
using System.Collections.Generic;

namespace InfertilityTreatmentSystem.DAL.Entities;

public partial class Appointment
{
    public Guid AppointmentId { get; set; }

    public Guid CustomerId { get; set; }

    public Guid DoctorId { get; set; }

    public Guid ServiceId { get; set; }

    public DateTime AppointmentDate { get; set; }

    public string? Status { get; set; }

    public string? RejectReason { get; set; }

    public virtual User Customer { get; set; } = null!;

    public virtual User Doctor { get; set; } = null!;

    public virtual ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();

    public virtual TreatmentService Service { get; set; } = null!;
}
