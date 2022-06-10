using ECNS.Domainn.Models.Entities;
using ECNS.Domainn.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Infrastructure.Repositories
{
   
    
    public class OrderDetailRepository : BaseRepository<Order_Detail>, IOrderDetailRepository
    {
        public OrderDetailRepository(AppDbContext appDbContext) : base(appDbContext)

        { }
    }

}
