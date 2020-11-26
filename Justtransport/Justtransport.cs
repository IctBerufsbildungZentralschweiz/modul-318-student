using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace Justtransport
{
  public partial class Justtransport : Form
  {
    public Justtransport()
    {
      InitializeComponent();

    }
    ITransport transport = new Transport();
    


    private void BtnVerbindung2(object sender, EventArgs e)
    {
      //Variablen definieren
      //Startort eingabe
      string startort = txtStartort.Text;
      //Endort eingabe
      string endort = txtEndort.Text;
      //Datum eingabe
      DateTime date = dpDate.Value;
      //Zeit eingabe
      DateTime time = dpTime.Value;
      //Ankunft oder Abfahrt eingabe
      bool abfahrt = rbAbfahrt.Checked;
      bool ankunft = rbAnkunft.Checked;
      //Button anklicken und damit Verbindungen öffnen
      anzeigVerbindung aV = new anzeigVerbindung();
      aV.Show();
    }

    private void BtnVerbindung(object sender, EventArgs e)
    {
      //Variablen definieren
      //Startort eingabe
      string startort = txtStartort.Text;
      //Endort eingabe
      string endort = txtEndort.Text;
      //Datum eingabe
      DateTime date = dpDate.Value;
      //Zeit eingabe
      DateTime time = dpTime.Value;
      //Ankunft oder Abfahrt eingabe
      bool abfahrt = rbAbfahrt.Checked;
      bool ankunft = rbAnkunft.Checked;
      //Button anklicken und damit Verbindungen öffnen
      anzeigVerbindung aV = new anzeigVerbindung();
      aV.Show();
    }

    private void txtclear(object sender, EventArgs e)
    {
      txtStartort.Text = "";
    }

    private void txtclear2(object sender, EventArgs e)
    {
      txtEndort.Text = "";
    }
  }
}
