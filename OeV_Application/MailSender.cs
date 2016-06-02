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
            HostPort = 587;
            MailHost = "mail.gmx.net";
            Password = "Password2016";
            Email = "oev.application@gmx.ch";
        }

        public MailMessage Message { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string MailHost { get; set; }

        public int HostPort { get; set; }

        public void Execute()
        {
            // Create new SmtpConnection to the Server with the Port
            SmtpClient smtpclient = new SmtpClient(MailHost, HostPort);

            //Connect with E-Mail and Password
            smtpclient.Credentials = new NetworkCredential(Email, Password);
            smtpclient.EnableSsl = true;

            Message.From = new MailAddress(Email);

            smtpclient.Send(Message);

            MessageBox.Show("Mail wurde versendet");
        }
    }
}
