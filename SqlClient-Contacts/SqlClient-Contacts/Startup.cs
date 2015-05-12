using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SqlClient_Contacts.Startup))]
namespace SqlClient_Contacts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
