using System;
using System.Collections.Generic;

namespace KoiOderingSystemsRepositories.Entities;

public partial class SalesStaff
{
    public int StaffId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;
}
