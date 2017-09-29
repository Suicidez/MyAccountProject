using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyAccount.Startup))]
namespace MyAccount
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
