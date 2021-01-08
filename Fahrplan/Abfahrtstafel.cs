using SwissTransport.Core;
using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeinFahrplan
{
    public partial class Abfahrtstafel : Form
    {
        AutoCompleteClass autoComplete = new AutoCompleteClass();
        ITransport transport = new Transport();
        
        public Abfahrtstafel()
        {
            InitializeComponent();
            
           
        }

        private void AbtnAbfahrtstafel_Click(object sender, EventArgs e)
        {
            DateTime zeit = DateTime.Now;
            var getStationBoard = transport.GetStationBoard(AcbStart.Text, "1", zeit, 10); 
            
            

            AdgvVerbindungen.Rows.Clear();

            foreach (StationBoard GetStationBoard in getStationBoard.Entries)
            {
                AdgvVerbindungen.Rows.Add(new[] {GetStationBoard.Stop.Departure.ToString() , GetStationBoard.Name.ToString(), getStationBoard.Station.Name.ToString(), GetStationBoard.To, });
            }
        }

        private void AcbStart_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Right && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left)
            {
                autoComplete.getStation((ComboBox)sender);
            }
        }
    }
}
