using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JC_Family_demo_.Startup))]
namespace JC_Family_demo_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
