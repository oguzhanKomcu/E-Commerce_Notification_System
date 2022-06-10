﻿using ECNS.Domainn.Enums;
using ECNS.Domainn.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Domainn.Models.Entities
{
    public class Category : IBaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }

        public List<Product> Products { get; set; }
    }
}
