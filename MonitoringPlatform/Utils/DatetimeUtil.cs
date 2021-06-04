using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlatform.Utils
{
    public class DatetimeUtil
    {
        private static DatetimeUtil instance = null;
        private static readonly object padlock = new object();

        public static DatetimeUtil Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DatetimeUtil();
                    }
                }

                return instance;
            }
        }

        //显示格式
        public static String DATETIME = "yyyy-MM-dd  HH:mm:ss";
        public static String DATE_ONLY = "yyyy-MM-dd";
        public static String TIME_ONLY = "HH:mm:ss";

        public String getCurrentDatetimeString()
        {
            return DateTime.Now.ToString(DATETIME);
        }

        public String getDatetimeString(DateTime datetime)
        {
            return datetime.ToString(DATETIME);
        }

        public String getDate(String datetime)
        {
            return Convert.ToDateTime(datetime).ToString(DATE_ONLY);
        }

        public String getTime(String datetime)
        {
            return Convert.ToDateTime(datetime).ToString(TIME_ONLY);
        }

        public String formatDateTime(String datetime)
        {
            return Convert.ToDateTime(datetime).ToString(DATETIME);
        }
    }
}
