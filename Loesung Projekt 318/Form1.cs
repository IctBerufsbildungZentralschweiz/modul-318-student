using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loesung_Projekt_318
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}

		private void OnClickVerbindungSuchen(object sender, EventArgs e)
		{
			SwissTransport.Station VonStation = new SwissTransport.Station();
			SwissTransport.Station NachStation = new SwissTransport.Station();
			SwissTransport.Connection Verbindung = new SwissTransport.Connection();

			VonStation.Name = txtVon.Text;
			NachStation.Name = txtNach.Text;
			
		}
	}
}
