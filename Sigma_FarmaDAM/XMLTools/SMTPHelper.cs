using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLTools
{
    class SMTPHelper
    {
        try
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("el meu_mail@gmail.com");
            mail.To.Add("to_address");
            mail.Subject = "Test Mail - 1";
            mail.Body = "mail amb adjunt";
            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment("C:\\arxiu.pdf");
            mail.Attachments.Add(attachment);
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
            MessageBox.Show("Mail enviat!!!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
