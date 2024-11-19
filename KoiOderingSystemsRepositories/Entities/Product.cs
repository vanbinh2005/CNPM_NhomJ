
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace KoiOderingSystemsRepositories.Entities;

public class Product
{
    public int KoiId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public int Stock { get; set; }
}
