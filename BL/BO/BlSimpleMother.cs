using BL.BlApi;

namespace BL.BO;

public class BlSimpleMother 
{
    public string MotherName { get; set; }

    public int IdMother { get; set; }

    public string Phone { get; set; } = null!;

    public DateTime BabySDateOfBirth { get; set; }

    public int IdRoom { get; set; }

    //public virtual RoomPrice IdRoomNavigation { get; set; } = null!;

    //  public virtual ICollection<Registration> Registrations { get; set; } = new List<Registration>();
}
