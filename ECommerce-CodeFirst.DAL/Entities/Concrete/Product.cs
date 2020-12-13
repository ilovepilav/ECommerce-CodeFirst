using ECommerce_CodeFirst.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce_CodeFirst.DAL.Entities.Concrete
{
    public class Product:BaseEntity
    {
        [Required,MaxLength(255)]
        public string Sku { get; set; }
        [Required,MaxLength(255)]
        public string ProductName { get; set; }
        [MaxLength(655)]
        public string Description { get; set; }
        private decimal _discountRate = 1.0m;

        public decimal DiscountRate
        {
            get { return _discountRate; }
            set { _discountRate = value; }
        }

        private decimal _price;

        [Required]
        public decimal Price
        {
            get { return _price*DiscountRate; }
            set { _price = value; }
        }
        private int _unitsInStock = 0;

        public int UnitsInStok
        {
            get { return _unitsInStock; }
            set { _unitsInStock = value; }
        }

        private bool _taxable = false;

        public bool Taxable
        {
            get { return _taxable; }
            set { _taxable = value; }
        }
        public virtual List<Category> Categories { get; set; }
        public virtual List<Tag> Tags { get; set; }
    }
}
