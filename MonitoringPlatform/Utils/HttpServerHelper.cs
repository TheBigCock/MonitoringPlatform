using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlatform.Utils
{
    class HttpServerHelper
    {
        private WebServiceHost _serviceHost;

        public HttpServerHelper()
        {

        }

        public void Start()
        {
            try
            {
                HttpServices service = new HttpServices();
                Uri baseAddress = new Uri("http://172.18.18.35:8080/");
                _serviceHost = new WebServiceHost(service, baseAddress);//或者：WebServiceHost _serviceHost = new WebServiceHost(typeof(PersonInfoQueryServices), baseAddress);

                //如果不设置MaxBufferSize,当传输的数据特别大的时候，很容易出现“提示: 413 Request Entity Too Large”错误信息,最大设置为20M
                WebHttpBinding binding = new WebHttpBinding
                {
                    TransferMode = TransferMode.Buffered,
                    MaxBufferSize = 2147483647,
                    MaxReceivedMessageSize = 2147483647,
                    MaxBufferPoolSize = 2147483647,
                    ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max,
                    Security = { Mode = WebHttpSecurityMode.None }
                };
                _serviceHost.Open();
                Console.WriteLine("Web服务已开启...");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Web服务开启失败：{0}\r\n{1}", ex.Message, ex.StackTrace);
            }
        }

        public void Stop()
        {
            if (_serviceHost != null)
                _serviceHost.Close();
        }
    }
}
