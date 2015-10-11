using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedBrain.Startup))]
namespace MedBrain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
