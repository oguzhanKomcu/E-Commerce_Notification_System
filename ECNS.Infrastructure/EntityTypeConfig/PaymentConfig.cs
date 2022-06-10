using ECNS.Domainn.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Infrastructure.EntityTypeConfig
{

    public class PaymentConfig : BaseEntityConfig<Payment>
    {
        public override void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.PaymentType).IsRequired();
            base.Configure(builder);
        }
    }




}
