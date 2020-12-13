using ECommerce_CodeFirst.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce_CodeFirst.DAL.Entities.Concrete
{
    public class OrderSale :BaseEntity
    {
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public short Quantity { get; set; }
    }
}
