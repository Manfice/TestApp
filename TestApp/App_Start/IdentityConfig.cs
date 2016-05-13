using Microsoft.Owin;
using Owin;
[assembly:OwinStartup(typeof(TestApp.IdentityConfig))]
namespace TestApp
{
    public class IdentityConfig
    {
         public void Configuration(IAppBuilder app) { }
    }
}