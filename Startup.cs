using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
 
namespace ConsoleApplication {
    public class Startup{
        public void Configure(IApplicationBuilder app){
            app.Run(context => {
                //return context.Response.WriteAsync("Hello world");
                return context.Response.WriteAsync(System.Environment.StackTrace);
            });
        }
    }
}
