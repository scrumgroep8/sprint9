using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoundsharpMVC.Startup))]
namespace SoundsharpMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
