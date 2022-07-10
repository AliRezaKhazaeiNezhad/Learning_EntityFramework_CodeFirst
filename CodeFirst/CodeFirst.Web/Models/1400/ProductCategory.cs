
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Web.Models
{
    public class ProductCategory
    {
        public ProductCategory()
        {

        }

        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }


        public List<Product> Products { get; set; }
    }
}