using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SQLPlus.Web.Startup))]
namespace SQLPlus.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
