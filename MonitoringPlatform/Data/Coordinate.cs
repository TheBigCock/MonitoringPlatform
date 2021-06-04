using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlatform
{
    [DataContract]
    public class Coordinate
    {
        [DataMember]
        public String x { set; get; }
        [DataMember]
        public String y { set; get; }
        [DataMember]
        public String description { set; get; }

        public Coordinate(String x, String y, String description)
        {
            this.x = x;
            this.y = y;
            this.description = description;
        }


        public Double[] getCoordinate()
        {
            Double[] coordinate = { 0.0, 0.0 };
            if (x != null && y != null && x != "" && y != "")
            {
                coordinate[0] = Math.Round(Convert.ToDouble(x), 6);
                coordinate[1] = Math.Round(Convert.ToDouble(y), 6);
            }
            return coordinate;
        }
    }
}
