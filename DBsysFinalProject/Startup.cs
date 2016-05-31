using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBsysFinalProject.Startup))]
namespace DBsysFinalProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
