using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using MonitoringPlatform.Data;
using System.Runtime.Serialization;
using static MonitoringPlatform.Utils.HttpServices;

namespace MonitoringPlatform.Utils
{
    public class HttpInterface
    {
        const string VERSION = "v1/";

        public HttpInterface()
        {

        }

        [DataContract]
        public class MonitoringDataParams
        {
            [DataMember]
            public String taskId { set; get; }
            [DataMember]
            public String userId { set; get; }
            [DataMember]
            public int lastDataIndex { set; get; }
        }

        [DataContract]
        public class TaskParams
        {
            [DataMember]
            public String taskId { set; get; }
            [DataMember]
            public String userId { set; get; }
            [DataMember]
            public String stateCode { set; get; }
            [DataMember]
            public String task { set; get; }
        }

        [DataContract]
        public class UserParams
        {
            [DataMember]
            public String userId { set; get; }
            [DataMember]
            public int userType { set; get; }
            [DataMember]
            public int driverState { set; get; }
            [DataMember]
            public String account { set; get; }
            [DataMember]
            public String password { set; get; }
        }

        [ServiceContract(Name = "HttpServices")]
        public interface IMonitoringPlatform
        {
            [OperationContract]
            [WebInvoke(Method = "POST", UriTemplate = VERSION + "test", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
            HttpServices.Test TaskTest_Post(String p);

            #region User
            [OperationContract]
            [WebInvoke(Method = "POST", UriTemplate = VERSION + "user/info", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
            ServerResponse<User> UserInfo_Post(UserParams p);

            [OperationContract]
            [WebInvoke(Method = "POST", UriTemplate = VERSION + "user/director/list", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
            ServerResponse<List<User>> UserDirectorList_Post(UserParams p);

            [OperationContract]
            [WebInvoke(Method = "POST", UriTemplate = VERSION + "user/login", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
            ServerResponse<User> UserLogin_Post(UserParams p);
            #endregion

            #region Task
            [OperationContract]
            [WebInvoke(Method = "POST", UriTemplate = VERSION + "task/monitoringdata", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
            ServerResponse<DataResponse> MonitoringData_Post(MonitoringDataParams p);

            [OperationContract]
            [WebInvoke(Method = "POST", UriTemplate = VERSION + "task/list", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
            ServerResponse<List<Task>> TaskList_Post(TaskParams p);

            [OperationContract]
            [WebInvoke(Method = "POST", UriTemplate = VERSION + "task/info", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
            ServerResponse<Task> TaskInfo_Post(TaskParams p);

            [OperationContract]
            [WebInvoke(Method = "POST", UriTemplate = VERSION + "task/accept", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
            ServerResponse<Boolean> TaskAccept_Post(TaskParams p);

            [OperationContract]
            [WebInvoke(Method = "POST", UriTemplate = VERSION + "task/add", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
            ServerResponse<String> TaskAdd_Post(TaskParams p);

            [OperationContract]
            [WebInvoke(Method = "POST", UriTemplate = VERSION + "task/detail", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
            ServerResponse<TaskDetail> TaskDetail_Post(TaskParams p);

            [OperationContract]
            [WebInvoke(Method = "POST", UriTemplate = VERSION + "task/update", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
            ServerResponse<Boolean> TaskUpdate_Post(TaskParams p);
            #endregion

            #region Product
            [OperationContract]
            [WebGet(UriTemplate = VERSION + "product/all", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
            ServerResponse<List<ProductCategory>> ProductAll_Get();

            [OperationContract]
            [WebGet(UriTemplate = VERSION + "product/category/{productId}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
            ServerResponse<ProductCategory> ProductCategory_Get(String productId);
            #endregion
        }
    }
}
