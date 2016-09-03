using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
 
namespace ConsoleApplication {
    public class Startup{
        public void Configure(IApplicationBuilder app){
            app.Run(context => {
                System.Diagnostics.StackTrace t = new System.Diagnostics.StackTrace();
                string response = t.ToString();
                //return context.Response.WriteAsync("Hello world");
                return context.Response.WriteAsync(response);
            });
        }
    }
}
