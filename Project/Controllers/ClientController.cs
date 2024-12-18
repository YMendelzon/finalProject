using BL;
using BL.BlApi;
using BL.BO;
using Microsoft.AspNetCore.Mvc;
using SERVER.Models;

namespace SERVER.Controllers;
[ApiController]
[Route("api/[controller]")]

public class ClientController : ControllerBase
{
    IBlBabyService BabyService;
    IMotherBl blmother;
    IRoomTypeBl blRoomType;
    public ClientController(BLManager bl)
    {
        this.blmother = bl.Mothers;
        this.BabyService = bl.BabyService;
        this.blRoomType = bl.RoomType;
    }


  
    [HttpGet("isAble")]
    public bool IsAble(DateOnly birthDate, DateOnly enterDate)
    {
        return BabyService.IsBabyAbled(birthDate, enterDate);
    }

    //[HttpGet("roomsAble")]
    // שולחת לBL
    //public List<RoomPrice> GetRoomsAbleList(DateOnly enterDate)
    //{
    //    BabyService.GetRoomsAbleList(enterDate);

    //}
    //[HttpGet("allMothers")]
    //public List<Mother> GetAllMothers()
    //{
    //    return
    //}

    [HttpGet("getAllMothers")]
    public List<Mother> GetMother()
    {
        return blmother.GetMotherList();
    }

    [HttpGet("getRoomTypes")]
    public List<RoomType> GetRoomTypeList()
    {
        return blRoomType.GetRoomTypeList();
    }
}
