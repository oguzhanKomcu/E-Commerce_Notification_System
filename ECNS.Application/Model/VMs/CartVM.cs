using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Application.Model.VMs
{
    public class CartVM
    {
        public string User_Id { get; set; }
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public int Product_Quantity { get; set; }
        public decimal Product_Price { get; set; }
        public decimal Total_Amount{ get; set; }
    }
}
