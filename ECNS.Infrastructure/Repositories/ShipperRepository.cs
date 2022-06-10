using ECNS.Domainn.Models.Entities;
using ECNS.Domainn.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Infrastructure.Repositories
{


    public class ShipperRepository : BaseRepository<Shipper>, IShipperRepository
    {
        public ShipperRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }

}
