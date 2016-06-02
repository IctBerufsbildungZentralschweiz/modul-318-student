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
        public MailSendForm(ListViewItem selectedItem, string text)
        {
            InitializeComponent();
            
            ErrorExceptions = new List<string>();
            ErrorTargets = new List<object>();

            SelectedListViewItem = selectedItem;
            ListViewName = text;

            //Load Standart Header and Content
            Header = GetHeaderFromSelectedItem();
            Content = GetContentFromSelectedItem();

            //Write Content to View
            textBoxHeader.Text = Header;
            richTextBoxContent.Text = Content;
        }

        public string ListViewName { get; set; }

        public ListViewItem SelectedListViewItem { get; set; }

        public string Header { get; set; }

        public List<string> Recievers { get; set; }

        public string RecieversString { get; set; }

        public string Content { get; set; }

        List<string> ErrorExceptions { get; set; }

        List<object> ErrorTargets { get; set; }

        private void Button_MailSend_Click(object sender, EventArgs e)
        {
            RecieversString = textboxRecievers.Text;
            Header = textBoxHeader.Text;
            Content = richTextBoxContent.Text;

            // Validate Data
            if (Validator())
            {
                // Get Single E-Mail Adresses
                Recievers = GetSplittedRecivers();

                // Create a new Mail Build with the Content, the header and the recivers
                MailBuilder mailbuild = new MailBuilder(Content, Header, Recievers);

                //Create a Mail send and send it
                MailSender mailsender = new MailSender(mailbuild.Message);
                mailsender.Execute();
            }
            else
            {
                //View Validation Errors
                CreateDialogWindow();
            }
        }

        private string GetHeaderFromSelectedItem()
        {
            return "Verbindung von " + SelectedListViewItem.SubItems[0].Text + " Nach " + SelectedListViewItem.SubItems[1].Text;
        }

        private string GetContentFromSelectedItem()
        {
            // unschöner Code
            if (ListViewName == "stationBoardListView")
            {
                return "Informationen zur Verbindung von" + SelectedListViewItem.SubItems[0].Text +
                      " Nach " + SelectedListViewItem.SubItems[0].Text + ".\n\n" +
                      "Diese Verbindung fährt um " + SelectedListViewItem.SubItems[2].Text + " in " +
                      SelectedListViewItem.SubItems[0].Text + " ab.";
            }
            // unschöner Code
            else if(ListViewName == "ConnectionsListView")
            {
                return "Informationen zur Verbindung von" + SelectedListViewItem.SubItems[0].Text +
                      " Nach " + SelectedListViewItem.SubItems[0].Text + ".\n\n" +
                      "Diese Verbindung fährt um " + SelectedListViewItem.SubItems[2].Text + " in " +
                      SelectedListViewItem.SubItems[0].Text + " ab und kommt um " +
                      SelectedListViewItem.SubItems[3].Text + " in " +
                      SelectedListViewItem.SubItems[1].Text + " an";

            }

            return string.Empty;
           
        }

        private List<string> GetSplittedRecivers()
        {
            List<string> returnRecievers = new List<string>();

            //Split string by each ; 
            string[] recievers = RecieversString.Split(';');

            foreach (string reciever in recievers)
            {
                //trim all recivers
                string value = reciever.Trim(new char[] { ' ', ',' });

                if (!string.IsNullOrEmpty(value))
                {
                    returnRecievers.Add(value);
                }
            }

            return returnRecievers;
        }

        private bool Validator()
        {
            //Reset the red Colors
            ResetColor();

            //Clear Exception Lists
            ErrorExceptions.Clear();
            ErrorTargets.Clear();

            if (string.IsNullOrEmpty(textBoxHeader.Text))
            {
                ErrorExceptions.Add("Die Betreff muss einen Wert haben.");
                ErrorTargets.Add(textBoxHeader);
            }
            else if (textBoxHeader.Text.Length > 100)
            {
                ErrorExceptions.Add("Die Betreff darf maximal 100 Zeichen haben.");
                ErrorTargets.Add(textBoxHeader);
            }

            if (string.IsNullOrEmpty(richTextBoxContent.Text))
            {
                ErrorExceptions.Add("Die Text muss einen Wert haben.");
                ErrorTargets.Add(richTextBoxContent);
            }
            else if (richTextBoxContent.Text.Length > 500)
            {
                ErrorExceptions.Add("Die Text darf maximal 500 Zeichen haben.");
                ErrorTargets.Add(richTextBoxContent);
            }

            if (string.IsNullOrEmpty(textboxRecievers.Text))
            {
                ErrorExceptions.Add("Es mussmindestens ein Empfänger angegeben werden.");
                ErrorTargets.Add(textboxRecievers);
            }
            else if (textboxRecievers.Text.Length > 300)
            {
                ErrorExceptions.Add("Der Text für die Eingabe der Empfänger darf nicht mehr als 300 Zeichen haben.");
                ErrorTargets.Add(textboxRecievers);
            }
            else
            {
                //Split string by each ; 
                string[] recievers = RecieversString.Split(';');

                foreach (string reciever in recievers)
                {
                    //Trim all recivers
                    string value = reciever.Trim(new char[] { ' ', ',' });

                    //Check are the E-Mail adresses aviable
                    if (!string.IsNullOrEmpty(value) && (Regex.Match(value, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")).Success == false)
                    {
                        ErrorExceptions.Add("Der Empfänger " + value + " Entspricht nicht den Richtlinien.");
                        ErrorTargets.Add(textboxRecievers);
                    }
                }
            }

            //If any Exceptions
            if (ErrorExceptions.Any())
            {
                //Set the Color red by the Controls
                SetColorRed();
                return false;
            }

            return true;
        }

        private void SetColorRed()
        {
            foreach (object target in ErrorTargets)
            {
                //target == Textbox
                if (target.GetType() == typeof(TextBox))
                {
                    //set color
                    TextBox textbox = (TextBox)target;
                    textbox.BackColor = Color.Red;
                }
                //target == Richtextbox
                else if (target.GetType() == typeof(RichTextBox))
                {
                    //set color
                    RichTextBox richtextbox = (RichTextBox)target;
                    richtextbox.BackColor = Color.Red;
                }
                //target == combobox
                else if (target.GetType() == typeof(ComboBox))
                {
                    //set color
                    ComboBox combobox = (ComboBox)target;
                    combobox.BackColor = Color.Red;
                }
            }
        }

        private void ResetColor()
        {
            foreach(object control in this.Controls)
            {
                //target == Textbox
                if (control.GetType() == typeof(TextBox))
                {
                    //reset color
                    TextBox textbox = (TextBox)control;
                    textbox.BackColor = SystemColors.Window;
                }
                //target == Richtextbox
                else if (control.GetType() == typeof(RichTextBox))
                {
                    //reset color
                    RichTextBox richtextbox = (RichTextBox)control;
                    richtextbox.BackColor = SystemColors.Window;
                }
                //target == Combobox
                else if (control.GetType() == typeof(ComboBox))
                {
                    //reset color
                    ComboBox combobox = (ComboBox)control;
                    combobox.BackColor = SystemColors.Window;
                }
            }
        }

        private void CreateDialogWindow()
        {
            string DialogResultString = string.Empty;

            foreach(string error in ErrorExceptions)
            {
                // Add each Exception to Messagebox
                DialogResultString += error + "\n\n";
            }

            MessageBox.Show(DialogResultString);
        }
    }
}
