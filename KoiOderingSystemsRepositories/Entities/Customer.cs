using System;
using System.Collections.Generic;

namespace KoiOderingSystemsRepositories.Entities;

public partial class Customer
{
    public int CustomerId { get; set; }
<<<<<<< HEAD

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone{ get; set; } = null!;

    public string? Address { get; set; }

    public string Password { get; set; } = null!;


    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    public object PhoneNumber { get; internal set; }
=======
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string? Address { get; set; }
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    public object Fullname { get; set; }
    public object Password { get; set; }
    public object Phone { get; set; }
>>>>>>> b8788f25a8611fcba17269a1e22778d1b371024b
}
