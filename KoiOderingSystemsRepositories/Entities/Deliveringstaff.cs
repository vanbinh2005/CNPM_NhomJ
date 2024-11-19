using System;
using System.Collections.Generic;

namespace KoiOderingSystemsRepositories.Entities;

public partial class Deliveringstaff
{
    public int Staffid { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public int? PhoneNumber { get; set; }
}
