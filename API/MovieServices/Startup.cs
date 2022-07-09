using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieServices.Interface;
using MovieServices.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieServices
{
    public class Startup
    {
        public static IServiceCollection _services;
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            _services = services;
            services.AddSingleton<IMovie, MovieService>();
        }
     }
}
