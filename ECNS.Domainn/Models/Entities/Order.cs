using ECNS.Domainn.Enums;
using ECNS.Domainn.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Domainn.Models.Entities
{
    public class Order : IBaseEntity
    {
        public int Id { get; set; }
        public string User_Id { get; set; }
        public AppUser AppUser { get; set; }
        public int Amount { get; set; }
        public int Payment_ID { get; set; }
        
        public int Shipping_Id { get; set; }
        public Shipper Shipper { get; set; }
        public string Order_Address { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }
        public List<Order_Detail> Order_Details { get; set; }
    }
}
