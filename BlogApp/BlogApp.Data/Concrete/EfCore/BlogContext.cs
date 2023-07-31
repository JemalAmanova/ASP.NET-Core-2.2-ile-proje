using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Data.Concrete.EfCore
{
    public class BlogContext: DbContext
    {
        //yapıcı fonksion oluşturdum. (dışarıdan bir option alacak, bu option da bize connectionstringi getirecek)
        public BlogContext(DbContextOptions<BlogContext>options):base(options)
        {

        }
        //2 tane tablo tanımladım
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
