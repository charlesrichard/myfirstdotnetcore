using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Net;
 
namespace ConsoleApplication {
    public class Startup{
        public void Configure(IApplicationBuilder app){
            app.Run(context => {
                //return context.Response.WriteAsync("Hello world");
                return context.Response.WriteAsync("Yup, this is C#.Net, written by chuck!!" + 
                       System.Environment.NewLine + 
                       System.Environment.NewLine + 
                       "Host name: " + Dns.GetHostName().ToString() + 
                       System.Environment.NewLine + 
                       System.Environment.NewLine +
                       System.Environment.StackTrace);
            });
        }
    }
}
