using MonitoringPlatform.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using static MonitoringPlatform.Task;

namespace MonitoringPlatform
{
    class DbOperation
    {
        OleDbConnection oleDbConnection;
        private static DbOperation instance = null;
        private static readonly object padlock = new object();

        #region Database
        public static DbOperation Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DbOperation();
                    }
                }

                return instance;
            }
        }

        public void dbConnection(String dataSource)
        {
            try
            {
                //数据库连接
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;";
                connectionString += " Data Source=" + dataSource;
                oleDbConnection = new OleDbConnection(connectionString);
                oleDbConnection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public void dbConnectionClose()
        {
            oleDbConnection.Close();
        }
        #endregion

        #region Task 
        public List<Task> searchTasks(String key, int state)
        {
            List<Task> searchResultTasks = new List<Task>();
            try
            {
                OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
                if (key.Contains('~'))
                {
                    String[] s = key.Split('~');
                    if (s[0] != "")
                    {
                        if (s[1] != "")
                        {
                            oleDbCommand.CommandText =
                                String.Format("SELECT * FROM Task WHERE taskState={0} AND endDatetime>#{1}# AND endDatetime<#{2}#",
                                state, s[0], s[1]);
                        }
                        else
                        {
                            oleDbCommand.CommandText =
                              String.Format("SELECT * FROM Task WHERE taskState={0} AND endDatetime>#{1}#",
                              state, s[0]);
                        }
                    }
                    else if (s[1] != "")
                    {
                        oleDbCommand.CommandText =
                             String.Format("SELECT * FROM Task WHERE taskState={0} AND endDatetime<#{1}#",
                             state, s[1]);
                    }
                }
                else
                {//SELECT * FROM Task,Truck WHERE taskState={0} AND Task.truckId=Truck.id AND (taskId LIKE '*{1}*' OR plateNumber LIKE '*{1}*' OR endDatetime LIKE '*{1}*')
                    oleDbCommand.CommandText =
                            String.Format("SELECT * FROM Task,Truck WHERE taskState={0} AND Task.truckId=Truck.id AND (taskId LIKE '%{1}%' OR plateNumber LIKE '%{1}%' OR endDatetime LIKE '%{1}%')",
                            state, key);
                }
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                Console.WriteLine(oleDbDataReader.HasRows);
                searchResultTasks = getTaskList(oleDbDataReader);
                return searchResultTasks;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return searchResultTasks;
            }
        }

        public String insertTask(Task task)
        {
            int newTaskId = getLastTaskId() + 1;
            if (newTaskId > 0 && newTaskId < 10000)
            {
                String taskId = taskIdConvert(newTaskId);
                OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
                oleDbCommand.CommandText =
                    String.Format("INSERT INTO [Task]([taskId],[publisherId],[terminalId],[startPlaceString],[endPlaceString],productId,dateOfProduction,placeOfProduction,quantity,unit,temperatureId) VALUES ('{0}',{1},'{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')"
                    , taskId
                    , task.publisherId
                    , "0001"
                    , JsonConvert.SerializeObject(task.startPlace)
                    , JsonConvert.SerializeObject(task.endPlace)
                    , task.product.id
                    , task.product.dateOfProduction
                    , task.product.placeOfProduction
                    , task.product.quantity
                    , task.product.unit
                    , task.product.temperatureId);
                oleDbCommand.ExecuteNonQuery();
                return taskId;
            }
            return null;
        }

        private String taskIdConvert(int taskId)
        {
            return String.Format("{0:D4}", taskId);
        }

        private int getLastTaskId()
        {
            String lastId = "0000";
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("SELECT MAX(taskId) AS lastId FROM Task");
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            while (oleDbDataReader.Read())
            {
                lastId = oleDbDataReader["lastId"].ToString();
            }
            return Convert.ToInt32(lastId);
        }

        public void updateTask(Task task, int newState)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            switch (newState)
            {
                case 0://完成
                       //更新司机和车辆的状态
                    updateDriverState(task.driverId, User.DRIVER_STATE_STANDBY);
                    updateTruckState(task.truckId, Truck.STATE_CODE_STANDBY);

                    String alarmsString = "";
                    if (task.temperatureAlarms != null)
                    {
                        alarmsString = JsonConvert.SerializeObject(task.temperatureAlarms);
                    }
                    oleDbCommand.CommandText =
                        String.Format("UPDATE Task SET taskState=0, alarmsString='{1}', endDatetime='{2}' WHERE taskId='{0}'",
                        task.taskId,
                        alarmsString,
                        task.endDatetime);
                    break;
                case 1://进行中
                    oleDbCommand.CommandText =
                       String.Format("UPDATE Task SET taskState=1,startDatetime='{0}' WHERE taskId='{1}'",
                       task.startDatetime,
                       task.taskId);
                    break;
                case 2://未接受
                    break;
                case 3://未开始
                       //更新司机和车辆的状态
                    updateDriverState(task.driverId, User.DRIVER_STATE_WORK);
                    updateTruckState(task.truckId, Truck.STATE_CODE_TRANSPORT);

                    oleDbCommand.CommandText =
                       String.Format("UPDATE Task SET taskState=3,accepterId='{1}',truckId='{2}',driverId='{3}' WHERE taskId='{0}'",
                       task.taskId,
                       task.accepterId,
                       task.truckId,
                       task.driverId);
                    break;
            }
            oleDbCommand.ExecuteNonQuery();
        }

        public void updateTaskTemperatureAlarm(String taskId, List<Task.TemperatureAlarm> alarms)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText =
                       String.Format("UPDATE Task SET alarmsString='{0}' WHERE taskId='{1}'",
                       JsonConvert.SerializeObject(alarms),
                       taskId);
            oleDbCommand.ExecuteNonQuery();
        }

        private List<Task> getTaskList(OleDbDataReader oleDbDataReader)
        {
            List<Task> taskList = new List<Task>();
            try
            {
                while (oleDbDataReader.Read())
                {
                    Task task = getTask(oleDbDataReader, false);
                    if (task != null)
                        taskList.Add(task);
                }
            }
            catch { }
            return taskList;
        }

        public List<Task> getTaskListWithState(int state)
        {
            List<Task> taskList = new List<Task>();
            try
            {
                OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
                oleDbCommand.CommandText = String.Format("SELECT * FROM Task WHERE taskState={0}", state);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                taskList = getTaskList(oleDbDataReader);
            }
            catch { }
            return taskList;
        }

        public List<Task> getTaskListWithStateAndUserId(String state, String userId)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("SELECT * FROM Task WHERE taskState IN ({0}) AND (publisherId={1} OR accepterId={1} OR driverId={1})", state, userId);
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            return getTaskList(oleDbDataReader);
        }

        public List<Task> getTaskListByPublisherId(String publisherId)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("select * from Task where publisherId={0}", publisherId);
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            return getTaskList(oleDbDataReader);
        }

        public List<Task> getTaskListByAccepeterId(String accepterId)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("select * from Task where accepterId={0}", accepterId);
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            return getTaskList(oleDbDataReader);
        }

        public List<Task> getTaskListByDriverId(String driverId)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("select * from Task where driverId={0}", driverId);
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            return getTaskList(oleDbDataReader);
        }

        private Task getTask(OleDbDataReader oleDbDataReader, bool needRead)
        {
            Task task = null;
            try
            {
                if (needRead)
                    oleDbDataReader.Read();
                String taskId = oleDbDataReader["taskId"].ToString();
                String publisherId = oleDbDataReader["publisherId"].ToString();
                Coordinate startPlace = JsonConvert.DeserializeObject<Coordinate>(oleDbDataReader["startPlaceString"].ToString());
                Coordinate endPlace = JsonConvert.DeserializeObject<Coordinate>(oleDbDataReader["endPlaceString"].ToString());
                int taskState = Convert.ToInt16(oleDbDataReader["taskState"].ToString()); ;

                String productId = oleDbDataReader["productId"].ToString();
                String dateOfProduction = oleDbDataReader["dateOfProduction"].ToString();
                Coordinate placeOfProduction = JsonConvert.DeserializeObject<Coordinate>(oleDbDataReader["placeOfProduction"].ToString());
                int quantity = Convert.ToInt32(oleDbDataReader["quantity"].ToString());
                String unit = oleDbDataReader["unit"].ToString();
                int temperatureId = Convert.ToInt32(oleDbDataReader["temperatureId"].ToString());
                Product product = new Product(productId, temperatureId, quantity, unit, placeOfProduction, dateOfProduction);

                Task newTask = new Task(taskId, publisherId, startPlace, endPlace, product);
                if (taskState != Task.TASK_STATE_UNACCEPTED)
                {
                    newTask.taskState = taskState;
                    newTask.accepterId = oleDbDataReader["accepterId"].ToString();
                    newTask.truckId = oleDbDataReader["truckId"].ToString();
                    try { newTask.terminalId = oleDbDataReader["terminalId"].ToString(); }
                    catch { newTask.terminalId = oleDbDataReader["Task.terminalId"].ToString(); }
                    newTask.driverId = oleDbDataReader["driverId"].ToString();
                    if (taskState != Task.TASK_STATE_UNSTARTED)
                    {
                        newTask.setDatas(getMonitoringDatasByTaskId(taskId));
                        newTask.startDatetime = oleDbDataReader["startDatetime"].ToString();
                        if (taskState != Task.TASK_STATE_TRANSPORT)
                        {
                            newTask.endDatetime = oleDbDataReader["endDatetime"].ToString();
                            String alarmsString = oleDbDataReader["alarmsString"].ToString();
                            if (alarmsString != null && alarmsString != "")
                                newTask.temperatureAlarms = JsonConvert.DeserializeObject<List<Task.TemperatureAlarm>>(alarmsString);
                        }
                    }

                }
                task = newTask;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return task;
        }

        public Task findTaskById(String taskId)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("select * from Task where taskId='{0}'", taskId);
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            return getTask(oleDbDataReader, true);
        }

        public Task findTaskTransport(String terminalId)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("select * from Task where taskState={0},terminalId='{1}'", Task.TASK_STATE_TRANSPORT, terminalId);
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            return getTask(oleDbDataReader, true);
        }
        #endregion

        #region Truck

        public bool insertTruck(Truck newTruck)
        {
            try
            {
                OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
                oleDbCommand.CommandText = String.Format("insert into Truck(plateNumber, model, load, registrationCertificateUrl, terminalId, companyId)" +
                    " values ('{0}','{1}','{2}','{3}','{4}',{5})",
                    newTruck.plateNumber,
                    newTruck.model,
                    newTruck.load,
                    newTruck.registrationCertificateUrl,
                    newTruck.terminalId,
                    newTruck.companyId);
                oleDbCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool deleteTruck(String truckId)
        {
            try
            {
                OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
                oleDbCommand.CommandText = String.Format("delete from Truck where id={0}", truckId);
                oleDbCommand.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
        }

        public void updateTruckState(String truckId, int stateCode)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("UPDATE Truck SET stateCode={0} WHERE [id]={1}", stateCode, truckId);
            oleDbCommand.ExecuteNonQuery();
        }

        public bool updateTruckInfo(Truck truck)
        {
            try
            {
                OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
                oleDbCommand.CommandText = String.Format("UPDATE Truck SET model='{1}', load='{2}', plateNumber='{3}' WHERE [id]={0}", truck.truckId, truck.model, truck.load, truck.plateNumber);
                oleDbCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Truck> getTruckList()
        {
            List<Truck> truckList = new List<Truck>();
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = "select * from Truck";
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            while (oleDbDataReader.Read())
            {
                truckList.Add(new Truck(oleDbDataReader["id"].ToString(),
                    oleDbDataReader["companyId"].ToString(),
                    oleDbDataReader["terminalId"].ToString(),
                    oleDbDataReader["plateNumber"].ToString(),
                    oleDbDataReader["model"].ToString(),
                    oleDbDataReader["load"].ToString(),
                    oleDbDataReader["registrationCertificateUrl"].ToString()));
            }
            return truckList;
        }

        public Truck findTruckById(String truckId)
        {
            Truck truck = null;
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("SELECT * from Truck where id = {0}", truckId);
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            while (oleDbDataReader.Read())
            {
                truck = new Truck(oleDbDataReader["id"].ToString(),
                    oleDbDataReader["companyId"].ToString(),
                    oleDbDataReader["terminalId"].ToString(),
                    oleDbDataReader["plateNumber"].ToString(),
                    oleDbDataReader["model"].ToString(),
                    oleDbDataReader["load"].ToString(),
                    oleDbDataReader["registrationCertificateUrl"].ToString());
            }
            return truck;
        }

        #endregion

        #region User
        public bool deleteUser(String userId)
        {
            try
            {
                OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
                oleDbCommand.CommandText = String.Format("delete from User where id={0}", userId);
                oleDbCommand.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
        }

        public bool insertUser(User newUser)
        {
            if (newUser.userId == "")
            {
                OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
                oleDbCommand.CommandText = String.Format("insert into User(userName,nickname,photoUrl,companyId,sex,phoneNum,idNumber,drivingLicenseUrl,userType,password)" +
                    " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},'{9}')",
                    newUser.userName,
                    newUser.nickname,
                    newUser.phoneNum,
                    newUser.companyId,
                    newUser.sex,
                    newUser.phoneNum,
                    newUser.idNumber,
                    newUser.drivingLicenseUrl,
                    newUser.userType,
                    newUser.password);
                oleDbCommand.ExecuteNonQuery();
                return true;
            }
            else return false;
        }

        public List<User> getUserList()
        {
            List<User> userList = new List<User>();
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("SELECT * FROM [User]");
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            while (true)
            {
                User user = getUserInfo(oleDbDataReader, true);
                if (user != null)
                    userList.Add(user);
                else
                    break;
            }
            return userList;
        }

        public List<User> getDirectorList(int driverState)
        {
            List<User> directorList = new List<User>();
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            if (driverState == -1)
                oleDbCommand.CommandText = String.Format("SELECT * FROM [User] WHERE userType=1", driverState);
            else
                oleDbCommand.CommandText = String.Format("SELECT * FROM [User] WHERE userType=1 AND driverState={0}", driverState);
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            while (true)
            {
                User user = getUserInfo(oleDbDataReader, false);
                if (user != null)
                    directorList.Add(user);
                else
                    break;
            }
            return directorList;
        }

        private User getUserInfo(OleDbDataReader oleDbDataReader, bool ifNeedPassword)
        {
            User user = null;
            if (oleDbDataReader.Read())
            {
                user = new User(oleDbDataReader["id"].ToString(),
                   oleDbDataReader["userName"].ToString(),
                   oleDbDataReader["nickname"].ToString(),
                   oleDbDataReader["photoUrl"].ToString(),
                   oleDbDataReader["companyId"].ToString(),
                   oleDbDataReader["sex"].ToString(),
                   oleDbDataReader["phoneNum"].ToString(),
                   oleDbDataReader["idNumber"].ToString(),
                   oleDbDataReader["drivingLicenseUrl"].ToString(),
                   Convert.ToInt32(oleDbDataReader["userType"].ToString()),
                   Convert.ToInt32(oleDbDataReader["driverState"].ToString()));
                if (ifNeedPassword)
                    user.password = oleDbDataReader["password"].ToString();
            }
            return user;
        }

        public User findUserById(String userId)
        {
            User user = null;
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("SELECT * FROM [User] WHERE id={0}", userId);
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            return getUserInfo(oleDbDataReader, true);
        }

        public User findUserByAccount(String userAccount, String password)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("SELECT * FROM [User] WHERE phoneNum='{0}' AND password='{1}'", userAccount, password);
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            return getUserInfo(oleDbDataReader, false);
        }

        public bool updateDriverState(String userId, int driverState)
        {
            try
            {
                OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
                oleDbCommand.CommandText = String.Format("UPDATE [User] SET [driverState]={0} WHERE [id]={1} AND [userType]=1", driverState, userId);
                oleDbCommand.ExecuteNonQuery(); return true;
            }
            catch { return false; }
        }

        public bool updateUserInfo(User user)
        {
            try
            {
                OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
                oleDbCommand.CommandText = String.Format("UPDATE [User] SET userName='{1}', nickname='{2}', sex='{3}',phoneNum='{4}',idNumber='{5}',userType='{6}',password='{7}' WHERE [ID]={0}",
                    user.userId, user.userName, user.nickname, user.sex, user.phoneNum, user.idNumber, user.userType, user.password);
                oleDbCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region ProductCategory
        public List<ProductCategory> getProductCategorytList()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = "SELECT * FROM ProductCategory";
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            return getProductCategorys(oleDbDataReader);
        }

        public ProductTemperature findProductTemperature(String productId, int index)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("SELECT * FROM ProductTemp WHERE productId='{0}' AND [id]={1}",
                productId, index);
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            return getProductTemperature(oleDbDataReader);
        }

        public List<ProductTemperature> getProductTemperatures(String productId)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("SELECT * FROM ProductTemp WHERE productId='{0}' ORDER BY [id]",
                productId);
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            return getProductTemperatures(oleDbDataReader);
        }

        public List<ProductTemperature> getProductTemperatures(String productId, int state)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("SELECT * FROM ProductTemp WHERE productId='{0}' AND [state]={1} ORDER BY [id]",
                productId, state);
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            return getProductTemperatures(oleDbDataReader);
        }

        private List<ProductTemperature> getProductTemperatures(OleDbDataReader oleDbDataReader)
        {
            List<ProductTemperature> temps = new List<ProductTemperature>();
            while (true)
            {
                ProductTemperature temp = getProductTemperature(oleDbDataReader);
                if (temp != null)
                    temps.Add(temp);
                else
                    break;
            }
            return temps;
        }

        private ProductTemperature getProductTemperature(OleDbDataReader oleDbDataReader)
        {
            ProductTemperature temp = null;
            if (oleDbDataReader.Read())
            {
                temp = new ProductTemperature(
                    Convert.ToInt32(oleDbDataReader["id"].ToString()),
                    oleDbDataReader["instruction"].ToString(),
                    oleDbDataReader["duration"].ToString(),
                    oleDbDataReader["temperature"].ToString(),
                    Convert.ToInt32(oleDbDataReader["state"].ToString()));
            }
            return temp;
        }

        private List<ProductCategory> getProductCategorys(OleDbDataReader oleDbDataReader)
        {
            List<ProductCategory> categorys = new List<ProductCategory>();
            while (true)
            {
                ProductCategory category = getProductCategory(oleDbDataReader);
                if (category != null)
                    categorys.Add(category);
                else
                    break;
            }
            return categorys;
        }

        private ProductCategory getProductCategory(OleDbDataReader oleDbDataReader)
        {
            ProductCategory category = null;
            if (oleDbDataReader.Read())
            {
                category = new ProductCategory(
                    oleDbDataReader["id"].ToString(),
                    oleDbDataReader["pcName"].ToString(),
                    oleDbDataReader["pcNickname"].ToString(),
                    oleDbDataReader["category"].ToString(),
                    oleDbDataReader["remark"].ToString(),
                    oleDbDataReader["imageUrl"].ToString());
            }
            return category;
        }

        public void deleteProduct(String productId)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("delete from ProductCategory where productId='{0}'", productId);
            oleDbCommand.ExecuteNonQuery();
        }

        public void deleteTemperature(String productId, int tempIndex)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("UPDATE ProductTemp SET state=1 WHERE productId='{0}' AND [id]={1}", productId, tempIndex);
            oleDbCommand.ExecuteNonQuery();
        }

        public ProductCategory findProductCategoryById(String productId)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("SELECT * from ProductCategory where id='{0}'", productId);
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            return getProductCategory(oleDbDataReader);
        }
        public bool insertProductCategory(ProductCategory productCategory)
        {
            try
            {
                OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
                oleDbCommand.CommandText = String.Format("INSERT INTO ProductCategory(id,pcName,pcNickname,category,remark,imageUrl) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
                    productCategory.id,
                    productCategory.name,
                    productCategory.nicknames,
                    productCategory.category,
                    productCategory.remark,
                    productCategory.imageUrl);
                oleDbCommand.ExecuteNonQuery();

                oleDbCommand = oleDbConnection.CreateCommand();
                List<ProductTemperature> temps = productCategory.getTemperatures();
                String command = "INSERT INTO ProductTemp(productId,id,instruction,duration,temperature) VALUES ";
                foreach (ProductTemperature temp in temps)
                {
                    command += String.Format("('{0}', '{1}', '{2}', '{3}', '{4}'),",
                        productCategory.id,
                        temp.id,
                        temp.instruction,
                        temp.duration,
                        temp.temperature);
                }
                command.Remove(command.Count() - 1, 1);
                Console.WriteLine(command);
                oleDbCommand.CommandText = command;
                oleDbCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool insertProductTemperature(String productId, ProductTemperature productTemperature)
        {
            try
            {
                OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
                oleDbCommand.CommandText = String.Format("INSERT INTO ProductTemp(productId,id,instruction,duration,temperature,state) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    productId, productTemperature.id, productTemperature.instruction, productTemperature.duration, productTemperature.temperature);
                oleDbCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateProductCategory(ProductCategory productCategory)
        {
            try
            {
                OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
                oleDbCommand.CommandText = String.Format("UPDATE ProductCategory SET pcName='{1}', pcNickname='{2}', category='{3}',remark='{4}' WHERE [id]={0}",
                    productCategory.id, productCategory.name, productCategory.nicknames, productCategory.category, productCategory.remark);
                oleDbCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateProductTemperature(String productId, ProductTemperature productTemperature)
        {
            try
            {
                OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
                oleDbCommand.CommandText = String.Format("UPDATE ProductTemp SET instruction='{2}', duration='{3}', temperature='{4}' WHERE [id]={0} AND productId={1}",
                    productTemperature.id, productId, productTemperature.instruction, productTemperature.duration, productTemperature.temperature);
                oleDbCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region MonitoringData

        public void insertDatas(MonitoringData data, String taskId)
        {
            try
            {
                OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
                oleDbCommand.CommandText =
                    String.Format("insert into MonitoringData values ('{0}','{1}','{2}','{3}',{4})",
                    taskId,
                    data.datetime,
                    JsonConvert.SerializeObject(data.coordinates),
                    JsonConvert.SerializeObject(data.temperature),
                    data.temperatureState);
                oleDbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public List<MonitoringData> getMonitoringDatasByTaskId(String taskId)
        {
            List<MonitoringData> datas = new List<MonitoringData>();
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("SELECT * FROM MonitoringData WHERE taskId='{0}' ORDER BY datetime", taskId);
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            while (oleDbDataReader.Read())
            {
                datas.Add(new MonitoringData(
                    oleDbDataReader["datetime"].ToString(),
                    JsonConvert.DeserializeObject<Temperature>(oleDbDataReader["temperature"].ToString()),
                    JsonConvert.DeserializeObject<List<Coordinate>>(oleDbDataReader["coordinates"].ToString()),
                    Convert.ToInt32(oleDbDataReader["temperatureState"].ToString())
                    ));
            }
            return datas;
        }

        public int getMonitoringDatasCount(String taskId)
        {
            int count = 0;
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("select count(*) as dataCount from MonitoringData where taskId='{0}'", taskId);
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            while (oleDbDataReader.Read())
            {
                count = Convert.ToInt32(oleDbDataReader["dataCount"].ToString());
            }
            return count;
        }

        public List<MonitoringData> getMonitoringDatasAfterDatetime(String taskId, String datetime)
        {
            List<MonitoringData> messages = new List<MonitoringData>();
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("SELECT * FROM MonitoringData WHERE taskId='{0}' AND datetime>#{1}# ORDER BY datetime", taskId, datetime);
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            while (oleDbDataReader.Read())
            {
                messages.Add(new MonitoringData(
                    oleDbDataReader["datetime"].ToString(),
                    JsonConvert.DeserializeObject<Temperature>(oleDbDataReader["temperature"].ToString()),
                    JsonConvert.DeserializeObject<List<Coordinate>>(oleDbDataReader["coordinates"].ToString()),
                    Convert.ToInt32(oleDbDataReader["temperatureState"].ToString())
                    ));
            }
            return messages;
        }

        public DateTime findLastMonitoringDataDatetime(String taskId)
        {
            DateTime lastMessageDatetime = new DateTime();
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = String.Format("SELECT Max(datetime) AS lastDatetime FROM MonitoringData WHERE(((Message.[taskId]) = {0}));", taskId);
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            while (oleDbDataReader.Read())
            {
                lastMessageDatetime = Convert.ToDateTime(oleDbDataReader["lastDatetime"].ToString());
            }
            return lastMessageDatetime;
        }
        #endregion


    }
}
