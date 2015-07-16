using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChallengePostageCalculatorHelperMethods.Startup))]
namespace ChallengePostageCalculatorHelperMethods
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
