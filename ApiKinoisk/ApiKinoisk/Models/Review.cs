using System;
using System.Collections.Generic;

namespace ApiKinoisk.Models;

public partial class Review
{
    public int ReviewId { get; set; }

    public int UserId { get; set; }

    public int ContentId { get; set; }

    public int Rating { get; set; }

    public string? ReviewText { get; set; }

    public DateTime? ReviewDate { get; set; }

    public virtual Content Content { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
