using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Fahrplan
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }

        //globale Variablen
        string[] list;
        string message;

        //Ereignisse
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtAbsender_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }
        private void txtEmpfänger_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }
        private void txtBetreff_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }
        private void txtNachricht_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }

        //Funktionen
        public void openMail(string[] value)
        {
            list = value;
            this.Show();
        }
        public void checkInput()
        {
            if (txtEmpfänger.Text != "")
            {
                btnSend.Enabled = true;
                btnSend.BackColor = Color.FromArgb(0, 0, 100);
            }
            else
            {
                btnSend.Enabled = false;
                btnSend.BackColor = Color.FromArgb(224, 224, 224);
            }
        }
        public void sendMail()
        {
            
            foreach(string line in list)
            {
                message += line + "%0A";
            }
            message = txtNachricht.Text + "%0A...................%0A%0A" + message;

            System.Diagnostics.Process.Start(
                "mailto:" + txtEmpfänger.Text +
                "?subject=" + txtBetreff.Text +
                "&body=" + message);

            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sendMail();
        }
    }
}
