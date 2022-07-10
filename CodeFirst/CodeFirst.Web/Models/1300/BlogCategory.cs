
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Web.Models
{
    public class BlogCategory
    {
        public BlogCategory()
        {

        }

        [Key]
        public int Id { get; set; }




        ///Session1310
        ///ایجاد فیلدها
        //[MaxLength(250)]
        //public string Title { get; set; }




        ///Session1320
        ///ایجاد رابطه
        //public List<BlogCategory> BlogCategories { get; set; }
    }
}