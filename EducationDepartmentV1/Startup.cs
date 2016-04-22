using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EducationDepartmentV1.Startup))]
namespace EducationDepartmentV1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

    }
}
