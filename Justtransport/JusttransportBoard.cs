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
  public partial class JusttransportBoard : Form
  {
    public JusttransportBoard()
    {
      InitializeComponent();
      dpTime.Text = DateTime.Now.ToString("HH:mm");
    }

    ITransport transport = new Transport();
  

    public String outputConnectionFromTo { get; set; }

    private void btnCard(object sender, EventArgs e)
    {
      MessageBox.Show("Diese Funktion ist noch nicht verfügbar");
      
    }

    private void btnOutputShow(object sender, EventArgs e)
    {
      try
      {
        var connections = transport.GetConnections(txtStart.Text, txtEnd.Text, 10);
        if (connections.ConnectionList.Count != 0)
        {//clear List
          listConnection.Items.Clear();

          //fill List
          foreach (Connection connection in connections.ConnectionList)
          {
            DateTime departureTime = DateTime.Parse(connection.From.Departure);
            DateTime arrivalTime = DateTime.Parse(connection.To.Arrival);
            TimeSpan duration = TimeSpan.Parse(connection.Duration.Replace("d", ":"));

            outputConnectionFromTo = "Von " + connection.From.Station.Name + " | Bis " + connection.To.Station.Name + " | \tAbfahrt: " + departureTime.ToString("HH:mm") + " | Ankunft: " + arrivalTime.ToString("HH:mm") + " | \tDauer: " + duration.ToString(@"hh\:mm") + " | \tGleis: " + connection.From.Platform;
            listConnection.Items.Add(outputConnectionFromTo);
          }
        }
      }
      catch
      {
        MessageBox.Show("Sie haben einen ungültigen wert eingegeben.");
      }
    }


    private void txtClearStart(object sender, EventArgs e)
    {
      txtStart.Text = "";
    }

    private void txtClearEnd(object sender, EventArgs e)
    {
      txtEnd.Text = "";
    }

    private void pressEnter(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        MessageBox.Show("Bitte klicken Sie mit der Maus auf den Button");
      }

    }
  }

}
