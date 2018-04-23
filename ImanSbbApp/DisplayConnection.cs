using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImanSbbApp
{
    class DisplayConnection
    {
        private string arrival;
        private string departure;
        private string date;
        private string time;
        private string platform;

        public string Arrival
        {
            get
            {
                return arrival;
            }
            set
            {
                arrival = String.Format("{0:HH:mm:ss}", value);               
            }

        }

        public string Departure
        { 
            get
            {
                return departure; 
            }
            set
            {
                departure = value; 
            }
        }

        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public string Time
        {
            get
            {                
                return String.Format("{0:dd.MM.yyyy HH:mm:ss}", time);
            }
            set
            {
                time = value;
            }
        }


        public string Platform
        {
            get
            {
                return platform;
            }
            set
            {
                platform = value;
            }
        }

        public DisplayConnection(string Arrival, string Departure, string Time, string Platform)
        {
            arrival = Arrival;
            departure = Departure;
            time = Time;
            platform = Platform;
        }
    }
}
