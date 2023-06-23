using Microsoft.Extensions.DependencyInjection;
using SantiyeYonetim.Business.Abstract;
using SantiyeYonetim.Business.Concrete;
using SantiyeYonetim.WebMVC.Helpers.Abstract;
using SantiyeYonetim.WebMVC.Helpers.Concrete;

namespace SantiyeYonetim.WebMVC.Configurations
{
    public class ConfigureDependencies
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationManager>();

            services.AddTransient<IUserAccessor, UserAccessor>();
            services.AddTransient<IFileHelper, FileHelper>();


        }



    }
}
