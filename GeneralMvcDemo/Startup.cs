using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GeneralMvcDemo.Startup))]
namespace GeneralMvcDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
