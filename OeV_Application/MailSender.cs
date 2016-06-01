using System.Net.Mail;
using System.Net;
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
            // Create new SmtpConnection to the Server with the Port
            SmtpClient smtpclient = new SmtpClient("mail.gmx.net", 587);

            //Connect with E-Mail and Password
            smtpclient.Credentials = new NetworkCredential("jonas.hodel@gmx.ch", "Gettnau");
            smtpclient.EnableSsl = true;

            Message.From = new MailAddress("jonas.hodel@gmx.ch");

            smtpclient.Send(Message);

            MessageBox.Show("Mail wurde versendet");
        }
    }
}
