﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Interfaces;
using Shop.Data.Mocks;

namespace Shop
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient < IAllCars,MockCars>();
            services.AddTransient<ICarsCategory, MockCategory>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();//выводит ошибки непосредственно на самой странице
            app.UseStatusCodePages();// возращает коды запросов
            app.UseStaticFiles();//Использование статических файлов(.css , .jpg)
            app.UseMvcWithDefaultRoute(); //url link который вызывает контроллер по умолчанию (если за данным роутом не закремлён контроллер)
            /*app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Production!");
            });*/
        }
    }
}
