using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectLesson10.Startup))]
namespace ProjectLesson10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
