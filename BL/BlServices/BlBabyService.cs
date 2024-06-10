using BL.BlApi;

namespace BL.BlServices;

public class BlBabyService : IBlBabyService
{
    public BlBabyService()
    {

    }
    //public List<Mother> GetMotherList()
    //{
    //    List<Mother> list = new List<Mother>();
    //    // ...
    //    return list;
    //}

    //public List<RoomPrice> GetRoomsAbleList(DateTime enterDate)
    //{
    //    DateTime startDate = enterDate.AddDays(-5);
    //    DateTime endDate = enterDate.AddDays(5);
    //}

    public bool IsBabyAbled(DateOnly birthDate, DateOnly enterDate)
    {
        return enterDate < birthDate.AddDays(30);
    }
}
