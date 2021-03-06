using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Application.Model.VMs
{
    public class GetProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public string? ImagePath { get; set; }
        public string Size { get; set; }
        public int Stock { get; set; }
    }
}
