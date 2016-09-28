using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieGrid.Startup))]
namespace MovieGrid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
