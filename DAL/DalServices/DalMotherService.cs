using DAL.DalApi;
using DAL.Models;
using SERVER.Models;

namespace DAL.DalServices;

public class DalMotherService : IMotherDal
{
    ProjectContext _RegistrationData;
    public DalMotherService(ProjectContext registrationData)
    {
        _RegistrationData = registrationData;
    }
    public List<Mother> GetMotherList()
    {
        return _RegistrationData.Mothers.ToList();

    }
}
