using System;
using System.Collections.Generic;

namespace KoiOderingSystemsRepositories.Entities;

public class Tour
{
    public int TourId { get; set; }
    public string DepartureCity { get; set; }
    public string DestinationCity { get; set; }
    public DateTime DepartureDate { get; set; }
    public decimal Price { get; set; }  

}
