using BL.BlApi;
using BL.BO;
using DAL;
using DAL.DalApi;
using DAL.Models;
using SERVER.Models;

namespace BL.BlServices;

public class BlMotherService : IMotherBl
{
    IMotherDal mothers;
    public BlMotherService(DalManager dal)
    {
        this.mothers = dal.Mothers;//הסרויס של האמהות מהדל
    }

    public List<Mother> GetMotherList()
    {
        List<Mother> motherlist = new();// List<BlSimpleMother>();
        var list = mothers.GetMotherList();
        foreach (var g in list)
        {// עבור כל אחד יוצרת בי אל חדש
            var newMother = new Mother()
            {
                IdMother = g.IdMother,
                MotherName = g.MotherName
            };
            // מוסיפה לרשימה
            motherlist.Add(newMother);
        }
        return motherlist;
    }


}
