using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheDinnerQuestion.Startup))]
namespace TheDinnerQuestion
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
