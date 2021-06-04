using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlatform
{
    [DataContract]
    public class ProductTemperature
    {
        public int id;
        public int state;
        [DataMember]
        public String instruction { set; get; }// 存储说明
        [DataMember]
        public String duration { set; get; }// 存储时间
        [DataMember]
        public String temperature { set; get; }// 最佳温度

        public ProductTemperature(int id, String instruction, String duration, String temperatureString, int state)
        {
            this.id = id;
            this.instruction = instruction;
            this.duration = duration;
            this.temperature = temperatureString;
            this.state = state;
        }

        public double[] getTemperature(String temperatureString)
        {
            double[] temperatures = new double[2];
            String[] temperature = temperatureString.Split('~');
            temperatures[0] = Convert.ToDouble(temperature[0]);
            temperatures[1] = Convert.ToDouble(temperature[1]);
            return temperatures;
        }

        public double[] getTemperatureRange()
        {
            if (this.temperature != null && this.temperature != "")
                return this.getTemperature(temperature);
            else return null;
        }
    }

}
