using DAL.DalApi;
using DAL;
using SERVER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.BlApi;

namespace BL.BlServices;

public class BlRoomTypesService:IRoomTypeBl
{
    IRoomTypeDal roomTypes;
    public BlRoomTypesService(DalManager dal)
    {
        this.roomTypes = dal.RoomTypes;//הסרויס של האמהות מהדל
    }

    public List<RoomType> GetRoomTypeList()
    {
        List<RoomType> roomTypesList = new();// List<BlSimpleMother>();
        var list = roomTypes.GetRoomTypeList();
        foreach (var g in list)
        {// עבור כל אחד יוצרת בי אל חדש
            var newMother = new RoomType()
            {
                TypeName = g.TypeName
            };
            // מוסיפה לרשימה
            roomTypesList.Add(newMother);
        }
        return roomTypesList;
    }

}
