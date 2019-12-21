using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TestWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        //#if NET40
        //Console.WriteLine("Target framework: .NET Framework 4.0");
        //#elif NET45
        //Console.WriteLine("Target framework: .NET Framework 4.5");
        //#else
        //    Console.WriteLine("Target framework: .NET Core 2.0");
        //    #endif
        //    Console.ReadKey();
        }
        
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
