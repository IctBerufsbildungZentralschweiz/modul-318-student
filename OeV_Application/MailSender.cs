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
            SmtpClient smtpclient = new SmtpClient("smtp.googlemail.com", 465);

            //Connect with E-Mail and Password
            smtpclient.Credentials = new NetworkCredential("test@googlemail.com", "pw");
            smtpclient.EnableSsl = true;

            //Message.From = new MailAddress("Myadress");

            //smtpclient.Send(Message);

            MessageBox.Show("Mail wurde versendet");
        }
    }
}
