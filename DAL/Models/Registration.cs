using System;
using System.Collections.Generic;

namespace SERVER.Models;

public partial class Registration
{
    public int IdRegistration { get; set; }

    public int IdMother { get; set; }

    public int IdRoom { get; set; }

    public DateTime ArrivalDate { get; set; }

    public DateTime DepartureDate { get; set; }

    public virtual Mother IdMotherNavigation { get; set; } = null!;

    public virtual RoomType IdRoomNavigation { get; set; } = null!;
}
