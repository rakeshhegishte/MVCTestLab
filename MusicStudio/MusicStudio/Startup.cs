using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicStudio.Startup))]
namespace MusicStudio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
