using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImanSbbApp
{
    class DisplayBoard
    {
        private string name;
        private string departure;
        private string to;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
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
        public string To
        {
            get
            {
                return to;
            }
            set
            {
                to = value;
            }
        }

        public DisplayBoard(string Name, string To, string Departure)
        {
            name = Name;
            to = To;
            departure = Departure;
        }
    }

}
