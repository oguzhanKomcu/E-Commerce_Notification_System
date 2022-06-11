using ECNS.Application.Model.VMs;
using ECNS.Domainn.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Application.Model.DTOs
{
    public class UpdateProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? ImagePath { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }


        public DateTime UpdateDate => DateTime.Now;
        public Status Status => Status.Modified;

        public int CategoryId { get; set; }

     

    }
}
