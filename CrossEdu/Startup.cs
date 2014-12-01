using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrossEdu.Startup))]
namespace CrossEdu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
