using ECNS.Domainn.Enums;
using ECNS.Domainn.Models.Interface;

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Domainn.Models.Entities
{
    public class AppUser : IdentityUser, IBaseEntity
    {
        public string ImagePath { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        [NotMapped]
        public string Token { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }
        public List<Order> Orders { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
