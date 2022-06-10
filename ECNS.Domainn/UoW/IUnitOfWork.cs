using ECNS.Domainn.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Domainn.UoW
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IAppUserRepository UserRepository { get; }
        IProductRepository ProductRepository { get; }
        IOrderRepository OrderRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IOrderDetailRepository OrderDetailRepository { get; }
        ICartRepository CartRepository { get; }

        IShipperRepository ShipperRepository { get; }
        ISupplierRepository SupplierRepository { get; }
        IPaymentRepository PaymentRepository { get; }

        Task Commit();

    }
}
