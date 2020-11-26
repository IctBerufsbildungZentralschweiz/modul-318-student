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
  public partial class anzeigVerbindung : Form
  {
    public anzeigVerbindung()
    {
      InitializeComponent();
    }
    ITransport transport = new Transport();



    private void btnVerb(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
  }
}
