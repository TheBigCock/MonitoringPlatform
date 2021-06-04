using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlatform
{
    [DataContract]
    public class User
    {
        [DataMember]
        public String userId { set; get; }
        [DataMember]
        public String userName { set; get; }
        [DataMember]
        public String nickname { set; get; }
        [DataMember]
        public String photoUrl { set; get; }
        [DataMember]
        public String companyId { set; get; }
        [DataMember]
        public String sex { set; get; }
        [DataMember]
        public String phoneNum { set; get; }
        [DataMember]
        public String idNumber { set; get; }
        [DataMember]
        public String drivingLicenseUrl { set; get; }
        [DataMember]
        public int userType { set; get; }//
        [DataMember]
        public int driverState { set; get; }
        public String password = "";

        public static int USER_TYPE_NORMAL = 0;// 普通用户
        public static int USER_TYPE_DRIVER = 1;// 司机
        public static int USER_TYPE_CONTROLLER = 2;// 管理员

        public static int DRIVER_STATE_STANDBY = 0;// 待机
        public static int DRIVER_STATE_REST = 1;// 休息
        public static int DRIVER_STATE_WORK = 2;// 出勤

        public static Dictionary<int, String> stateString = new Dictionary<int, string> { { 0, "待机中" }, { 1, "休息中" }, { 2, "出勤中" } };
        public static Dictionary<int, String> typeString = new Dictionary<int, string> { { 0, "普通用户" }, { 1, "司机" }, { 2, "管理员" } };

        public User(String userId, String userName, String nickname, String photoUrl, String companyId, String sex, String phoneNum, String idNumber, String drivingLicenseUrl, int userType, int driverState)
        {
            this.userId = userId;
            this.userName = userName;
            this.nickname = nickname;
            this.photoUrl = photoUrl;
            this.companyId = companyId;
            this.sex = sex;
            this.phoneNum = phoneNum;
            this.idNumber = idNumber;
            this.drivingLicenseUrl = drivingLicenseUrl;
            this.userType = userType;
            this.driverState = driverState;
        }
    }
}
