using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BooksAPI_Jason.Startup))]

namespace BooksAPI_Jason
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureOAuth(app);
        }
    }
}