using ECommerce_CodeFirst.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce_CodeFirst.DAL.Entities.Concrete
{
    public class Transaction:BaseEntity
    {
        [Required, MaxLength(255)]
        public string Code { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        [Required]
        public string Processor { get; set; }
        [Required, MaxLength(255)]
        public string ProcessorTransId { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [MaxLength(255)]
        public string CcNum { get; set; }
        [MaxLength(255)]
        public string CcType { get; set; }
        public string Response { get; set; }

    }
}
