using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyExample_DutyManagementSystem.Startup))]
namespace MyExample_DutyManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
