using BlogApp.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogApp.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            BlogContext context = app.ApplicationServices.GetRequiredService<BlogContext>();
            context.Database.Migrate();

            if (!context.Categories.Any())
            {
                //kayıtekliyoruz
                context.Categories.AddRange(
                    new Category() {Name = "Category1" },
                    new Category() {Name = "Category2" },
                    new Category() {Name = "Category3" }

                    );
                context.SaveChanges();
            }


                //Blogsa eklenen herhangi vir kayıt var mı diye kontrol ediyoruz
                if (!context.Blogs.Any())
            {
                //kayıt ekliyoruz
                context.Blogs.AddRange(
                    new Blog() { Title="Blog Title 1", Description="Hayvanlar ile ilgili", Body="Blog Body 1", Image="1.jpg", Date=DateTime.Now.AddDays(-5), IsApproved=true, CategoryId=1},
                    new Blog() { Title = "Blog Title 2", Description = "Hayvanlar ile ilgili", Body = "Blog Body 2", Image = "2.jpg", Date = DateTime.Now.AddDays(-7), IsApproved = true, CategoryId = 2 },
                    new Blog() { Title = "Blog Title 3", Description = "Hayvanlar ile ilgili", Body = "Blog Body 3", Image = "3.jpg", Date = DateTime.Now.AddDays(-9), IsApproved = true, CategoryId = 3 }
                    
                    );
                context.SaveChanges();
            }
        }
    }
}
