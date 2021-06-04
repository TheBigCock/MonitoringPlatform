using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlatform.Utils
{
    public static class StateCode
    {
        public class STATE
        {
            public int CODE;
            public string INFO;

            public STATE(int code, string info)
            {
                this.CODE = code;
                this.INFO = info;
            }
        }

        public static class HttpResponse
        {

            public static STATE OK = new STATE(0, "OK");
            public static STATE PARAMS_ERROR = new STATE(1, "参数错误");
            public static STATE OUT_OF_INDEX = new STATE(2, "请求数据超出索引");
            public static STATE INVALID_STATE_CODE = new STATE(3, "无效的状态码");
            public static STATE DATA_STORAGE_FAILURE = new STATE(4, "数据存储失败");
        }
    }
}
