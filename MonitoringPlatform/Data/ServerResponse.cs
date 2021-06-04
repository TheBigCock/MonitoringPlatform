using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlatform.Data
{
    [DataContract]
    public class ServerResponse<T>
    {
        [DataMember]
        public int stateCode { set; get; }// 0:ok; 
        [DataMember]
        public String info { set; get; }
        [DataMember]
        public T data { set; get; }
    }
}
