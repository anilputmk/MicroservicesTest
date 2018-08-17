using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ASPNet_Microservice
{
    public class StartUp
    {
        public StartUp(IHostingEnvironment environment) {
            
        }

        public void Configure(IApplicationBuilder application, IHostingEnvironment environment, ILoggerFactory loggerFactory)
        {
            application.Run(async (context) => {
                await context.Response.WriteAsync("Hello World !");
            });
        }
    }
}
