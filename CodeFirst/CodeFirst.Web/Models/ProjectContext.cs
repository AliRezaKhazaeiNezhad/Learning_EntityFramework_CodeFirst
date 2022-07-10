
using CodeFirst.Web.Models;
using System.Data.Entity;

namespace CodeFirst.Web.Models
{
    public class ProjectContext : DbContext
    {
        ///Lesson1000
        ///ایجاد اتصال اولیه
        //public ProjectContext() : base("ProjectConnection")
        //{
        //}





        ///Lesson1100
        ///افزودن جداول
        //public ProjectContext() : base("ProjectConnection")
        //{
        //}

        //public DbSet<Template> Templates { get; set; }








        ///Lesson1200
        ///افزودن خصوصیات بیشتر به جداول
        //public ProjectContext() : base("ProjectConnection")
        //{
        //}

        //public DbSet<Template> Templates { get; set; }







        ///Lesson1300
        ///ایجاد دو جدول برای ارتباط یک به چند
        //public ProjectContext() : base("ProjectConnection")
        //{
        //}

        //public DbSet<BlogCategory> BlogCategories { get; set; }
        //public DbSet<Blog> Blogs { get; set; }









        ///Lesson1400
        ///ایجاد دو جدول برای ارتباط چند به چند
        //public ProjectContext() : base("ProjectConnection")
        //{
        //}

        //public DbSet<BlogCategory> BlogCategories { get; set; }
        //public DbSet<Product> Blogs { get; set; }


        //public DbSet<Product> Products { get; set; }
        //public DbSet<ProductCategory> ProductCategories { get; set; }

    }
}