using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Windows.Forms;

namespace OeV_Application
{
    public class MailSender
    {
        public MailSender(MailMessage message)
        {
            Message = message;
        }

        public MailMessage Message { get; set; }

        public void Execute()
        {
            SmtpClient smtpclient = new SmtpClient("smtp.googlemail.com", 465);
            smtpclient.Credentials = new NetworkCredential("test@googlemail.com", "pw");
            smtpclient.EnableSsl = true;

            //Message.From = new MailAddress("Myadress");

            //smtpclient.Send(Message);

            MessageBox.Show("Mail wurde versendet");
        }
    }
}
