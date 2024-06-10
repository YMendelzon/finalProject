using System;
using System.Collections.Generic;

namespace SERVER.Models;

public partial class Baby
{
    public int BabyId { get; set; }

    public string Name { get; set; } = null!;

    public int MotherId { get; set; }

    public DateTime DateOfBirth { get; set; }

    public virtual Mother Mother { get; set; } = null!;
}
