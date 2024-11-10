
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace KoiOderingSystemsRepositories.Entities;

public partial class Product
{
    public int KoiId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int StockQuantity { get; set; }


    public int Size { get; set; }
}
