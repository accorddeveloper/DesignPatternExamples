using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DesignPatternExamples.Startup))]
namespace DesignPatternExamples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
