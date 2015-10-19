using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Movie_Review_Framework.Startup))]
namespace Movie_Review_Framework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
