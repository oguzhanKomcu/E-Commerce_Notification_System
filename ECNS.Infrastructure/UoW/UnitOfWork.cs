using ECNS.Domainn.Repositories;
using ECNS.Domainn.UoW;
using ECNS.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Infrastructure.UoW
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext db)
        {
            _appDbContext = db ?? throw new ArgumentNullException($"{nameof(db)} can't be a null");
        }

        private IAppUserRepository _appUserRepository;
        public IAppUserRepository UserRepository
        {
            get
            {
                if (_appUserRepository == null)
                {
                    _appUserRepository = new AppUserRepository(_appDbContext);
                }
                return _appUserRepository;
            }
        }

        private ICartRepository _cartRepository;
        public ICartRepository CartRepository
        {
            get
            {
                if (_cartRepository == null)
                {
                    _cartRepository = new CartRepository(_appDbContext);
                }
                return _cartRepository;
            }
        }



        private IProductRepository _productRepository;
        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(_appDbContext);
                }
                return _productRepository;
            }
        }


        private ICategoryRepository _categoryRepository;
        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                {
                    _categoryRepository = new CategoryRepository(_appDbContext);
                }
                return _categoryRepository;
            }
        }

       private IOrderRepository _orderRepository;
        public IOrderRepository OrderRepository
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new OrderRepository(_appDbContext);
                }
                return _orderRepository;
            }

        }


        private IOrderDetailRepository _orderDetailRepository;
        public IOrderDetailRepository OrderDetailRepository
        {
            get
            {
                if (_orderDetailRepository == null)
                {
                    _orderDetailRepository = new OrderDetailRepository(_appDbContext);
                }
                return _orderDetailRepository;
            }
        }


        private IPaymentRepository _paymentRepository;
        public IPaymentRepository PaymentRepository
        {
            get
            {
                if (_paymentRepository == null)
                {
                    _paymentRepository = new PaymentRepository(_appDbContext);
                }
                return _paymentRepository;
            }
        }
        private IShipperRepository _shipperRepository;
        public IShipperRepository ShipperRepository
        {
            get
            {
                if (_shipperRepository == null)
                {
                    _shipperRepository = new ShipperRepository(_appDbContext);
                }
                return _shipperRepository;
            }
        }

        private ISupplierRepository _supplierRepository;
        public ISupplierRepository SupplierRepository
        {
            get
            {
                if (_supplierRepository == null)
                {
                    _supplierRepository = new SupplierRepository(_appDbContext);
                }
                return _supplierRepository;
            }
        }

        public async Task Commit()
        {
            try
            {
                await _appDbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private bool _isDisposed = false;
        public async ValueTask DisposeAsync()
        {
            if (!_isDisposed)
            {
                _isDisposed = true;
                await DisposeAsync(true);
                GC.SuppressFinalize(this);
            }
        }
        private async Task DisposeAsync(bool disposing)
        {
            if (disposing)
            {
                await _appDbContext.DisposeAsync();
            }
        }


    }
}
