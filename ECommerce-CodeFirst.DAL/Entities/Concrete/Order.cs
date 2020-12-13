using ECommerce_CodeFirst.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerce_CodeFirst.DAL.Entities.Concrete
{
    public class Order:BaseEntity
    {
        [ForeignKey("Appuser")]
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public List<OrderSale> OrderSales { get; set; }
        [Required, MaxLength(355)]
        public string Address { get; set; }
        [Required,MaxLength(10), MinLength(10)]
        public string PhoneNumber { get; set; }
        [ForeignKey("Transaction")]
        public int TransactionId { get; set; }
        public virtual Transaction Transaction { get; set; }
        [ForeignKey("Coupon")]
        public int CouponId { get; set; }
        public virtual Coupon Coupon { get; set; }
        [ForeignKey("Session")]
        public int SessionId { get; set; }
        public virtual Session Session { get; set; }

    }
}
