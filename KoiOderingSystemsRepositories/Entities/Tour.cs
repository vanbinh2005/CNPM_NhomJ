using System;
using System.Collections.Generic;

namespace KoiOderingSystemsRepositories.Entities;

public partial class Tour
{
    public int TourId { get; set; }

    public string FarmName { get; set; } = null!;

    public decimal Price { get; set; }

    public int Duration { get; set; }

    public string? Description { get; set; }
}
