using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Text.RegularExpressions;
namespace OeV_Application
{
    public class MailBuilder
    {

        public MailBuilder(string connectionText, string connectionHeader, List<string> recievers)
        {
            Message = new MailMessage();
            UpdateText(connectionText);
            UpdateHeader(connectionHeader);

            foreach(string reciever in recievers)
            {
                AddReciever(reciever);
            }
        }

        public MailMessage Message { get; set; }

        private void UpdateText(string body)
        {
            Message.Body = body;
        }

        private void UpdateHeader(string header)
        {
            Message.Subject = header;
        }

        private void AddReciever(string mailadress)
        {
            Message.To.Add(new MailAddress(mailadress));
        }
    }
}
