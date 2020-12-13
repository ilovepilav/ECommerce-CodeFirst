using ECommerce_CodeFirst.DAL.Entities.Abstract;
using ECommerce_CodeFirst.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce_CodeFirst.DAL.Entities.Concrete
{
    public class AppUser:BaseEntity
    {
        [Required,MaxLength(255)]
        public string Email { get; set; }
        
        [Required,MaxLength(25), MinLength(6)]
        public string Password { get; set; }
        
        [Required, MaxLength(255)]
        public string FirstName { get; set; }
        
        [Required, MaxLength(255)]
        public string LastName { get; set; }
        
        [Required, MaxLength(255)]
        public string UserName { get; set; }
        
        private Role _userRole = Role.User;

        public Role Role
        {
            get { return _userRole; }
            set { _userRole = value; }
        }

        public int OrderId { get; set; }
        public virtual List<Order> Orders { get; set; }

    }
}
