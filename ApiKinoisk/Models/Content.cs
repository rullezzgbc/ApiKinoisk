using System;
using System.Collections.Generic;

namespace ApiKinoisk.Models;

public partial class Content
{
    public int ContentId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public int? Duration { get; set; }

    public DateOnly? ReleaseDate { get; set; }

    public decimal? Price { get; set; }

    public decimal? RentalPrice { get; set; }

    public int? RentalDuration { get; set; }

    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();

    public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
