using BL.BlApi;
using BL.BlServices;
using DAL;
using Microsoft.Extensions.DependencyInjection;

namespace BL;

public class BLManager
{
    public IMotherBl Mothers;
    public IBlBabyService BabyService;
    //public BlRegistrationService Registrations { get; }
    public BLManager()
    {
        ServiceCollection services = new ServiceCollection();
        services.AddSingleton<DalManager>();
        services.AddScoped<IMotherBl, BlMotherService>();
        services.AddScoped<IBlBabyService, BlBabyService>();
       // services.AddSingleton<BlRegistrationService>();

        ServiceProvider Provider = services.BuildServiceProvider();
        Mothers = Provider.GetService<IMotherBl>();
        BabyService = Provider.GetService<IBlBabyService>();
    }

}
