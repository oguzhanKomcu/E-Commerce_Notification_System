using ECNS.Domainn.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Infrastructure.EntityTypeConfig
{
    public class OrderConfig : BaseEntityConfig<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.Order_Address).IsRequired();


            builder.HasOne(x => x.AppUser)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.User_Id);


            builder.HasOne(x => x.Shipper)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.Shipping_Id);



            base.Configure(builder);
        }
    }
}
