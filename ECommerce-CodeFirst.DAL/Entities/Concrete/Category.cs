using ECommerce_CodeFirst.DAL.Entities.Abstract;
using ECommerce_CodeFirst.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce_CodeFirst.DAL.Entities
{
    public class Category:BaseEntity
    {
        [Required,MaxLength(255)]
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category ParentCategory { get; set; } = null!;
        public virtual List<Product> Products { get; set; }

    }
}
