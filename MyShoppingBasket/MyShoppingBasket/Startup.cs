using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShoppingBasket.Startup))]
namespace MyShoppingBasket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
