using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(spocksCalculator.Startup))]
namespace spocksCalculator
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
