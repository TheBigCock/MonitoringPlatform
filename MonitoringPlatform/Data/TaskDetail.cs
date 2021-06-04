using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlatform.Data
{
    [DataContract]
    public class TaskDetail
    {
        [DataMember]
        public Task task;
        [DataMember]
        public User driver;
        [DataMember]
        public Truck truck;
    }
}
