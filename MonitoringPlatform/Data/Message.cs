using MonitoringPlatform.Data;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlatform
{
    [DataContract]
    public class Message
    {
        [DataMember]
        public String taskId { set; get; }
        [DataMember]
        public int stateCode { set; get; }// 0:完成 1:开始 2:监控中
        [DataMember]
        public String datetime { set; get; }
        [DataMember]
        public List<MonitoringData> datas { set; get; }

        public Message(String taskId, String datetime, int stateCode, List<MonitoringData> datas)
        {
            this.taskId = taskId;
            this.datetime = datetime;
            this.stateCode = stateCode;
            this.datas = datas;
        }

        
    }
}
