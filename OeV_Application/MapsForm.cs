using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.ObjectModel;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.MapProviders;

namespace OeV_Application
{
    public partial class MapsForm : Form
    {
        public MapsForm()
        { 

        }

        public MapsForm(List<Station> stations)
        {
            InitializeComponent();

            //Create the Control
            GMapControl mapcontrol = new GMapControl();
            mapcontrol.Size = new Size(1000, 1000);
            mapcontrol.MapProvider = GMapProviders.OpenStreetMap;
            mapcontrol.MinZoom = 0;
            mapcontrol.MaxZoom = 24;
            mapcontrol.Zoom = 9;
            this.Controls.Add(mapcontrol);

            //Add the Stations to the map
            foreach(Station station in stations)
            {
                mapcontrol.Position = new PointLatLng(station.Coordinate.XCoordinate, station.Coordinate.YCoordinate);
            }
        }
    }
}
