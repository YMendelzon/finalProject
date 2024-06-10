using System;
using System.Collections.Generic;

namespace SERVER.Models;

public partial class RoomPrice
{
    public int IdRoom { get; set; }

    public string IdType { get; set; } = null!;

    public int? Price { get; set; }

    public virtual RoomType IdRoomNavigation { get; set; } = null!;
}
