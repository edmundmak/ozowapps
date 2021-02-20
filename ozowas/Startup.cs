using gameoflife;
using Microsoft.Extensions.DependencyInjection;
using Sorting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ozowapps
{
   public class Startup
    {
        private readonly IServiceProvider provider;
        // access the built service pipeline
        public IServiceProvider Provider => provider;
        public Startup()
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            // instantiate
            var services = new ServiceCollection();
            services.AddSingleton<IGetSorting, GetSorting>();
            services.AddSingleton<IGames, Game>();
            // build the pipeline
            provider = services.BuildServiceProvider();
        }
              
    }
}
