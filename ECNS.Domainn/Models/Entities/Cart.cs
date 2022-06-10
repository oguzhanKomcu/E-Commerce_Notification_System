using ECNS.Domainn.Enums;
using ECNS.Domainn.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Domainn.Models.Entities
{
    public  class Cart : IBaseEntity
    {
        public int Id { get; set; }
        public string User_Id { get; set; }
        public AppUser AppUser { get; set; }
        public int Product_Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }


        

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }



    }
}
