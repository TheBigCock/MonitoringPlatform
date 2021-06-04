using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlatform.Data
{
    [DataContract]
    public class MonitoringData
    {
        [DataMember]
        public String datetime { set; get; }
        [DataMember]
        public Temperature temperature { set; get; }
        [DataMember]
        public List<Coordinate> coordinates { set; get; }
        [DataMember]
        public int temperatureState = 0;

        public delegate void DataDelegate(MonitoringData data, String taskId);

        public MonitoringData(String datetime, Temperature temperature, List<Coordinate> coordinates, int temperatureState)
        {
            this.datetime = datetime;
            this.temperature = temperature;
            this.coordinates = coordinates;
            this.temperatureState = temperatureState;
        }

        public class CoordinateConvertResult
        {
            public int status { set; get; }
            public String info { set; get; }
            public String locations { set; get; }

            public List<Coordinate> getConvertedCoordinate()
            {
                if (locations != null && locations != "")
                {
                    List<Coordinate> coordinates = new List<Coordinate>();
                    string[] xy = locations.Split(new char[2] { ',', ';' });
                    for (int i = 0; i < xy.Length - 1; i += 2)
                    {
                        coordinates.Add(new Coordinate(xy[i], xy[i + 1], ""));
                    }

                    return coordinates;
                }
                return null;
            }
        }

        public bool coordinateConvert(DataDelegate mDataDelegate, String taskId)
        {
            if (coordinates != null && coordinates.Count > 0)
            {

                String coordinatesString = "";
                foreach (Coordinate coordinate in coordinates)
                {
                    double[] coor = coordinate.getCoordinate();
                    if (coor[0] != 0 && coor[1] != 0)
                    {
                        coordinatesString += (coor[0] + "," + coor[1]);
                        coordinatesString += "|";
                    }
                }
                if (coordinatesString == "")
                {
                    DbOperation.Instance.insertDatas(this, taskId);
                    return false;
                }
                else
                    coordinatesString = coordinatesString.Substring(0, coordinatesString.Length - 1);

                var client = new RestClient("https://restapi.amap.com");
                var request = new RestRequest("v3/assistant/coordinate/convert", Method.GET);

                request.AddParameter("key", "285365194ed1dd5f9b8ba4528d5cd2df");
                request.AddParameter("locations", coordinatesString);
                request.AddParameter("coordsys", "gps");

                client.ExecuteAsync(request, response =>
                {
                    CoordinateConvertResult result = JsonConvert.DeserializeObject<CoordinateConvertResult>(response.Content);
                    if (result.status == 1)
                    {
                        this.coordinates = result.getConvertedCoordinate();
                        mDataDelegate(this, taskId);
                    }
                });
                return true;
            }
            else return false;
        }
    }
}
