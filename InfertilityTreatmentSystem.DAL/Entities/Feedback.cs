using System;
using System.Collections.Generic;

namespace InfertilityTreatmentSystem.DAL.Entities;

public partial class Feedback
{
    public Guid FeedbackId { get; set; }

    public Guid CustomerId { get; set; }

    public int? Rating { get; set; }

    public string? Comment { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual User Customer { get; set; } = null!;
}
