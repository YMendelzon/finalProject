using SERVER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalApi;

public interface IRoomTypeDal
{
    public List<RoomType> GetRoomTypeList();
}
