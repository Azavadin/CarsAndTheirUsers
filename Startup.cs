using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarsAndTheirUsers.Startup))]
namespace CarsAndTheirUsers
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
