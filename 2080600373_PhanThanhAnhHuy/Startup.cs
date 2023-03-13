using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2080600373_PhanThanhAnhHuy.Startup))]
namespace _2080600373_PhanThanhAnhHuy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
