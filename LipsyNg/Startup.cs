﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LipsyNg.Data;
using LipsyNg.Data.Interfaces;
using LipsyNg.Data.Mocks;
using LipsyNg.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LipsyNg
{
    public class Startup
    {

        private IConfigurationRoot configurationRoot;

        public Startup(IHostingEnvironment hostingEnvironment)
        {
            configurationRoot = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath)
                                                          .AddJsonFile("appsettings.json")
                                                          .Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configurationRoot.GetConnectionString("DefaultConnection")));
            services.AddTransient<ILipstickRepository, LipstickRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //if (env.IsProduction())
            //{
            //    //include view to display to user.
            //}

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
