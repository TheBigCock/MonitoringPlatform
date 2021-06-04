using MonitoringPlatform.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlatform
{
    [DataContract]
    public class Task
    {
        private double minProductTemperature = -100;
        private double maxProductTemperature = 100;
        private int alarmNum = 0;

        [DataMember]
        public String taskId { set; get; }// 任务ID
        [DataMember]
        public String publisherId { set; get; }// 任务发布者ID
        [DataMember]
        public String accepterId { set; get; }// 任务接收者ID
        [DataMember]
        public String driverId { set; get; }// 运输车辆ID
        [DataMember]
        public String truckId { set; get; }// 运输车辆ID
        [DataMember]
        public String terminalId { set; get; }// 终端ID
        [DataMember]
        public Coordinate startPlace { set; get; }// 任务起始地
        [DataMember]
        public Coordinate endPlace { set; get; }// 任务结束地
        [DataMember]
        public String startDatetime { set; get; }// 任务起始时间
        [DataMember]
        public String endDatetime { set; get; }// 任务结束时间
        [DataMember]
        public Product product { set; get; }// 运输产品
        [DataMember]
        public int taskState { set; get; }// 任务状态
        [DataMember]
        public List<TemperatureAlarm> temperatureAlarms { set; get; }//温度警报

        private List<MonitoringData> datas; // 实时数据

        private TemperatureAlarm solvingTemperatureAlarm;

        private User driver;
        private User publisher;
        private User accepter;
        private Truck truck;

        public User getDriver()
        {
            if (driver == null && driverId != null && driverId != "")
                this.driver = DbOperation.Instance.findUserById(driverId);
            return driver;
        }

        public User getPublisher()
        {
            if (publisher == null && publisherId != null && publisherId != "")
                this.publisher = DbOperation.Instance.findUserById(publisherId);
            return publisher;
        }

        public User getAccepter()
        {
            if (accepter == null && accepterId != null && accepterId != "")
                this.accepter = DbOperation.Instance.findUserById(accepterId);
            return accepter;
        }

        public Truck getTruck()
        {
            if (this.truck == null && truckId != null && truckId != "")
                this.truck = DbOperation.Instance.findTruckById(truckId);
            return this.truck;
        }

        public List<MonitoringData> getDatas()
        {
            if (taskId != null && taskId != "")
            {
                String datetime = getDatasLastDatetime();
                if (datetime == null || datetime == "")
                    return DbOperation.Instance.getMonitoringDatasByTaskId(taskId);
                List<MonitoringData> newDatas = DbOperation.Instance.getMonitoringDatasAfterDatetime(taskId, datetime);
                if (newDatas != null && newDatas.Count > 0)
                    datas.AddRange(newDatas);
                return datas;
            }
            return new List<MonitoringData>();
        }

        public void setDatas(List<MonitoringData> datas)
        {
            this.datas = datas;
        }

        public int getDatasCount()
        {
            if (taskId != null && taskId != "")
            {
                if (taskState == TASK_STATE_TRANSPORT)
                    return DbOperation.Instance.getMonitoringDatasCount(taskId);
                else
                    return datas.Count;
            }
            return 0;
        }

        public String getDatasLastDatetime()
        {
            if (datas != null && datas.Count > 0)
            {
                return datas[datas.Count - 1].datetime;
            }
            return null;
        }

        public const int TASK_STATE_COMPELET = 0;// 完成
        public const int TASK_STATE_TRANSPORT = 1;// 进行中
        public const int TASK_STATE_UNACCEPTED = 2;// 未接受
        public const int TASK_STATE_UNSTARTED = 3;// 未开始      

        [DataContract]
        public class TemperatureAlarm
        {
            public static int TOLERANCE_TIMES_SERIES = 3;//允许出现的连续温度异常次数   
            public static int TOLERANCE_TIMES = 5;//允许出现的累计温度异常次数
            public static int NORMAL_TIMES_SERIES = 6;//温度回归正常时连续出现正常温度的次数
            public static double VARIANCE_ERROR = 0.3;//温度方差允许的误差值
            public enum ErrorType { NodeError, ContinuousError, AccumulativeError };// 节点错误、温度连续异常、温度累计异常
            public enum State { Resolved, Unsolved, Undetermined };
            public State state = State.Undetermined;
            public int normalTemperatureSeries = 0;
            public int lastErrorTemperatureIndex = 0;
            public int errorTemperatureSeries = 0;

            [DataMember]
            public ErrorType errorType { set; get; }
            [DataMember]
            public List<int> errorTemperatureIndex { set; get; }
            [DataMember]
            public String alarmMessage { set; get; }
            [DataMember]
            public String nodeErrorList { set; get; }//多个节点以','分隔

            public TemperatureAlarm()
            {
                this.errorTemperatureIndex = new List<int>();
            }
        }

        public Task(String taskId, String publisherId, Coordinate startPlace, Coordinate endPlace, Product product)
        {
            this.publisherId = publisherId;
            this.startPlace = startPlace;
            this.endPlace = endPlace;
            this.product = product;
            this.taskId = taskId;
            this.taskState = TASK_STATE_UNACCEPTED;
            this.temperatureAlarms = new List<TemperatureAlarm>();
        }

        public TemperatureAlarm getTemperatureAlarm()
        {
            return this.solvingTemperatureAlarm;
        }

        public void judgeTemperatureError(KeyValuePair<int, Temperature> temperature)
        {
            double meanTemperature = temperature.Value.getMeanTemperature();
            if (minProductTemperature == -100 || maxProductTemperature == 100)
            {
                Double[] range = this.product.getProductCategory().getTemperature(this.product.temperatureId).getTemperatureRange();
                minProductTemperature = range[0];
                maxProductTemperature = range[1];
            }

            if (meanTemperature < minProductTemperature || meanTemperature > maxProductTemperature)
            {
                if (this.solvingTemperatureAlarm == null)
                    this.solvingTemperatureAlarm = new TemperatureAlarm();

                solvingTemperatureAlarm.normalTemperatureSeries = 0;
                solvingTemperatureAlarm.errorTemperatureIndex.Add(temperature.Key);

                if (temperature.Key - solvingTemperatureAlarm.lastErrorTemperatureIndex == 1)
                    solvingTemperatureAlarm.errorTemperatureSeries++;
                else solvingTemperatureAlarm.errorTemperatureSeries = 0;

                solvingTemperatureAlarm.lastErrorTemperatureIndex = temperature.Key;
                if (solvingTemperatureAlarm.state == TemperatureAlarm.State.Undetermined)
                {
                    Console.WriteLine("erroTseries:" + solvingTemperatureAlarm.errorTemperatureSeries);
                    if (solvingTemperatureAlarm.errorTemperatureSeries > TemperatureAlarm.TOLERANCE_TIMES_SERIES)
                    {
                        solvingTemperatureAlarm.state = TemperatureAlarm.State.Unsolved;
                        solvingTemperatureAlarm.errorType = TemperatureAlarm.ErrorType.ContinuousError;
                        solvingTemperatureAlarm.alarmMessage = "车内温度连续超出产品适宜温度范围，请及时处理！";
                    }
                    else if (solvingTemperatureAlarm.errorTemperatureIndex.Count > TemperatureAlarm.TOLERANCE_TIMES)
                    {
                        solvingTemperatureAlarm.state = TemperatureAlarm.State.Unsolved;
                        solvingTemperatureAlarm.errorType = TemperatureAlarm.ErrorType.AccumulativeError;
                        solvingTemperatureAlarm.alarmMessage = "车内温度多次超出产品适宜温度范围，请及时处理！";
                    }
                }
                if (temperatureAlarms.Count == alarmNum)
                    this.temperatureAlarms.Add(solvingTemperatureAlarm);
                else this.temperatureAlarms[alarmNum] = solvingTemperatureAlarm;
            }
            else
            {
                solvingTemperatureAlarm.normalTemperatureSeries++;
                if (solvingTemperatureAlarm.state == TemperatureAlarm.State.Unsolved &&
                    solvingTemperatureAlarm.normalTemperatureSeries > TemperatureAlarm.NORMAL_TIMES_SERIES)
                {
                    solveLastTemperatureAlarm();
                }
            }
        }

        public void solveLastTemperatureAlarm()
        {
            solvingTemperatureAlarm.state = TemperatureAlarm.State.Resolved;
            alarmNum++;
            solvingTemperatureAlarm = null;

        }
    }
}

