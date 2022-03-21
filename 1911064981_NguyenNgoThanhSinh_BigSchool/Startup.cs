using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911064981_NguyenNgoThanhSinh_BigSchool.Startup))]
namespace _1911064981_NguyenNgoThanhSinh_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
