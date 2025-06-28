using System;
using System.Collections.Generic;

namespace InfertilityTreatmentSystem.DAL.Entities;

public partial class Schedule
{
    public Guid ScheduleId { get; set; }

    public Guid CustomerId { get; set; }

    public Guid DoctorId { get; set; }

    public string? SerivceName { get; set; }

    public DateTime? ScheduleDate { get; set; }

    public string? Note { get; set; }

    public virtual User Customer { get; set; } = null!;

    public virtual User Doctor { get; set; } = null!;
}
