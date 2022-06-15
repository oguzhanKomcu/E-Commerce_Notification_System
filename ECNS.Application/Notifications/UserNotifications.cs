using ECNS.Domainn.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ECNS.Application.Notifications
{
    public class UserNotifications : IUserNotifications
    {
        private string _userName;
        private decimal _propductPrice;
        private string _email;
        
        public UserNotifications(string userName, decimal propductPrice, string email)
        {
            _userName = userName;
            _propductPrice = propductPrice;
            _email = email;
        }

            

        public void Update()
        {
            string fileName = @"D:\Loglar.txt";
            string writeText = $"Sayın {_userName}  sepetinizde bulunan ürünün fiyatı {_propductPrice} TL  olarak değişmiştir..";
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();

            File.AppendAllText(fileName, Environment.NewLine + writeText);
            EmailNotification();
        }


        public void EmailNotification()
        {


            string writeText = $"Sayın {_userName}  sepetinizde bulunan ürünün fiyatı {_propductPrice} TL  olarak değişmiştir..";
            SmtpClient smtpClient = new SmtpClient();
            MailMessage mail = new MailMessage();
            smtpClient.Credentials = new NetworkCredential("denemeoguzhan@outlook.com", "***password**");
            smtpClient.Port = 587;
            smtpClient.Host = "smtp-mail.outlook.com";
            smtpClient.EnableSsl = true;
            mail.To.Add(_email); 
            mail.From = new MailAddress("denemeoguzhan@outlook.com"); 
            mail.Subject = $"DATE : {DateTime.Now}  The price of the product in your cart has changed! "; 
            mail.Body = $"Bildirim : {writeText}" + System.Environment.MachineName.ToString();

            smtpClient.SendAsync(mail, (object)mail);
        }


    }
}
