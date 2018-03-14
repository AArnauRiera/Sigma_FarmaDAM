using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLTools
{
    public class SMTPHelper
    {
        public void SendEmail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("SigmaFarmaDAM@gmail.com");
                mail.To.Add("SigmaFarmaDAM@gmail.com");
                mail.Subject = "Comanda enviada correctament";
                mail.Body = "mail amb adjunt";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("SigmaFarmaDAM", "Dam123456");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                MessageBox.Show("Mail enviat!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }
    }
}
