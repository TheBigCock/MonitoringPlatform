using MonitoringPlatform.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace MonitoringPlatform.Utils
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple, IncludeExceptionDetailInFaults = true)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class HttpServices : HttpInterface.IMonitoringPlatform
    {
        public HttpServices()
        {

        }

        #region Task
        public class DataResponse
        {
            public int taskState;
            public Boolean ifEnd;
            public List<MonitoringData> datas;
        }

        public ServerResponse<DataResponse> MonitoringData_Post(HttpInterface.MonitoringDataParams p)
        {
            ServerResponse<DataResponse> response = new ServerResponse<DataResponse>();
            if (p.taskId != "" && p.userId != "")
            {
                if (p.lastDataIndex >= -1)
                {
                    Task task = DbOperation.Instance.findTaskById(p.taskId);
                    response.stateCode = StateCode.HttpResponse.OK.CODE;
                    response.info = StateCode.HttpResponse.OK.INFO;
                    DataResponse dataResponse = new DataResponse();
                    List<MonitoringData> datas = task.getDatas();
                    if (p.lastDataIndex + 20 < datas.Count)
                    {
                        dataResponse.ifEnd = false;
                        dataResponse.datas = datas.GetRange(p.lastDataIndex + 1, 20);
                    }
                    else
                    {
                        dataResponse.ifEnd = true;
                        if (p.lastDataIndex + 1 == datas.Count)
                            dataResponse.datas = null;
                        else
                            dataResponse.datas = datas.GetRange(p.lastDataIndex + 1, 20);
                    }
                    dataResponse.taskState = task.taskState;
                    response.data = dataResponse;
                }
                else
                {
                    response.stateCode = StateCode.HttpResponse.OUT_OF_INDEX.CODE;
                    response.info = StateCode.HttpResponse.OUT_OF_INDEX.INFO;
                }

            }
            else
            {
                response.stateCode = 1;
                response.info = "参数错误";
            }
            return response;
        }

        public ServerResponse<TaskDetail> TaskDetail_Post(HttpInterface.TaskParams p)
        {
            ServerResponse<TaskDetail> response = new ServerResponse<TaskDetail>();
            if (p.taskId != null && p.taskId != "")
            {
                TaskDetail taskDetail = new TaskDetail();
                taskDetail.task = DbOperation.Instance.findTaskById(p.taskId);
                if (taskDetail.task != null)
                {
                    taskDetail.driver = taskDetail.task.getDriver();
                    taskDetail.truck = taskDetail.task.getTruck();
                    response.stateCode = StateCode.HttpResponse.OK.CODE;
                    response.info = StateCode.HttpResponse.OK.INFO;
                    response.data = taskDetail;
                }
                else
                {

                }
            }
            return response;
        }

        public ServerResponse<Boolean> TaskUpdate_Post(HttpInterface.TaskParams p)
        {
            ServerResponse<Boolean> response = new ServerResponse<Boolean>();
            Console.WriteLine("task: " + p.task);
            if (p.task != null && p.task != "")
            {
                Task newTask = JsonConvert.DeserializeObject<Task>(p.task);
                DbOperation.Instance.updateTask(newTask, newTask.taskState);
                response.stateCode = StateCode.HttpResponse.OK.CODE;
                response.info = StateCode.HttpResponse.OK.INFO;
                response.data = true;
            }
            return response;
        }

        public ServerResponse<List<Task>> TaskList_Post(HttpInterface.TaskParams p)
        {
            ServerResponse<List<Task>> response = new ServerResponse<List<Task>>();
            if ((p.userId != null && p.userId != "") && (p.stateCode != null && p.stateCode != ""))
            {
                response.stateCode = StateCode.HttpResponse.OK.CODE;
                response.info = StateCode.HttpResponse.OK.INFO;
                response.data = DbOperation.Instance.getTaskListWithStateAndUserId(p.stateCode, p.userId);
            }
            else
            {
                response.stateCode = StateCode.HttpResponse.PARAMS_ERROR.CODE;
                response.info = StateCode.HttpResponse.PARAMS_ERROR.INFO;
            }
            return response;
        }

        public ServerResponse<Task> TaskInfo_Post(HttpInterface.TaskParams p)
        {
            ServerResponse<Task> response = new ServerResponse<Task>();
            if (p.taskId != null && p.taskId != "")
            {
                response.stateCode = StateCode.HttpResponse.OK.CODE;
                response.info = StateCode.HttpResponse.OK.INFO;
                response.data = DbOperation.Instance.findTaskById(p.taskId);
            }
            return response;
        }

        public ServerResponse<bool> TaskAccept_Post(HttpInterface.TaskParams p)
        {
            ServerResponse<bool> response = new ServerResponse<bool>();
            if (p.task != null && p.task != "")
            {
                try
                {
                    Task newTask = JsonConvert.DeserializeObject<Task>(p.task);

                    DbOperation.Instance.updateTask(newTask, Task.TASK_STATE_UNSTARTED);
                    response.stateCode = StateCode.HttpResponse.OK.CODE;
                    response.info = StateCode.HttpResponse.OK.INFO;
                    response.data = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
            }
            return response;
        }

        public ServerResponse<String> TaskAdd_Post(HttpInterface.TaskParams p)
        {
            ServerResponse<String> response = new ServerResponse<String>();
            if (p.task != null && p.task != "")
            {
                try
                {
                    Console.WriteLine("newTask: " + p.task);
                    Task newTask = JsonConvert.DeserializeObject<Task>(p.task);
                    String newTaskId = DbOperation.Instance.insertTask(newTask);
                    if (newTaskId != null)
                    {
                        response.stateCode = StateCode.HttpResponse.OK.CODE;
                        response.info = StateCode.HttpResponse.OK.INFO;
                        response.data = newTaskId;
                        return response;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
            }
            response.stateCode = StateCode.HttpResponse.DATA_STORAGE_FAILURE.CODE;
            response.info = StateCode.HttpResponse.DATA_STORAGE_FAILURE.INFO;
            return response;
        }
        #endregion

        #region User
        public ServerResponse<User> UserInfo_Post(HttpInterface.UserParams p)
        {
            ServerResponse<User> response = new ServerResponse<User>();
            if (p.userId != null)
            {
                if (p.userId != "")
                {
                    response.stateCode = StateCode.HttpResponse.OK.CODE;
                    response.info = StateCode.HttpResponse.OK.INFO;
                    response.data = DbOperation.Instance.findUserById(p.userId);
                }
            }
            return response;
        }

        public ServerResponse<List<User>> UserDirectorList_Post(HttpInterface.UserParams p)
        {
            ServerResponse<List<User>> response = new ServerResponse<List<User>>();
            if (p.driverState >= -1)
            {
                response.stateCode = StateCode.HttpResponse.OK.CODE;
                response.info = StateCode.HttpResponse.OK.INFO;
                response.data = DbOperation.Instance.getDirectorList(p.driverState);
            }
            return response;
        }

        public ServerResponse<User> UserLogin_Post(HttpInterface.UserParams p)
        {
            ServerResponse<User> response = new ServerResponse<User>();
            if (p.account != null && p.password != null)
            {
                if (p.account != "" && p.password != "")
                {
                    response.stateCode = StateCode.HttpResponse.OK.CODE;
                    response.info = StateCode.HttpResponse.OK.INFO;
                    response.data = DbOperation.Instance.findUserByAccount(p.account, p.password);
                }
            }
            return response;
        }
        #endregion

        #region Product
        public ServerResponse<List<ProductCategory>> ProductAll_Get()
        {
            ServerResponse<List<ProductCategory>> response = new ServerResponse<List<ProductCategory>>();
            List<ProductCategory> productCategorys = DbOperation.Instance.getProductCategorytList();
            foreach (ProductCategory productCategory in productCategorys)
            {
                productCategory.getTemperatures();
            }
            response.data = productCategorys;
            response.stateCode = StateCode.HttpResponse.OK.CODE;
            response.info = StateCode.HttpResponse.OK.INFO;
            return response;
        }

        public ServerResponse<ProductCategory> ProductCategory_Get(String productId)
        {
            ServerResponse<ProductCategory> response = new ServerResponse<ProductCategory>();
            response.data = DbOperation.Instance.findProductCategoryById(productId);
            response.stateCode = StateCode.HttpResponse.OK.CODE;
            response.info = StateCode.HttpResponse.OK.INFO;
            return response;
        }


        #endregion

        [DataContract]
        public class Test
        {
            [DataMember]
            public String s { set; get; }
            [DataMember]
            public int num { set; get; }
        }

        public Test TaskTest_Post(String p)
        {
            Test test = new Test();
            test.s = "你好 中国！";
            test.num = 1;
            return test;
        }
    }
}
