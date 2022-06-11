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
    public class CreateProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }

        public int Stock { get; set; }
        public int Category_Id { get; set; }


        public DateTime CreateDate => DateTime.Now;
        public Status Status => Status.Active;

        public List<GetCategoryVM>? Categories { get; set; }
    }
}
