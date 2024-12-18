using DAL.DalApi;
using DAL.Models;
using SERVER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalServices;

public class DalRoomTypesService:IRoomTypeDal
{
    ProjectContext _RegistrationData;
    public DalRoomTypesService(ProjectContext registrationData)
    {
        _RegistrationData = registrationData;
    }
    public List<RoomType> GetRoomTypeList()
    {
        return _RegistrationData.RoomTypes.ToList();

    }
}
