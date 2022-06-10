using ECNS.Domainn.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Infrastructure.EntityTypeConfig
{


    public class ShipperConfig : BaseEntityConfig<Shipper>
    {
        public override void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CompanyName).IsRequired();
            builder.Property(x => x.Phone).IsRequired();
            base.Configure(builder);
        }
    }



}
