using System;
using System.Collections.Generic;

namespace InfertilityTreatmentSystem.DAL.Entities;

public partial class PatientRequest
{
    public Guid RequestId { get; set; }

    public Guid CustomerId { get; set; }

    public Guid DoctorId { get; set; }

    public Guid ServiceId { get; set; }

    public string? Note { get; set; }

    public DateTime RequestedDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual User Customer { get; set; } = null!;

    public virtual User Doctor { get; set; } = null!;

    public virtual TreatmentService Service { get; set; } = null!;
}
