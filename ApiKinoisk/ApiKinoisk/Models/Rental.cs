using System;
using System.Collections.Generic;

namespace ApiKinoisk.Models;

public partial class Rental
{
    public int RentalId { get; set; }

    public int UserId { get; set; }

    public int ContentId { get; set; }

    public DateTime? RentalStartDate { get; set; }

    public DateTime RentalEndDate { get; set; }

    public decimal RentalPrice { get; set; }

    public virtual Content Content { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
