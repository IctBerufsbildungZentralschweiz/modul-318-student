using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OeV_Application
{
    public partial class MailSendForm : Form
    {
        public MailSendForm(ListViewItem selectedItem)
        {
            InitializeComponent();
            SelectedListViewItem = selectedItem;
            Header = GetHeaderFromSelectedItem();
            Content = GetContentFromSelectedItem();

            textBoxHeader.Text = Header;
            richTextBoxContent.Text = Content;

        }

        public ListViewItem SelectedListViewItem { get; set; }

        public string Header { get; set; }

        public List<string> Recievers { get; set; }

        public string RecieversString { get; set; }

        public string Content { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            RecieversString = textboxRecievers.Text;
            Header = textBoxHeader.Text;
            Content = richTextBoxContent.Text;
            Recievers = GetSplittedRecivers();

            MailBuilder mailbuild = new MailBuilder(Content, Header, Recievers);

            MailSender mailsender = new MailSender(mailbuild.Message);
            mailsender.Execute();
        }

        private string GetHeaderFromSelectedItem()
        {
            return "Verbindung von " + SelectedListViewItem.SubItems[0].Text + "Nach " + SelectedListViewItem.SubItems[0].Text;
        }

        private string GetContentFromSelectedItem()
        {
            return "Informationen zur Verbindung von" + SelectedListViewItem.SubItems[0].Text + 
                    " Nach " + SelectedListViewItem.SubItems[0].Text + "\n\n" + 
                    "Diese Verbindung fährt um " + SelectedListViewItem.SubItems[2].Text + " in " +
                    SelectedListViewItem.SubItems[0].Text + " ab und kommt um " + 
                    SelectedListViewItem.SubItems[4].Text + " in " + 
                    SelectedListViewItem.SubItems[1].Text + " an";
        }

        private List<string> GetSplittedRecivers()
        {
            List<string> returnRecievers = new List<string>();

            string[] recievers = RecieversString.Split(';');

            foreach(string reciever in recievers)
            {
                string value = reciever.Trim(new char[] {' ', ','});

                if (!string.IsNullOrEmpty(value) && (Regex.Match(value, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")).Success)
                {
                    returnRecievers.Add(value);
                }
            }

            return returnRecievers;
        }
    }
}
