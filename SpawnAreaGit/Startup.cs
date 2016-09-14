using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpawnAreaGit.Startup))]
namespace SpawnAreaGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
