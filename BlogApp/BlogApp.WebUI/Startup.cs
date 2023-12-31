﻿using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete.EfCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.WebUI
{
    public class Startup

    {

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ICategoryRepository, EfCategoryRepository>();
            services.AddTransient<IBlogRepository, EfBlogRepository>();
            // Blogdatadaki BlogContexti uygulamaya tanıttık
            services.AddDbContext<BlogContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b=>b.MigrationsAssembly("BlogApp.WebUI")));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            { //hata sayfalarını bize gösterir
                app.UseDeveloperExceptionPage();
            }
            //static sayfalarını erişilebilir yaptık(wwwroot)
            app.UseStaticFiles();

            //node_moduls klasörünü dışarıya açtık
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider= new PhysicalFileProvider(
                     Path.Combine(Directory.GetCurrentDirectory(), "node_modules")),
                RequestPath="/modules"

            });


            //durum sayfalarını ekledik
            app.UseStatusCodePages();
            app.UseMvc (rutes =>
            {
                rutes.MapRoute(
                    name: "default",
                    template: "{controller=home}/{action=Index}/{id?}");
            });
            //SeedDatanın Seed metodunu çağırıyoruz
            SeedData.Seed(app);
        }
    }
}
