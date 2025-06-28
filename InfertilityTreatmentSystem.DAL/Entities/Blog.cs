using System;
using System.Collections.Generic;

namespace InfertilityTreatmentSystem.DAL.Entities;

public partial class Blog
{
    public Guid BlogId { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public DateTime? CreatedDate { get; set; }

    public Guid UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
