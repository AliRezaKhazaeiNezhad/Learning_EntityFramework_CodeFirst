
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Web.Models
{
    public class Product
    {
        public Product()
        {

        }

        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Title { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }


        public virtual List<ProductCategory> ProductCategories { get; set; }
    }
}