using System;
using System.Collections.Generic;

namespace InfertilityTreatmentSystem.DAL.Entities;

public partial class MedicalRecord
{
    public Guid RecordId { get; set; }

    public Guid AppointmentId { get; set; }

    public Guid DoctorId { get; set; }

    public Guid CustomerId { get; set; }

    public string? Prescription { get; set; }

    public string? TestResults { get; set; }

    public string? Note { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual Appointment Appointment { get; set; } = null!;

    public virtual User Customer { get; set; } = null!;

    public virtual User Doctor { get; set; } = null!;
}
