using System;
using System.Collections.Generic;

namespace InfertilityTreatmentSystem.DAL.Entities;

public partial class TreatmentService
{
    public Guid ServiceId { get; set; }

    public string? ServiceName { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public Guid UserId { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<PatientRequest> PatientRequests { get; set; } = new List<PatientRequest>();

    public virtual User User { get; set; } = null!;
}
