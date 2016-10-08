//namespace Gshahine.com
//{
//    using Owin;
//    using System;
//    using System.Collections.Generic;
//    using System.Linq;
//    using System.Web;

//    public partial class Startup
//    {
//        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
//        public void ConfigureAuth(IAppBuilder app)
//        {
//            //app.CreatePerOwinContext<ResoltzDbContext>(ResoltzDbContext.Create);
//            //app.CreatePerOwinContext<ResoltzUserManager>(ResoltzUserManager.Create);

//            // Enable the application to use a cookie to store information for the signed in user
//            /* app.UseCookieAuthentication(new CookieAuthenticationOptions
//             {
//                 AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
//                 //AuthenticationMode = AuthenticationMode.Passive, // **Authentication Mode must be active
//                 LoginPath = new PathString(ResoltzConstants.SigninPath),
//                 LogoutPath = new PathString(ResoltzConstants.SignoutPath),
//                 ExpireTimeSpan = TimeSpan.FromDays(3),
//                 SlidingExpiration = true,
//             });

//             // Use a cookie to temporarily store information about a user logging in with a third party login provider
//             app.SetDefaultSignInAsAuthenticationType(DefaultAuthenticationTypes.ExternalCookie);

//             app.UseCookieAuthentication(new CookieAuthenticationOptions
//             {
//                 AuthenticationType = DefaultAuthenticationTypes.ExternalCookie,
//                 //AuthenticationMode = AuthenticationMode.Passive,
//                 CookieName = CookieAuthenticationDefaults.CookiePrefix + DefaultAuthenticationTypes.ExternalCookie,
//                 ExpireTimeSpan = TimeSpan.FromDays(3),
//                 SlidingExpiration = true,
//             });*/

//            /* var clientId = ConfigurationManager.AppSettings["client_id"];
//             var clientSecret = ConfigurationManager.AppSettings["client_secret"];

//             var googleOptions = new GoogleOAuth2AuthenticationOptions
//             {
//                 ClientId = clientId,
//                 ClientSecret = clientSecret,
//             };

//             app.UseGoogleAuthentication(googleOptions);*/


//            //app.UseGoogleAuthentication();
//        }
//    }
//}