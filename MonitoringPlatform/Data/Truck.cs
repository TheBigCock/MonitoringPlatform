using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlatform
{
    [DataContract]
    public class Truck
    {
        [DataMember]
        public String truckId { set; get; }// 车辆ID
        [DataMember]
        public String companyId { set; get; }// 公司ID
        [DataMember]
        public String terminalId { set; get; }// 终端ID
        [DataMember]
        public String plateNumber { set; get; }// 车牌号
        [DataMember]
        public String model { set; get; }// 车型
        [DataMember]
        public String load { set; get; }// 载重
        [DataMember]
        public String registrationCertificateUrl { set; get; }// 车辆注册证
        [DataMember]
        public int stateCode { set; get; }// 车辆状态

        public static int STATE_CODE_STANDBY = 0;//待机
        public static int STATE_CODE_TRANSPORT = 1;//运输
        public static int STATE_CODE_OVERHAUL = 2;//检修

        public static String[] stateString = { "待机中", "运输中", "检修中" };

        public Truck(String truckId, String companyId, String terminalId, String plateNumber, String model, String load, String registrationCertificateUrl)
        {
            this.truckId = truckId;
            this.companyId = companyId;
            this.terminalId = terminalId;
            this.plateNumber = plateNumber;
            this.model = model;
            this.load = load;
            this.registrationCertificateUrl = registrationCertificateUrl;
            this.stateCode = 0;
        }
    }

}
