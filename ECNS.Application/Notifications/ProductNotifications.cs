using ECNS.Application.Service.CartService;
using ECNS.Domainn.Models.Entities;
using ECNS.Domainn.UoW;
using ECNS.Infrastructure.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Application.Notifications
{
    public class ProductNotifications
    {
        private readonly Product _product;
        private List<IUserNotifications> _users;



        public ProductNotifications()
        {


            _users = new List<IUserNotifications>();
   


        }


        private bool _productPrice;
        public bool ProductPrice
        {
            get
            {
                return _productPrice;
            }
            set
            {
                if (value == true )
                {
                    Notify();
                    _productPrice = value;
                }

            }
        }

        private void Notify()
        {
            foreach (var user in _users)
            {
                user.Update();
            }
        }

        public void Subscribe(IUserNotifications userNotifications)
        {

            _users.Add(userNotifications);
    

        }
    }
}
