﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Application.Model.VMs
{
    public class UserCartVM
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public int Product_Id { get; set; }
        public int Quantity { get; set; }
        
    }
}
