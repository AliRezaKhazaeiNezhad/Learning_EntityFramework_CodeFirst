
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Web.Models
{
    public class Blog
    {
        public Blog()
        {

        }

        [Key]
        public int Id { get; set; }



        ///Session1310
        ///ایجاد فیلدها
        [MaxLength(250)]
        public string Title { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }





        ///Session1320
        ///ایجاد رابطه
        //public int BlogCategoryId { get; set; }
        //public virtual BlogCategory BlogCategory { get; set; }
    }
}