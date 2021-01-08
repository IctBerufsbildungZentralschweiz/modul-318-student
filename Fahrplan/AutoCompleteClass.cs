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
    class AutoCompleteClass
    {
        ITransport transport = new Transport();
        Connection connection = new Connection();
        public List<string> autoComplete(string input)
        {

            List<string> autoCompleteList = new List<string>();

            var stations = transport.GetStations(input);
            foreach (var station in stations.StationList)
            {

                autoCompleteList.Add(station.Name);
            }

            if (autoCompleteList.Count == 0)
            {
                autoCompleteList.Add("Kein Resultat");
            }

            return autoCompleteList;
        }
        public void getStation(ComboBox box)
        {
            if (box.Text != "")
            {
                try
                {
                    string userInput = box.Text;
                    box.Items.Clear();
                    box.SelectionStart = box.Text.Length + 1;

                    List<string> stations = autoComplete(userInput);

                    foreach (String station in stations)
                    {
                        if (station != null)
                        {
                            box.Items.Add(station);
                        }
                    }
                    if (box.Text.Length >= 2)
                    {
                        box.DroppedDown = true;
                        box.Text = userInput;
                        box.SelectionStart = box.Text.Length + 1;
                    }

                }
                catch
                {
                    box.Items.Clear();
                    box.SelectionStart = box.Text.Length + 1;
                    box.Items.Add("Kein Resultat");
                }
            }
        }
    }
}
