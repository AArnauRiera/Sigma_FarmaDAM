using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace XMLTools
{
    public class SMTPHelper
    {
        /// <summary>
        /// Envia un mail
        /// </summary>
        public static void SendEmail()
        {
            try
            {
                //Nos logeamos
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("SigmaFarmaDAM@gmail.com");
                mail.To.Add("SigmaFarmaDAM@gmail.com");
                mail.Subject = "Comanda enviada correctamente";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("SigmaFarmaDAM", "Dam123456");
                SmtpServer.EnableSsl = true;
                //Enviamos el mail
                SmtpServer.Send(mail);
                MessageBox.Show("Mail enviado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }
    }
}
