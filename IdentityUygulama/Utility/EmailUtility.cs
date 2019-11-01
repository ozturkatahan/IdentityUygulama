using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace IdentityUygulama.Utility
{
    public static class EmailUtility
    {
        public static async Task Send(string to, string subject, string body)
        {
            //https://www.mikesdotnetting.com/article/268/how-to-send-email-in-asp-net-mvc
            var message = new MailMessage();
            message.To.Add(new MailAddress(to));  // replace with valid value 
            message.From = new MailAddress("kendinolmakendogali@gmail.com");  // replace with valid value
            message.Subject = "Your email subject";
            message.Body = body;
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "kendinolmakendogali@gmail.com",  // replace with valid value
                    Password = "iskur555"  // replace with valid value
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                await smtp.SendMailAsync(message);

            }
        }

        //Bu metot email ayarlarını web.config üzerinden alır
        public static async Task Send2Async(string to, string subject, string body)
        {
            var message = new MailMessage();
            message.To.Add(new MailAddress(to)); //replace with valid value
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = true;

            //usingte Dispose() otmatik gelir, bu işe yarar (burada smtp için Dispose() methodunu çağırır)
            using (var smtp = new SmtpClient())
            {
                await smtp.SendMailAsync(message);              
            }

        }
    }
}

