using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ASPNet_Microservice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var config = new ConfigurationBuilder().AddCommandLine(args).Build();
            //var host = new WebHostBuilder().UseKestrel().UseStartup<Startup>().UseConfiguration(config).Build();
            //host.Run();
            var config = new ConfigurationBuilder().AddCommandLine(args).Build();
            var host = new WebHostBuilder().UseKestrel().UseStartup<StartUp>().UseConfiguration(config).Build();
            host.Run();
            //CreateWebHostBuilder(args).Build().Run();
        }

        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            //WebHost.CreateDefaultBuilder(args)
                //.UseStartup<Startup>();
    }
}
