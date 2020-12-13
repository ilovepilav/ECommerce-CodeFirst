using ECommerce_CodeFirst.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce_CodeFirst.DAL.Entities.Concrete
{
    public class Tag:BaseEntity
    {
        [Required, MaxLength(255)]
        public string Name { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
