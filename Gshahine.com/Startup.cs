namespace Gshahine.com
{
    using Microsoft.Owin;
    using Owin;

    public static class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);

            app.MapSignalR();
        }
    }
}