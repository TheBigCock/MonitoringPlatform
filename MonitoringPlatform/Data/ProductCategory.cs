using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MonitoringPlatform
{
    [DataContract]
    public class ProductCategory
    {
        [DataMember]
        public String id { set; get; }// ID
        [DataMember]
        public String name { set; get; }// 名称
        [DataMember]
        public String nicknames { set; get; }// 别名
        [DataMember]
        public String category { set; get; }// 分类
        [DataMember]
        public String remark { set; get; }// 注意事项
        [DataMember]
        public String imageUrl { set; get; }// icon地址
        [DataMember]
        private List<ProductTemperature> temperatures { set; get; }// 存储温度

        public ProductCategory(String productId, String productName, String nicknames, String category, String remark, String imageUrl)
        {
            this.id = productId;
            this.name = productName;
            this.nicknames = nicknames;
            this.category = category;
            this.remark = remark;
            this.imageUrl = imageUrl;
        }

        public List<ProductTemperature> getTemperatures()
        {
            if (temperatures == null)
                temperatures = DbOperation.Instance.getProductTemperatures(id);
            return temperatures;
        }

        public List<ProductTemperature> getAvailableTemperatures()
        {
            return DbOperation.Instance.getProductTemperatures(id, 0);
        }

        public ProductTemperature getTemperature(int index)
        {
            if (temperatures == null || temperatures.Count <= index)
                temperatures = DbOperation.Instance.getProductTemperatures(id);
            if (temperatures.Count > index)
                return temperatures[index];
            return null;
        }
    }

}
