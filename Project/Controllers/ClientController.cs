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

    public ClientController(BLManager bl)
    {
        this.blmother = bl.Mothers;
        this.BabyService = bl.BabyService;
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

}
