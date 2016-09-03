using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
 
namespace ConsoleApplication {
    public class Startup{
        public void Configure(IApplicationBuilder app){
            app.Run(context => {
                //return context.Response.WriteAsync("Hello world");
                return context.Response.WriteAsync("Yup, this is C#.Net!" + System.Environment.NewLine + System.Environment.StackTrace);
            });
        }
    }
}
