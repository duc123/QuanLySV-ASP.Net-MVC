using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quan_ly_sinh_vien_5_tot.Startup))]
namespace Quan_ly_sinh_vien_5_tot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
