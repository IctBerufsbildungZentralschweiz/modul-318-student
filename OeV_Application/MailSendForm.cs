﻿using System;
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

            ErrorExceptions = new List<string>();
            ErrorTargets = new List<object>();

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

        List<string> ErrorExceptions { get; set; }

        List<object> ErrorTargets { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            RecieversString = textboxRecievers.Text;
            Header = textBoxHeader.Text;
            Content = richTextBoxContent.Text;

            if (Validator())
            {
                Recievers = GetSplittedRecivers();

                MailBuilder mailbuild = new MailBuilder(Content, Header, Recievers);

                MailSender mailsender = new MailSender(mailbuild.Message);
                mailsender.Execute();
            }
            else
            {
                CreateDialogWindow();
            }
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

            foreach (string reciever in recievers)
            {
                string value = reciever.Trim(new char[] { ' ', ',' });

                if (!string.IsNullOrEmpty(value) && (Regex.Match(value, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")).Success)
                {
                    returnRecievers.Add(value);
                }
            }

            return returnRecievers;
        }

        private bool Validator()
        {
            ResetColor();
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
                string[] recievers = RecieversString.Split(';');

                foreach (string reciever in recievers)
                {
                    string value = reciever.Trim(new char[] { ' ', ',' });

                    if (!string.IsNullOrEmpty(value) && (Regex.Match(value, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")).Success == false)
                    {
                        ErrorExceptions.Add("Der Empfänger " + value + " Entspricht nicht den Richtlinien.");
                        ErrorTargets.Add(textboxRecievers);
                    }
                }
            }

            if (ErrorExceptions.Any())
            {
                SetColorRed();
                return false;
            }

            return true;
        }

        private void SetColorRed()
        {
            foreach (object target in ErrorTargets)
            {
                if (target.GetType() == typeof(TextBox))
                {
                    TextBox textbox = (TextBox)target;
                    textbox.BackColor = Color.Red;
                }
                else if (target.GetType() == typeof(RichTextBox))
                {
                    RichTextBox richtextbox = (RichTextBox)target;
                    richtextbox.BackColor = Color.Red;
                }
                else if (target.GetType() == typeof(ComboBox))
                {
                    ComboBox combobox = (ComboBox)target;
                    combobox.BackColor = Color.Red;
                }
            }
        }

        private void ResetColor()
        {
            foreach(object control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox textbox = (TextBox)control;
                    textbox.BackColor = SystemColors.Window;
                }
                else if (control.GetType() == typeof(RichTextBox))
                {
                    RichTextBox richtextbox = (RichTextBox)control;
                    richtextbox.BackColor = SystemColors.Window;
                }
                else if (control.GetType() == typeof(ComboBox))
                {
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
                DialogResultString += error + "\n\n";
            }

            MessageBox.Show(DialogResultString);
        }
    }
}
