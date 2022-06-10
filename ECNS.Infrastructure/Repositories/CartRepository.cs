using ECNS.Domainn.Models.Entities;
using ECNS.Domainn.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Infrastructure.Repositories
{

    public class CartRepository : BaseRepository<Cart>, ICartRepository
    {
        public CartRepository(AppDbContext appDbContext) : base(appDbContext)

        { }
    }
}
