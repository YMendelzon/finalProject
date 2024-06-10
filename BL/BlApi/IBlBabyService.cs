namespace BL.BlApi;

public interface IBlBabyService
{
    public bool IsBabyAbled(DateOnly birthDate, DateOnly enterDate);
    //public List<RoomPrice> GetRoomsAbleList(DateOnly enterDate);
    //public List<Mother> GetMotherList();
}
