using ECommerce_CodeFirst.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce_CodeFirst.DAL.Entities.Abstract
{
    public class BaseEntity
    {
        public int Id { get; set; }
        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; }
        public DateTime? PassivedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }
    }
}
