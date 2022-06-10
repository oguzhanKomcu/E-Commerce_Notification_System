using ECNS.Domainn.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Application.Notifications
{
    public class UserNotifications : IUserNotifications
    {
        private string _userName;
        public UserNotifications(string userName)
        {
            _userName = userName;
        }
            

        public void Update()
        {
            string fileName = @"D:\Loglar.txt";
            string writeText = $"{_userName}There has been a change in the price of the product.";
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();

            File.AppendAllText(fileName, Environment.NewLine + writeText);
        }
    }
}
