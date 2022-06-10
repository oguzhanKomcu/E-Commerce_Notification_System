using ECNS.Domainn.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Infrastructure.EntityTypeConfig
{

    public class CartConfig : BaseEntityConfig<Cart>
    {
        public override void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Quantity).IsRequired(true);

            builder.HasOne(x => x.AppUser)
                .WithMany(x => x.Carts)
                .HasForeignKey(x => x.User_Id);
            builder.HasOne(x => x.Product)
               .WithMany(x => x.Carts)
              .HasForeignKey(x => x.Product_Id);

            base.Configure(builder);
        }
    }
}
