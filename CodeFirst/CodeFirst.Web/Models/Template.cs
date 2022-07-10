
using System;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Web.Models
{
    public class Template
    {
        public Template()
        {

        }

        //[Key]
        //public int Id { get; set; }






        ///Lesson1200
        ///افزودن خصوصیات بیشتر به جداول

        //[Key]
        //public int Id { get; set; }
        //public string Title { get; set; }
        //public bool State { get; set; }
        //public DateTime CreateDateTime { get; set; }
        //public int Count { get; set; }
        //public decimal Price { get; set; }









        ///Lesson1210
        ///افزودن خصوصیات بیشتر به ستون های جداول


        //[Key]
        //public int Id { get; set; }

        ///The nvarchar takes 2GB size for each data
        //[MaxLength(250)]
        //public string Title { get; set; }
        //public bool State { get; set; }
        //public DateTime CreateDateTime { get; set; }
        //public int Count { get; set; }
        //public decimal Price { get; set; }








        ///Lesson1211
        ///افزودن خصوصیات بیشتر به ستون های جداول

        //[Key]
        //public int Id { get; set; }
        //[MaxLength(250)]
        //[Required]
        //public string Title { get; set; }
        //public bool State { get; set; }
        //public DateTime CreateDateTime { get; set; }
        //public int Count { get; set; }
        //public decimal Price { get; set; }







        ///Lesson1212
        ///افزودن خصوصیات بیشتر به ستون های جداول

        //[Key]
        //public int Id { get; set; }
        //[MaxLength(250)]
        //[Required(ErrorMessage = "را وارد نمایید")]
        //public string Title { get; set; }
        //public bool State { get; set; }
        //public DateTime CreateDateTime { get; set; }
        //public int Count { get; set; }
        //public decimal Price { get; set; }







        ///Lesson1213
        ///افزودن خصوصیات بیشتر به ستون های جداول
        ///ایجاد فیلد الونال

        //[Key]
        //public int Id { get; set; }

        //[MaxLength(250)]
        //[Required(ErrorMessage = "را وارد نمایید")]
        //public string Title { get; set; }
        //public bool? State { get; set; }
        //public DateTime? CreateDateTime { get; set; }
        //public int? Count { get; set; }
        //public decimal? Price { get; set; }








        ///Lesson1214
        ///افزودن خصوصیات بیشتر به ستون های جداول که در اچ تی ام ال مشاهده میشود
        ///نمایش در اچ تی ام ال

        //[Key]
        //public int Id { get; set; }

        //[MaxLength(250)]
        //[Required(ErrorMessage = "را وارد نمایید")]
        //[Display(Name = "عنوان")]
        //public string Title { get; set; }
        //public bool? State { get; set; }
        //public DateTime? CreateDateTime { get; set; }
        //public int? Count { get; set; }
        //public decimal? Price { get; set; }










        ///Lesson1215
        ///Best Practise

        //[Key]
        //public int Id { get; set; }

        //[Display(Name = "عنوان")]
        //[Required(ErrorMessage = "{0} را وارد نمایید")]
        //[MaxLength(250, ErrorMessage = "{0} باید حداکثر 250 کاراکتر باشد")]
        //public string Title { get; set; }
        //public bool? State { get; set; }
        //public DateTime? CreateDateTime { get; set; }
        //public int? Count { get; set; }
        //public decimal? Price { get; set; }
    }
}