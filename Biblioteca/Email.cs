using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Email
    {
        public void SendEmail(string email, string subject, string body)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("alan.gabrile.mengassini@gmail.com", "ingenieroalan7532$");
            smtpClient.EnableSsl = true;

            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("alan.gabrile.mengassini@gmail.com");
            correo.To.Add(new MailAddress(email));
            correo.Subject = subject;
            correo.Body = body;

            try
            {
                smtpClient.Send(correo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
