using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlatform
{
    [DataContract]
    public class Temperature
    {


        [DataMember]
        public double t1 { set; get; }
        [DataMember]
        public double t2 { set; get; }
        [DataMember]
        public double t3 { set; get; }
        [DataMember]
        public double t4 { set; get; }
        [DataMember]
        public double t5 { set; get; }

        public double getMeanTemperature()
        {
            double sum = 0;
            int num = 0;
            List<double> list = new List<double>();
            list.Add(t1);
            list.Add(t2);
            list.Add(t3);
            list.Add(t4);
            list.Add(t5);
            for (int i = 0; i < 5; i++)
            {
                if (jadgeTemperature(list[i]))
                {
                    sum += list[i];
                    num++;
                }
            }
            if (num != 0)
                return Math.Round(sum / num, 3);
            return -100;
        }

        public double getVariance()
        {
            double mean = getMeanTemperature();
            return (Math.Pow(t1 - mean, 2) + Math.Pow(t2 - mean, 2) + Math.Pow(t3 - mean, 2) + Math.Pow(t4 - mean, 2) + Math.Pow(t5 - mean, 2)) / 5;
        }

        private bool jadgeTemperature(double temperature)
        {
            if (temperature != 85 && temperature > -55 && temperature < 125)
                return true;
            else return false;
        }
    }
}
