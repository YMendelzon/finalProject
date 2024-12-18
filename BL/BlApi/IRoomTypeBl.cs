using SERVER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlApi;

public interface IRoomTypeBl
{
    public List<RoomType> GetRoomTypeList();
}
