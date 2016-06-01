using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System;
using System.Windows.Forms;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        public Stations GetStations(string query, string exceptionstring)
        {
            try
            {
                var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    var message = new StreamReader(responseStream).ReadToEnd();
                    var stations = JsonConvert.DeserializeObject<Stations>(message);
                    return stations;
                }

                return null;
            }
            catch
            {
                MessageBox.Show(exceptionstring);
                return null;
            }

        }

        public Stations GetStationsByAdresse(string adresse, string exceptionstring)
        {
            try
            {
                var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?type=" + adresse);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    var message = new StreamReader(responseStream).ReadToEnd();
                    var stations = JsonConvert.DeserializeObject<Stations>(message);
                    return stations;
                }

                return null;
            }
            catch
            {
                MessageBox.Show(exceptionstring);
                return null;
            }
        }   

        public StationBoardRoot GetStationBoard(string station, string exceptionstring, string id)
        {
            try
            {


                var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?Station=" + station + "&id=" + id);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    var readToEnd = new StreamReader(responseStream).ReadToEnd();
                    var stationboard =
                        JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                    return stationboard;
                }

                return null;
            }
            catch
            {
                MessageBox.Show(exceptionstring);
                return null;
            }
}

        public StationBoardRoot GetStationBoardWithSpecificTime(string station, DateTime date, string exceptionstring)
        {
            try
            {
                Stations stations = GetStations(station,exceptionstring);
                string id = stations != null ? stations.StationList.First().Id : string.Empty;

                var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?Station=" + station + "&id=" + id + "&datetime=" + date.ToString("yyyy-MM-dd hh:mm"));
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    var readToEnd = new StreamReader(responseStream).ReadToEnd();
                    var stationboard =
                        JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                    return stationboard;
                }

                return null;
            }
            catch
            {
                MessageBox.Show(exceptionstring);
                return null;
            }
        }

        public Connections GetConnections(string fromStation, string toStattion, string exceptionstring)
        {
            try
            {


                var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStattion);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    var readToEnd = new StreamReader(responseStream).ReadToEnd();
                    var connections =
                        JsonConvert.DeserializeObject<Connections>(readToEnd);
                    return connections;
                }

                return null;
            }
            catch
            {
                MessageBox.Show(exceptionstring);
                return null;
            }
        }

        public Connections GetConnectionsSpecificTime(string fromStation, string toStation, DateTime date, string exceptionstring, bool IsArrivalTime = false)
        {
            try
            {


                var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStation +
                "&date=" + date.ToString("yyyy-MM-dd") +
                "&time=" + date.ToString("HH:mm") +
                "&isArrivalTime=" + (IsArrivalTime ? "1" : "0"));

                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    var readToEnd = new StreamReader(responseStream).ReadToEnd();
                    var connections =
                        JsonConvert.DeserializeObject<Connections>(readToEnd);
                    return connections;
                }

                return null;
            }
            catch
            {
                MessageBox.Show(exceptionstring);
                return null;
            }
        }

        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;
            
            return request;
        }
    }
}
