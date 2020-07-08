using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Instagram.Services.User.Installers
{
    public class MvcInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMvc();
            services.AddControllers();
            services.AddLogging();
        }
    }
}