using System;
using System.Collections.Generic;

namespace SERVER.Models;

public partial class RoomType
{
    public int IdType { get; set; }

    public string TypeName { get; set; } = null!;

    public virtual ICollection<Registration> Registrations { get; set; } = new List<Registration>();

    public virtual RoomPrice? RoomPrice { get; set; }
}
