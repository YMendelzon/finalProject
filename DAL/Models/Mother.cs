using System;
using System.Collections.Generic;

namespace SERVER.Models;

public partial class Mother
{
    public int IdMother { get; set; }

    public string MotherName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<Baby> Babies { get; set; } = new List<Baby>();

    public virtual ICollection<Registration> Registrations { get; set; } = new List<Registration>();
}
