using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstFullStackSocialMedia.Startup))]
namespace FirstFullStackSocialMedia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
