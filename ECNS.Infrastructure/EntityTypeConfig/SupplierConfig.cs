using ECNS.Domainn.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Infrastructure.EntityTypeConfig
{


    public class SupplierConfig : BaseEntityConfig<Supplier>
    {
        public override void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CompanyName).IsRequired();
            builder.Property(x => x.ContactFirstName).IsRequired();
            builder.Property(x => x.ContactLastName).IsRequired();
            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.Phone).IsRequired();
            builder.Property(x => x.Email).IsRequired();


            base.Configure(builder);
        }
    }


}
