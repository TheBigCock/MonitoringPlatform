using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static MonitoringPlatform.TcpServer;
using System.Windows.Forms.DataVisualization.Charting;
using MonitoringPlatform.Utils;
using System.ServiceModel.Web;
using RestSharp;
using MonitoringPlatform.Data;
using System.Runtime.Serialization;
using System.Linq;

namespace MonitoringPlatform
{

    public partial class MainForm : Form
    {
        const int INFORMATION_INTERVAL = 5;//终端数据的时间间隔（分）
        const int TEMPERATURE_MAXNUM = 8;//温度变化图显示的最小温度数

        private static int historyTemperatureMax = TEMPERATURE_MAXNUM;
        private static TcpServer server;
        private static HttpServerHelper httpServerHelper;
        private String displayingTaskId = "";
        private ProductCategory displayingCategory = null;
        private int displayingHistoryIndex = -1;
        private Dictionary<String, Task> taskList = new Dictionary<String, Task>();
        private Dictionary<String, String> remoteEndPoint = new Dictionary<String, String>();
        private Form startForm;
        private Boolean isFirstTask = true;

        List<Socket> socketList = new List<Socket>();
        List<Task> historyList = new List<Task>();
        DbOperation dbOperation;

        //TCP服务器IP及端口
        private String ipString = "172.18.18.35"; //"127.0.0.1"
        private int listenPort = 8086;

        #region 初始化

        public MainForm(Form startForm)
        {
            InitializeComponent();
            this.startForm = startForm;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //高德地图设置
            try
            {
                String uri = Application.StartupPath + "\\AMap.html";
                mainMapWeb.Url = new Uri(uri);
                historyMapWeb.Url = new Uri(uri);
                webBrowserMainAll.Url = new Uri(uri);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //TCP服务器设置
            server = new TcpServer(IPAddress.Parse(ipString), listenPort);
            server.Encoding = Encoding.UTF8;
            server.ClientConnected +=
              new EventHandler<TcpClientConnectedEventArgs>(server_ClientConnected);
            server.ClientDisconnected +=
              new EventHandler<TcpClientDisconnectedEventArgs>(server_ClientDisconnected);
            server.PlaintextReceived +=
              new EventHandler<TcpDatagramReceivedEventArgs<string>>(server_PlaintextReceived);
            server.Start();
            //HTTP服务器设置
            try
            {
                httpServerHelper = new HttpServerHelper();
                httpServerHelper.Start();
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("请以管理员身份运行本软件！", "", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }

            //数据库操作类
            dbOperation = DbOperation.Instance;
            dbOperation.dbConnection(Application.StartupPath + "\\Database.accdb");

            showTransportTaskList();
            panelMainTask.Visible = false;

            //HTTP测试
            //var client = new RestClient("http://172.18.18.35:8080");
            //var request = new RestRequest("v1/task/monitoringdata", Method.POST);

            //String s = "{\"userId\":\"3\",\"taskId\":\"0010\",\"lastDataIndex\":\"-1\"}";
            //request.AddJsonBody(s);

            //client.ExecuteAsync(request, response =>
            //{
            //    Console.WriteLine("response:" + response.Content);
            //});
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //dbOperation.dbConnectionClose();
            if (remoteEndPoint.Count != 0)
            {
                DialogResult dr = MessageBox.Show("还有" + remoteEndPoint.Count + "个运输任务正在进行，退出将无法继续监控且造成数据记录异常，仍然要退出吗？", "提示", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    e.Cancel = false;
                    startForm.Close();
                }
                else e.Cancel = true;
            }
            else
            {
                DialogResult dr = MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    e.Cancel = false;
                    startForm.Close();
                }
                else e.Cancel = true;
            }
        }

        #endregion

        #region 其他

        int findTaskIndexById(String taskId)
        {
            int i = 0;
            for (; i < mainTaskList.RowCount; i++)
            {
                Object value = mainTaskList.Rows[i].Cells["taskId"].Value;
                if (value != null && value.ToString() == taskId)
                    return i;
            }
            return -1;
        }

        #endregion


        #region 任务界面

        private void taskDataView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                initInformation();
                changeDisplayingTask(mainTaskList.Rows[e.RowIndex].Cells["taskId"].Value.ToString());
            }
        }

        private void changeDisplayingTask(String taskId)
        {
            panelMainTask.Visible = true;
            panelMainAll.Visible = false;
            mainTaskInfoMapTip.Visible = false;
            Task task = taskList[taskId];
            if (task != null)
            {
                Truck truck = task.getTruck();
                User driver = task.getDriver();
                ProductCategory productCategory = DbOperation.Instance.findProductCategoryById(task.product.id);
                this.displayingTaskId = taskId;
                this.displayingCategory = productCategory;
                mainTaskInfoTruckPlateNum.Text = "车牌号：" + truck.plateNumber;
                mainTaskInfoTruckLoad.Text = "载重：" + truck.load;
                mainTaskInfoTruckModel.Text = "车型：" + truck.model;
                directorNameLabel.Text = "负责人姓名：" + driver.userName;
                mainTaskInfoTruckPhoneNum.Text = "负责人电话：" + driver.phoneNum;
                mainTaskInfoProductName.Text = "产品名：" + productCategory.name;
                mainTaskInfoProductTemp.Text = "适宜运输温度：" + productCategory.getTemperature(task.product.temperatureId).temperature + " ℃";
                mainTaskInfoProductNum.Text = "数量：" + task.product.quantity + " " + task.product.unit;
                mainTaskInfoProductDate.Text = "生产日期：\n" + DatetimeUtil.Instance.formatDateTime(task.product.dateOfProduction);
                mainTaskInfoProductPlace.Text = "产地：" + task.product.placeOfProduction.description;
                mainTaskInfoProductStartDate.Text = "运输开始时间：\n" + DatetimeUtil.Instance.formatDateTime(task.startDatetime);
                if (task.getTemperatureAlarm() != null)
                {
                    mainTaskInfoAlarmTips.Text = task.getTemperatureAlarm().alarmMessage;
                    mainTaskInfoAlarmTips.ForeColor = Color.Red;
                    temperatureAlert.Show();
                }
                else
                {
                    mainTaskInfoAlarmTips.Text = "车内温度正常";
                    mainTaskInfoAlarmTips.ForeColor = Color.Black;
                    temperatureAlert.Hide();
                }
                mainMapWeb.Document.InvokeScript("initTransportRoute");
                if (task.getDatas() != null && task.getDatas().Count > 0)
                {
                    List<Coordinate> points = new List<Coordinate>();
                    foreach (MonitoringData data in task.getDatas())
                    {
                        points.AddRange(data.coordinates);
                    }
                    mainMapWeb.Document.InvokeScript("drawTransportRoute", new object[] { JsonConvert.SerializeObject(points), "wgh", false });
                    drawChart(task, productCategory);

                    //webBrowserMainAll.Document.InvokeScript("updateMarker", new object[] { points[2000].x, points[2000].y, taskList[taskId].getTruck().plateNumber, "address", taskList[taskId].taskId });
                    //mainTaskList.Rows[findTaskIndexById(displayingTaskId)].DefaultCellStyle.BackColor = Color.Red;
                    //mainTaskInfoAlarmTips.Text = "车内温度连续超出产品适宜温度范围，请及时处理！";
                    //mainTaskInfoAlarmTips.ForeColor = Color.Red;
                    //temperatureAlert.Show();
                }
            }
        }

        void initInformation()
        {
            mainTemperatureChart.Series[0].Points.Clear();
            mainTaskInfoTruckPlateNum.Text = "车牌号：";
            directorNameLabel.Text = "负责人姓名：";
            mainTaskInfoTruckPhoneNum.Text = "负责人电话：";
            mainTaskInfoProductName.Text = "产品名：";
            mainTaskInfoProductTemp.Text = "适宜运输温度：";
            mainTaskInfoProductStartDate.Text = "运输开始时间：";
            temperatureLabel.Text = "当前车内温度：";
            mainTaskInfoAlarmTips.Text = "";
        }

        void showTransportTaskList()
        {
            //initTransportTaskTableColumns();
            List<Task> tasks = dbOperation.getTaskListWithState(Task.TASK_STATE_TRANSPORT);
            foreach (Task task in tasks)
            {
                addTransportTask(task);
            }
        }

        void addTransportTask(Task task)
        {
            taskList.Add(task.taskId, task);
            int index = mainTaskList.Rows.Add();
            mainTaskList.Rows[index].Cells[0].Value = task.getTruck().plateNumber;
            mainTaskList.Rows[index].Cells[1].Value = task.product.getProductCategory().name;
            mainTaskList.Rows[index].Cells[2].Value = task.startDatetime;
            mainTaskList.Rows[index].Cells[3].Value = task.taskId;
        }

        void removeTransportTask(String taskId)
        {
            taskList.Remove(taskId);
            int index = findTaskIndexById(taskId);
            if (index != -1)
                mainTaskList.Rows.RemoveAt(index);
        }

        void initTransportTaskTableColumns()
        {
            DataTable taskTable = new DataTable();
            taskTable.Columns.Add("车牌号");
            taskTable.Columns.Add("产品名");
            taskTable.Columns.Add("开始时间");
            taskTable.Columns.Add("任务Id");
            mainTaskList.DataSource = taskTable;
            mainTaskList.Columns[3].Visible = false;
        }

        void drawChart(Task task, ProductCategory productCategory)
        {
            mainTemperatureChart.Series[0].Points.Clear();
            foreach (MonitoringData data in task.getDatas())
            {
                DateTime dateTime = Convert.ToDateTime(data.datetime);
                mainTemperatureChart.Series[0].Points.AddXY(dateTime.ToString("HH:mm"), data.temperature.getMeanTemperature());
                DataPoint dataPoint = mainTemperatureChart.Series[0].Points[mainTemperatureChart.Series[0].Points.Count - 1];
                Double[] temperature = productCategory.getTemperature(task.product.temperatureId).getTemperatureRange();
                if (temperature != null)
                    if (dataPoint.YValues[0] > temperature[1] || dataPoint.YValues[0] < temperature[0])
                    {
                        dataPoint.Color = Color.Red;
                        dataPoint.LabelForeColor = Color.Red;
                    }
            }
            double position = mainTemperatureChart.ChartAreas[0].AxisX.Maximum - mainTemperatureChart.ChartAreas[0].AxisX.ScaleView.Size;
            mainTemperatureChart.ChartAreas[0].AxisX.ScaleView.Position = position > 0 ? position : 0;
        }

        void addPoint(DateTime X, Double Y)
        {
            mainTemperatureChart.Series[0].Points.AddXY(X.ToString("HH:mm"), Y);
            DataPoint dataPoint = mainTemperatureChart.Series[0].Points[mainTemperatureChart.Series[0].Points.Count - 1];
            if (displayingCategory != null)
            {
                Double[] temperature = displayingCategory.getTemperature(taskList[displayingTaskId].product.temperatureId).getTemperatureRange();
                if (temperature != null)
                    if (dataPoint.YValues[0] > temperature[1] || dataPoint.YValues[0] < temperature[0])
                    {
                        dataPoint.Color = Color.Red;
                        dataPoint.LabelForeColor = Color.Red;
                    }
            }
            double position = mainTemperatureChart.ChartAreas[0].AxisX.Maximum - mainTemperatureChart.ChartAreas[0].AxisX.ScaleView.Size;
            if (mainTemperatureChart.ChartAreas[0].AxisX.ScaleView.Position == position - 1)
            {

                mainTemperatureChart.ChartAreas[0].AxisX.ScaleView.Position = position;
            }
        }

        #endregion

        #region 服务器

        void server_ClientConnected(object sender, TcpClientConnectedEventArgs e)
        {

        }

        void server_ClientDisconnected(object sender, TcpClientDisconnectedEventArgs e)
        {
            try
            {
                //String taskId = remoteEndPoint[e.TcpClient.Client.RemoteEndPoint.ToString()];
                //mainTaskList.Invoke(new Action(() =>
                //{
                //    mainTaskList.Rows.RemoveAt(findTaskIndexById(taskId));
                //    initInformation();
                //    if (taskId == displayingTaskId)
                //        MessageBox.Show("该运输任务已结束", "提示", MessageBoxButtons.OK);
                //    webBrowserMainAll.Document.InvokeScript("deleteMaker", new object[] { taskList[taskId].truckId });
                //}));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        void coordinateConverted(MonitoringData data, String taskId)
        {
            dbOperation.insertDatas(data, taskId);
            webBrowserMainAll.Invoke(new Action(() =>
            {
                Coordinate currentPoint = data.coordinates[data.coordinates.Count - 1];
                webBrowserMainAll.Document.InvokeScript("updateMarker", new object[] { currentPoint.x, currentPoint.y, taskList[taskId].getTruck().plateNumber, "address", taskList[taskId].taskId });
                if (taskId == displayingTaskId)
                {
                    mainMapWeb.Document.InvokeScript("drawTransportRoute", new object[] { JsonConvert.SerializeObject(data.coordinates), taskList[taskId].getTruck().plateNumber, false });
                }
            }));
        }


        String dataBuff = "";
        int cachingTimes = 0;
        void dataAnalysis(String dataString, String endPoint)
        {
            try
            {
                if (dataString.Split('"')[3] == "2000/00/00 08:00:00") return;

                if (dataString[0] != '{' || dataString[dataString.Length - 1] != '}')
                {
                    dataBuff += dataString;
                    if (cachingTimes == 1)
                    {
                        if (dataBuff[0] == '{' && dataBuff[dataBuff.Length - 1] == '}')
                            dataAnalysis(dataBuff, endPoint);
                        cachingTimes = 0;
                        return;
                    }
                    cachingTimes++;
                    return;
                }

                dataBuff = "";
                cachingTimes = 0;
                Message message = JsonConvert.DeserializeObject<Message>(dataString);

                Task task = dbOperation.findTaskById(message.taskId);
                if (task != null)
                {
                    try
                    {
                        switch (message.stateCode)
                        {
                            case 0://任务完成
                                remoteEndPoint.Remove(endPoint);
                                if (task.taskState == Task.TASK_STATE_TRANSPORT)
                                {
                                    task.endDatetime = message.datetime;
                                    task.taskState = Task.TASK_STATE_COMPELET;
                                    task.temperatureAlarms = taskList[task.taskId].temperatureAlarms;
                                    dbOperation.updateTask(task, Task.TASK_STATE_COMPELET);

                                    panelMain.Invoke(new Action(() =>
                                    {
                                        webBrowserMainAll.Document.InvokeScript("deleteMarker", new object[] { task.taskId });
                                        removeTransportTask(task.taskId);
                                        if (task.taskId == displayingTaskId)
                                        {
                                            MessageBox.Show("该运输任务已结束", "提示", MessageBoxButtons.OK);
                                            panelMainTask.Visible = false;
                                            panelMainAll.Visible = true;
                                        }
                                    }));
                                }
                                break;
                            case 1://任务开始
                                remoteEndPoint.Add(endPoint, task.taskId);
                                if (task.taskState == Task.TASK_STATE_UNSTARTED)
                                {
                                    task.startDatetime = message.datetime;
                                    task.taskState = Task.TASK_STATE_TRANSPORT;
                                    dbOperation.updateTask(task, Task.TASK_STATE_TRANSPORT);

                                    panelMain.Invoke(new Action(() =>
                                    {
                                        addTransportTask(task);
                                    }));
                                }
                                break;
                            case 2://监控中
                                if (message.datas != null)
                                {
                                    //message.translateData();
                                    panelMain.Invoke(new Action(() =>
                                    {
                                        int index = findTaskIndexById(task.taskId);
                                        if (index != -1)
                                        {
                                            foreach (MonitoringData data in message.datas)
                                            {
                                                double temperature = data.temperature.getMeanTemperature();
                                                if (temperature > -55 && temperature < 125)
                                                {
                                                    if (data.coordinateConvert(coordinateConverted, task.taskId))
                                                        mainTaskInfoMapTip.Visible = false;
                                                    else
                                                    {
                                                        mainTaskInfoMapTip.Visible = true;
                                                        mainTaskInfoMapTip.Text = "GPS数据接收中，受环境影响或GPS模块损坏可能导致无法正常显示车辆定位";
                                                    }
                                                    taskList[task.taskId].judgeTemperatureError(new KeyValuePair<int, Temperature>(taskList[task.taskId].getDatasCount(), data.temperature));
                                                    if (task.taskId == displayingTaskId)
                                                    {
                                                        addTemperatureData(data);
                                                    }
                                                    else if (taskList[task.taskId].getTemperatureAlarm() != null && taskList[task.taskId].getTemperatureAlarm().state == Task.TemperatureAlarm.State.Unsolved)
                                                    {
                                                        mainTaskList.Rows[index].DefaultCellStyle.BackColor = Color.Red;
                                                    }
                                                    else
                                                        mainTaskList.Rows[index].DefaultCellStyle.BackColor = Color.White;
                                                }
                                            }
                                        }
                                    }));
                                }
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());
                    }
                }
                else
                {
                    if (MessageBox.Show("找不到ID为" + message.taskId + "的任务!", "数据接收错误", MessageBoxButtons.OK) == DialogResult.OK)
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("异常:" + dataString);
            }
        }

        void server_PlaintextReceived(object sender, TcpDatagramReceivedEventArgs<string> e)
        {
            if (e.Datagram != "Received" && e.Datagram != "a")
            {
                dataAnalysis(e.Datagram, e.TcpClient.Client.RemoteEndPoint.ToString());
            }
        }

        List<System.Timers.Timer> timers = new List<System.Timers.Timer>();
        private void AtaskTimer(int i)
        {
            socketList.Add(AsyncConnect());
            timers.Add(new System.Timers.Timer(INFORMATION_INTERVAL * 1000));
            int time = 0;
            double beginPointX = 106.553141;
            double beginPointY = 29.55642;
            timers[timers.Count - 1].Elapsed += new System.Timers.ElapsedEventHandler((s, e) => AtaskSimulation(s, e, i, time += 1, beginPointX += 0.01, beginPointY));
            timers[timers.Count - 1].AutoReset = true;
            timers[timers.Count - 1].Enabled = true;
        }

        private bool isTempChange = false;

        private void temperatureChange_Click(object sender, EventArgs e)
        {
            isTempChange = !isTempChange;
        }

        private void AtaskSimulation(object source, System.Timers.ElapsedEventArgs e, int i, int time, double x, double y)
        {
            if (time == 1)
            {
                String taskString = String.Format("{{\"datetime\":\"{0} \"," +
                    "\"taskId\":\"0010\"," +
                    "\"statecode\":\"{1} \"}}",
                    DateTime.Now.AddMinutes(time).ToString("yyyy/MM/dd HH:mm"), 1);
                AsyncSend(socketList[i], taskString);
            }
            else
            {
                Random random = new Random();
                double t = 9 + i * 2 + random.NextDouble();
                if (isTempChange)
                    t += 2;
                String temp = t.ToString("f2");
                String taskString = String.Format("{{\"datetime\":\"{0} \"," +
                    "\"taskId\":\"0010\"," +
                    "\"statecode\":\"{1} \"," +
                    "\"datas\":[{{\"coordinates\":[{{\"x\":\"{2} \",\"y\":\"{3} \"}},{{\"x\":\"{9} \",\"y\":\"{10} \"}}]," +
                    "\"temperature\":{{\"t1\":\"{4} \",\"t2\":\"{5} \",\"t3\":\"{6} \",\"t4\":\"{7} \",\"t5\":\"{8} \"}}" +
                    ",\"datetime\":\"{0}\"}}]}}",
                    DateTime.Now.AddMinutes(time).ToString("yyyy/MM/dd HH:mm"), 2, x, y, temp, temp, temp, temp, temp, x + 0.0005, y);
                AsyncSend(socketList[i], taskString);
            }
        }

        /// <summary>
        /// 连接到服务器
        /// </summary>
        public Socket AsyncConnect()
        {
            try
            {
                //端口及IP
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("172.18.18.35"), 8086);
                //创建套接字
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //开始连接到服务器
                client.BeginConnect(ipe, asyncResult =>
                {
                    client.EndConnect(asyncResult);
                }, null);
                return client;
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="socket"></param>
        /// <param name="message"></param>
        public void AsyncSend(Socket socket, string message)
        {
            if (socket == null || message == string.Empty) return;
            //编码
            byte[] data = Encoding.UTF8.GetBytes(message);
            try
            {

                socket.BeginSend(data, 0, data.Length, SocketFlags.None, asyncResult =>
                {
                    //完成发送消息
                    int length = socket.EndSend(asyncResult);
                }, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        #endregion

        #region 历史界面

        void showHistoryList()
        {
            historyList = dbOperation.getTaskListWithState(Task.TASK_STATE_COMPELET);
            if (historyList.Count != historyTaskList.RowCount)
            {
                initHistoryTableColumns();
                if (historyList.Count > 0)
                    foreach (Task task in historyList)
                    {
                        addHistoryTask(task);
                    }
            }
        }

        private void historySearchButton_Click(object sender, EventArgs e)
        {
            String key = historySearchTextBox.Text.ToString();
            historyList = dbOperation.searchTasks(key, Task.TASK_STATE_COMPELET);
            if (historyList.Count != historyTaskList.RowCount)
            {
                initHistoryTableColumns();
                if (historyList.Count > 0)
                    foreach (Task task in historyList)
                    {
                        addHistoryTask(task);
                    }
            }
        }

        void initHistoryTableColumns()
        {
            DataTable taskTable = new DataTable();
            taskTable.Columns.Add("车牌号");
            taskTable.Columns.Add("产品名");
            taskTable.Columns.Add("结束时间");
            taskTable.Columns.Add("任务ID");
            historyTaskList.DataSource = taskTable;
            historyTaskList.Columns[3].Visible = false;
        }

        void addHistoryTask(Task task)
        {
            if (historyTaskList.DataSource == null)
                initHistoryTableColumns();
            DataTable taskTable = (DataTable)historyTaskList.DataSource;
            DataRow newRow = taskTable.NewRow();
            newRow[0] = task.getTruck().plateNumber;
            newRow[1] = task.product.getProductCategory().name;
            newRow[2] = task.startDatetime;
            newRow[3] = task.taskId;
            taskTable.Rows.Add(newRow);
        }

        private void historyDataView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                initInformation();
                displayingHistoryIndex = e.RowIndex;
                changeDisplayingHistory(historyList[displayingHistoryIndex]);
            }
        }

        void initHistoryInfo()
        {
            historyMapWeb.Document.InvokeScript("clear");
            historyTemperatureChart.Series[0].Points.Clear();
        }

        int left = 0;

        void changeDisplayingHistory(Task task)
        {
            historyTemperatureMax = TEMPERATURE_MAXNUM;
            historyPlateNumLabel.Text = "车牌号：" + task.getTruck().plateNumber;
            historyDirectorNameLabel.Text = "负责人姓名：" + task.getDriver().userName;
            historyDirectorNumLabel.Text = "负责人电话：" + task.getDriver().phoneNum;
            historyProductNameLabel.Text = "产品名：" + task.product.getProductCategory().name;
            historyProductTemperatureLabel.Text = "适宜运输温度：" + task.product.getProductCategory().getTemperature(task.product.temperatureId).temperature + " ℃";
            historyBeginDatetimeLabel.Text = "运输开始时间：" + task.startDatetime;
            historyEndDatetimeLabel.Text = "运输结束时间：" + task.endDatetime;
            if (task.getDatas() != null)
            {
                List<Coordinate> points = new List<Coordinate>();
                foreach (MonitoringData data in task.getDatas())
                {
                    points.AddRange(data.coordinates);
                }
                historyMapWeb.Document.InvokeScript("initTransportRoute");
                historyMapWeb.Document.InvokeScript("drawTransportRoute", new object[] { JsonConvert.SerializeObject(points), "", true });
                drawHistoryChart(task);
            }
            left = 0;
        }

        void drawHistoryChart(Task task)
        {
            historyTemperatureChart.Series[0].Points.Clear();
            foreach (MonitoringData data in task.getDatas())
            {
                DateTime dateTime = Convert.ToDateTime(data.datetime);
                historyTemperatureChart.Series[0].Points.AddXY(dateTime.ToString("HH:mm"), data.temperature.getMeanTemperature());
                DataPoint dataPoint = historyTemperatureChart.Series[0].Points[historyTemperatureChart.Series[0].Points.Count - 1];
                Double[] temperatureRange = task.product.getProductCategory().getTemperature(task.product.temperatureId).getTemperatureRange();
                if (dataPoint.YValues[0] > temperatureRange[1] || dataPoint.YValues[0] < temperatureRange[0])
                {
                    dataPoint.Color = Color.Red;
                    dataPoint.LabelForeColor = Color.Red;
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int i0 = historyList[displayingHistoryIndex].getDatasCount() - historyTemperatureMax;
            if (i0 > 0)
            {
                left++;
                left = (left < i0 ? left : i0);
            }
            drawHistoryChart(historyList[displayingHistoryIndex]);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            left--;
            left = left < 0 ? 0 : left;
            drawHistoryChart(historyList[displayingHistoryIndex]);
        }

        private void enlargeButton_Click(object sender, EventArgs e)
        {
            if (historyTemperatureMax < historyList[displayingHistoryIndex].getDatasCount() - 1)
            {
                historyTemperatureMax++;
                drawHistoryChart(historyList[displayingHistoryIndex]);
            }
        }

        private void narrowButton_Click(object sender, EventArgs e)
        {
            if (historyTemperatureMax > TEMPERATURE_MAXNUM)
            {
                historyTemperatureMax--;
                drawHistoryChart(historyList[displayingHistoryIndex]);
            }
        }

        #endregion

        private void addTemperatureData(MonitoringData data)
        {
            DateTime dateTime = Convert.ToDateTime(data.datetime);
            temperatureLabel.Text = "当前车内温度： " + data.temperature.getMeanTemperature() + " ℃";
            addPoint(dateTime, data.temperature.getMeanTemperature());

            if (taskList[displayingTaskId].getTemperatureAlarm() != null && taskList[displayingTaskId].getTemperatureAlarm().state == Task.TemperatureAlarm.State.Unsolved)
            {
                mainTaskList.Rows[findTaskIndexById(displayingTaskId)].DefaultCellStyle.BackColor = Color.Red;
                mainTaskInfoAlarmTips.Text = taskList[displayingTaskId].getTemperatureAlarm().alarmMessage;
                mainTaskInfoAlarmTips.ForeColor = Color.Red;
                temperatureAlert.Show();

            }
            else
            {
                mainTaskList.Rows[findTaskIndexById(displayingTaskId)].DefaultCellStyle.BackColor = Color.White;
                mainTaskInfoAlarmTips.Text = "车内温度正常";
                mainTaskInfoAlarmTips.ForeColor = Color.Black;
                temperatureAlert.Hide();
            }
        }



        private void 停止一次任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timers.Count != 0)
            {
                timers[0].Stop();
                timers.RemoveAt(0);
                String taskString = String.Format("{{\"datetime\":\"{0} \"," +
                    "\"taskId\":\"0010\"," +
                    "\"statecode\":\"{1} \"}}",
                    DateTime.Now.ToString("yyyy/MM/dd HH:mm"), 0);
                AsyncSend(socketList[0], taskString);
                //socketList[k].BeginDisconnect(false, asyncResult =>
                //{
                //    socketList[k++].EndDisconnect(asyncResult);
                //}, null);
            }
        }

        private void 模拟一次任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (socketList.Count < 2)
                AtaskTimer(socketList.Count);
        }

        private void 驾驶员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (homeTabControl.SelectedIndex == 1)
            {
                showHistoryList();
            }
        }

        private void allPicture_Click(object sender, EventArgs e)
        {
            homeTabControl.SelectedIndex = 0;
            panelMainAll.Visible = true;
            panelMainTask.Visible = false;
            labelMenuAll.Visible = true;
            labelMenuHistory.Visible = false;
            labelMenuInfo.Visible = false;

            mainTaskList.CurrentCell = null;
            displayingTaskId = "";

        }

        private void historyPicture_Click(object sender, EventArgs e)
        {
            homeTabControl.SelectedIndex = 1;
            labelMenuAll.Visible = false;
            labelMenuHistory.Visible = true;
            labelMenuInfo.Visible = false;
        }
        private void infoPicture_Click(object sender, EventArgs e)
        {
            homeTabControl.SelectedIndex = 2;
            labelMenuAll.Visible = false;
            labelMenuHistory.Visible = false;
            labelMenuInfo.Visible = true;
        }
        private void ChartDetail_Click(object sender, EventArgs e)
        {
            if (historyList != null && displayingHistoryIndex != -1)
            {
                ChartDetailForm chartDetailForm = new ChartDetailForm(historyList[displayingHistoryIndex]);
                chartDetailForm.ShowDialog(this);
            }
        }

        private void showDirectorList()
        {
            List<User> directorList = dbOperation.getDirectorList(-1);
            if (directorList.Count != userDataView.RowCount)
            {
                DataTable directorTable = new DataTable();
                directorTable.Columns.Add("驾驶员ID");
                directorTable.Columns.Add("驾驶员姓名");
                directorTable.Columns.Add("驾驶员联系方式");
                foreach (User director in directorList)
                {
                    DataRow newRow = directorTable.NewRow();
                    newRow[0] = director.userId;
                    newRow[1] = director.userName;
                    newRow[2] = director.phoneNum;
                    directorTable.Rows.Add(newRow);
                }
                userDataView.DataSource = directorTable;
            }
        }

        private void temperatureAlert_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("请在和车辆负责人联系确认已处理温度异常后取消警报！（或是等待温度正常后自动取消警报）", "是否取消此次警报", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                taskList[displayingTaskId].solveLastTemperatureAlarm();
                temperatureAlert.Hide();
            }
        }

        private void showTruckList(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedIndex = 0;
            panel1.BackColor = Color.LightGray;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            showTruckList();
        }

        private void showUserList(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedIndex = 1;
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.LightGray;
            panel3.BackColor = Color.White;
            showUserList();
        }

        private void showProductList(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedIndex = 2;
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.LightGray;
            showProductList();
        }

        private void historyWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            historyMapWeb.Document.InvokeScript("init", new object[] { 0, 0, 5 });
            historyMapWeb.Document.InvokeScript("initTransportRoute");
            historyMapWeb.Show();
        }

        private void allWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowserMainAll.Document.InvokeScript("init", new object[] { 0, 0, 5 });
            webBrowserMainAll.Show();
        }

        private void webBrowser4Map_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            mainMapWeb.Document.InvokeScript("init", new object[] { 0, 0, 5 });
            mainMapWeb.Show();
        }

        private void 车辆信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTruckForm newTruckForm = new NewTruckForm();
            newTruckForm.ShowDialog(this);
        }

        private void 产品信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void taskDataView_SelectionChanged(object sender, EventArgs e)
        {
            if (isFirstTask)
            {
                mainTaskList.CurrentCell = null;
                isFirstTask = false;
            }
        }

        #region truckInfo
        int newTruckRowIndex = -1;
        int modifyTruckRowIndex = -1;
        Truck truckItem;
        private void truckAdd_Click(object sender, EventArgs e)
        {
            newTruckRowIndex = truckDataView.Rows.Add();
            if (newTruckRowIndex != -1)
                truckDataView.Rows[newTruckRowIndex].Cells["TruckID"].Value = newTruckRowIndex;
        }

        private void truckDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否删除车牌号为\"" + truckDataView.CurrentRow.Cells[2].Value.ToString() + "\"的冷链车", "确认删除", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                if (dbOperation.deleteTruck(truckDataView.CurrentRow.Cells["TruckId"].Value.ToString()))
                {
                    MessageBox.Show("删除成功", "删除", MessageBoxButtons.OK);
                    truckDataView.Rows.Remove(truckDataView.SelectedRows[0]);
                }
            }
        }

        private void truckDataView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (modifyTruckRowIndex != -1)
            {
                if (modifyTruckRowIndex != e.RowIndex)
                {
                    if (modifyTruckRowIndex != newTruckRowIndex)
                        setTruckItem(modifyTruckRowIndex, truckItem);
                    truckModifyState(false);
                }
            }
        }

        private void truckDataView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            modifyTruckRowIndex = e.RowIndex;
            if (modifyTruckRowIndex != newTruckRowIndex)
                truckItem = getTruckItem();
            truckModifyState(true);
        }

        private void truckModifyState(bool ifModify)
        {
            truckDataView.ReadOnly = !ifModify;
            truckDataView.BeginEdit(ifModify);
            truckModify.Visible = ifModify;
            truckCancel.Visible = ifModify;

            if (!ifModify)
            {
                modifyTruckRowIndex = -1;
                if (newTruckRowIndex != -1)
                {
                    truckDataView.Rows.RemoveAt(newTruckRowIndex);
                    newTruckRowIndex = -1;
                }
            }

        }

        private void truckCancel_Click(object sender, EventArgs e)
        {
            truckModifyState(false);
        }

        private void truckModify_Click(object sender, EventArgs e)
        {
            Truck newTruck = getTruckItem();
            if (modifyTruckRowIndex != -1)
            {
                if (newTruckRowIndex == -1)
                {
                    bool success = DbOperation.Instance.updateTruckInfo(newTruck);
                    if (success)
                    {
                        truckModify.Visible = false;
                        truckCancel.Visible = false;
                        MessageBox.Show("修改成功", "成功", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("请检查数据格式后重新提交修改", "失败", MessageBoxButtons.OK);
                    }
                    modifyTruckRowIndex = -1;
                }
                else
                {
                    bool success = DbOperation.Instance.insertTruck(newTruck);
                    if (success)
                    {
                        truckModify.Visible = false;
                        truckCancel.Visible = false;
                        MessageBox.Show("添加成功", "成功", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("请检查数据格式后重新添加", "失败", MessageBoxButtons.OK);
                    }
                    modifyTruckRowIndex = -1;
                    newTruckRowIndex = -1;
                }
            }
        }

        private void showTruckList()
        {
            truckDataView.Rows.Clear();
            List<Truck> truckList = dbOperation.getTruckList();
            foreach (Truck truck in truckList)
            {
                int index = truckDataView.Rows.Add();
                setTruckItem(index, truck);
            }
        }

        private Truck getTruckItem()
        {
            String truckId = truckDataView.SelectedRows[0].Cells["TruckID"].Value.ToString();
            String load = truckDataView.SelectedRows[0].Cells["TruckLoad"].Value.ToString();
            String model = truckDataView.SelectedRows[0].Cells["TruckModel"].Value.ToString();
            String plateNumber = truckDataView.SelectedRows[0].Cells["TruckPlateNumber"].Value.ToString();
            Truck truck = new Truck(truckId, "1", "0001", plateNumber, model, load, "");
            return truck;
        }

        private void setTruckItem(int index, Truck truck)
        {
            truckDataView.Rows[index].Cells["TruckPlateNumber"].Value = truck.plateNumber;
            truckDataView.Rows[index].Cells["TruckModel"].Value = truck.model;
            truckDataView.Rows[index].Cells["TruckLoad"].Value = truck.load;
            truckDataView.Rows[index].Cells["TruckID"].Value = truck.truckId;
            truckDataView.Rows[index].Cells["TruckState"].Value = Truck.stateString[truck.stateCode];
        }
        #endregion

        #region productInfo
        int newProductRowIndex = -1;
        int modifyProductRowIndex = -1;
        ProductCategory productItem;
        private void productAdd_Click(object sender, EventArgs e)
        {
            newProductRowIndex = productDataView.Rows.Add();
        }

        private void productDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("删除产品\"" + productDataView.CurrentRow.Cells["ProductInfoName"].Value.ToString() + "\"", "确认删除", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                dbOperation.deleteProduct(productDataView.CurrentRow.Cells["ProductInfoId"].Value.ToString());
            }
        }

        private void productDataView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (modifyProductRowIndex != -1)
            {
                if (modifyProductRowIndex != e.RowIndex)
                {
                    setProductItem(modifyProductRowIndex, productItem);
                    productModifyState(false);
                }
            }
        }

        private void productDataView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            modifyProductRowIndex = e.RowIndex;
            if (modifyProductRowIndex != newProductRowIndex)
                productItem = getProductItem();
            productModifyState(true);
        }

        private void productModifyState(bool ifModify)
        {
            productDataView.ReadOnly = !ifModify;
            productDataView.BeginEdit(ifModify);
            productSure.Visible = ifModify;
            productCancel.Visible = ifModify;

            if (!ifModify)
            {
                modifyProductRowIndex = -1;
                if (newProductRowIndex != -1)
                {
                    productDataView.Rows.RemoveAt(newProductRowIndex);
                    newProductRowIndex = -1;
                }
            }

        }

        private void productCancel_Click(object sender, EventArgs e)
        {
            productModifyState(false);
        }

        private void productModify_Click(object sender, EventArgs e)
        {
            ProductCategory newProduct = getProductItem();
            if (modifyProductRowIndex != -1)
            {
                if (newProductRowIndex == -1)
                {
                    bool success = DbOperation.Instance.updateProductCategory(newProduct);
                    if (success)
                    {
                        productSure.Visible = false;
                        productCancel.Visible = false;
                        MessageBox.Show("修改成功", "成功", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("请检查数据格式后重新提交修改", "失败", MessageBoxButtons.OK);
                    }
                    modifyProductRowIndex = -1;
                }
                else
                {
                    bool success = DbOperation.Instance.insertProductCategory(newProduct);
                    if (success)
                    {
                        productSure.Visible = false;
                        productCancel.Visible = false;
                        MessageBox.Show("添加成功", "成功", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("请检查数据格式后重新添加", "失败", MessageBoxButtons.OK);
                    }
                    modifyProductRowIndex = -1;
                    newProductRowIndex = -1;
                }
            }
        }

        private void showProductList()
        {
            productDataView.Rows.Clear();
            List<ProductCategory> productList = dbOperation.getProductCategorytList();
            foreach (ProductCategory product in productList)
            {
                int index = productDataView.Rows.Add();
                setProductItem(index, product);
            }
        }



        private ProductCategory getProductItem()
        {
            String productId = productDataView.CurrentRow.Cells["ProductInfoId"].Value.ToString();
            String productName = productDataView.CurrentRow.Cells["ProductInfoName"].Value.ToString();
            String nickname = productDataView.CurrentRow.Cells["ProductInfoNickname"].Value.ToString();
            String category = productDataView.CurrentRow.Cells["ProductInfoCategory"].Value.ToString();
            String remark = productDataView.CurrentRow.Cells["ProductInfoRemark"].Value.ToString();
            ProductCategory productCategory = new ProductCategory(productId, productName, nickname, category, remark, "");
            return productCategory;
        }

        private void setProductItem(int index, ProductCategory productCategory)
        {
            productDataView.Rows[index].Cells["ProductInfoId"].Value = productCategory.id;
            productDataView.Rows[index].Cells["ProductInfoName"].Value = productCategory.name;
            productDataView.Rows[index].Cells["ProductInfoNickname"].Value = productCategory.nicknames;
            productDataView.Rows[index].Cells["ProductInfoCategory"].Value = productCategory.category;
            productDataView.Rows[index].Cells["ProductInfoRemark"].Value = productCategory.remark;
            productDataView.Rows[index].Cells["ProductInfoTemperatures"].Value = "适宜运输温度";
        }

        private void productDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = productDataView.Columns[e.ColumnIndex];
                if (column.Name == "ProductInfoTemperatures")
                {
                    NewProductForm newProduct = new NewProductForm(getProductItem());
                    newProduct.ShowDialog(this);
                }
            }
        }
        #endregion

        #region userInfo
        int newUserRowIndex = -1;
        int modifyUserRowIndex = -1;
        User userItem;
        private void userAdd_Click(object sender, EventArgs e)
        {
            newUserRowIndex = userDataView.Rows.Add();
        }

        private void userDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("删除用户\"" + userDataView.CurrentRow.Cells["UserInfoName"].Value.ToString() + "\"", "确认删除", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                if (dbOperation.deleteUser(userDataView.CurrentRow.Cells["UserInfoId"].Value.ToString()))
                {
                    MessageBox.Show("删除成功", "删除", MessageBoxButtons.OK);
                    userDataView.Rows.Remove(userDataView.CurrentRow);
                }
            }
        }

        private void userDataView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (modifyUserRowIndex != -1)
            {
                if (modifyUserRowIndex != e.RowIndex)
                {
                    if (modifyUserRowIndex != newUserRowIndex)
                        setUserItem(modifyUserRowIndex, userItem);
                    userModifyState(false);
                }
            }
        }

        private void userDataView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            modifyUserRowIndex = e.RowIndex;
            if (modifyUserRowIndex != newUserRowIndex)
                userItem = getUserItem();
            userModifyState(true);
        }

        private void userModifyState(bool ifModify)
        {
            userDataView.ReadOnly = !ifModify;
            userDataView.BeginEdit(ifModify);
            userSure.Visible = ifModify;
            userCancel.Visible = ifModify;

            if (!ifModify)
            {
                modifyUserRowIndex = -1;
                if (newUserRowIndex != -1)
                {
                    userDataView.Rows.RemoveAt(newUserRowIndex);
                    newUserRowIndex = -1;
                }
            }

        }

        private void userCancel_Click(object sender, EventArgs e)
        {
            userModifyState(false);
        }

        private void userSure_Click(object sender, EventArgs e)
        {
            User newUser = getUserItem();
            if (modifyUserRowIndex != -1)
            {
                if (newUserRowIndex == -1)
                {
                    bool success = DbOperation.Instance.updateUserInfo(newUser);
                    if (success)
                    {
                        userSure.Visible = false;
                        userCancel.Visible = false;
                        MessageBox.Show("修改成功", "成功", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("请检查数据格式后重新提交修改", "失败", MessageBoxButtons.OK);
                    }
                    modifyUserRowIndex = -1;
                }
                else
                {
                    bool success = DbOperation.Instance.insertUser(newUser);
                    if (success)
                    {
                        userSure.Visible = false;
                        userCancel.Visible = false;
                        MessageBox.Show("添加成功", "成功", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("请检查数据格式后重新添加", "失败", MessageBoxButtons.OK);
                    }
                    modifyUserRowIndex = -1;
                    newUserRowIndex = -1;
                }
            }
        }

        private void showUserList()
        {
            userDataView.Rows.Clear();
            List<User> userList = dbOperation.getUserList();
            foreach (User user in userList)
            {
                int index = userDataView.Rows.Add();
                setUserItem(index, user);
            }
        }

        private User getUserItem()
        {
            String userId = userDataView.CurrentRow.Cells["UserInfoId"].Value.ToString();
            String userName = userDataView.CurrentRow.Cells["UserInfoName"].Value.ToString();
            String nickname = userDataView.CurrentRow.Cells["UserInfoNickname"].Value.ToString();
            String sex = userDataView.CurrentRow.Cells["UserInfoSex"].Value.ToString();
            String phoneNum = userDataView.CurrentRow.Cells["UserInfoPhoneNum"].Value.ToString();
            String idNumber = userDataView.CurrentRow.Cells["UserInfoIdNum"].Value.ToString();
            int userType = User.typeString.First(q => q.Value == userDataView.CurrentRow.Cells["UserInfoType"].Value.ToString()).Key;
            String password = userDataView.CurrentRow.Cells["UserInfoPassword"].Value.ToString();
            User user = new User(userId, userName, nickname, "", "1", sex, phoneNum, idNumber, "", userType, 0);
            user.password = password;
            return user;
        }

        private void setUserItem(int index, User user)
        {
            userDataView.Rows[index].Cells["UserInfoId"].Value = user.userId;
            userDataView.Rows[index].Cells["UserInfoName"].Value = user.userName;
            userDataView.Rows[index].Cells["UserInfoNickname"].Value = user.nickname;
            userDataView.Rows[index].Cells["UserInfoSex"].Value = user.sex;
            userDataView.Rows[index].Cells["UserInfoPhoneNum"].Value = user.phoneNum;
            userDataView.Rows[index].Cells["UserInfoIdNum"].Value = user.idNumber;
            userDataView.Rows[index].Cells["UserInfoType"].Value = User.typeString[user.userType];
            userDataView.Rows[index].Cells["UserInfoPassword"].Value = user.password;
        }

        #endregion
    }
}
