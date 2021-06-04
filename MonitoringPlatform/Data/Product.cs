using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringPlatform
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public String id { set; get; }// 产品ID
        [DataMember]
        public int temperatureId { set; get; }// 温度ID
        [DataMember]
        public float quantity { set; get; }// 数量
        [DataMember]
        public String unit { set; get; }// 单位
        [DataMember]
        public Coordinate placeOfProduction { set; get; }// 产地
        [DataMember]
        public String dateOfProduction { set; get; }// 生产日期

        private ProductCategory productCategory;

        public ProductCategory getProductCategory()
        {
            if (productCategory == null)
                this.productCategory = DbOperation.Instance.findProductCategoryById(id);
            return productCategory;
        }

        public Product(String productId, int temperatureId, float quantity, String unit, Coordinate placeOfProduction, String dateOfProduction)
        {
            this.id = productId;
            this.temperatureId = temperatureId;
            this.quantity = quantity;
            this.unit = unit;
            this.placeOfProduction = placeOfProduction;
            this.dateOfProduction = dateOfProduction;
        }
    }

}
