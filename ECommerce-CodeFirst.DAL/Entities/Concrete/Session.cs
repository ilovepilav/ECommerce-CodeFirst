using ECommerce_CodeFirst.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerce_CodeFirst.DAL.Entities.Concrete
{
    public class Session:BaseEntity
    {
        public string Data { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
