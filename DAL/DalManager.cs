using DAL.DalApi;
using DAL.DalServices;
using DAL.Models;
using Microsoft.Extensions.DependencyInjection;

namespace DAL;

public class DalManager
{
    public IMotherDal Mothers { get; }
    public DalRegistrationService Registrations { get; }
    public DalManager()
    {
        ServiceCollection services = new ServiceCollection();
        services.AddSingleton<ProjectContext>();
        services.AddSingleton<IMotherDal, DalMotherService>();
        //services.AddSingleton<DalRegistrationService>();

        ServiceProvider Provider = services.BuildServiceProvider();
        Mothers = Provider.GetService<IMotherDal>();
    }
}
