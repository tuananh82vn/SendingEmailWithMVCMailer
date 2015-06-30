using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SendingEmailWithMvcMailer.Startup))]
namespace SendingEmailWithMvcMailer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
