using System;
using Microsoft.AspNetCore.Hosting;
 
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
 
            var host = new WebHostBuilder()
            .UseKestrel()
            .UseStartup<Startup>()
            .UseUrls("http://*:8080")
            .Build();
 
            host.Run();
        }
    }
}
