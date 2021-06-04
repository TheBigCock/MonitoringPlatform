using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoringPlatform
{
    public partial class NewProductForm : Form
    {
        ProductCategory productCategory;

        public NewProductForm(ProductCategory pc)
        {
            InitializeComponent();
            this.productCategory = pc;
            this.Text += productCategory.name;

            foreach (ProductTemperature temp in productCategory.getAvailableTemperatures())
            {
                int index = temperatureDataView.Rows.Add();
                setTempItem(index, temp);
            }
        }


        int newTempRowIndex = -1;
        int modifyTempRowIndex = -1;
        ProductTemperature tempItem;

        private void tempAdd_Click(object sender, EventArgs e)
        {
            newTempRowIndex = temperatureDataView.Rows.Add();
        }

        private void tempDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("删除温度\"" + temperatureDataView.CurrentRow.Cells["TemperaturesInstruction"].Value.ToString() + "\"", "确认删除", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                DbOperation.Instance.deleteTemperature(productCategory.id, Convert.ToInt32(temperatureDataView.CurrentRow.Cells["TemperaturesId"].Value.ToString()));
            }
        }

        private void tempSure_Click(object sender, EventArgs e)
        {
            ProductTemperature newTemp = getTempItem();
            if (modifyTempRowIndex != -1)
            {
                if (newTempRowIndex == -1)
                {
                    bool success = DbOperation.Instance.updateProductTemperature(productCategory.id, newTemp);
                    if (success)
                    {
                        tempSure.Visible = false;
                        tempCancel.Visible = false;
                        MessageBox.Show("修改成功", "成功", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("请检查数据格式后重新提交修改", "失败", MessageBoxButtons.OK);
                    }
                    modifyTempRowIndex = -1;
                }
                else
                {
                    bool success = DbOperation.Instance.insertProductTemperature(productCategory.id, newTemp);
                    if (success)
                    {
                        tempSure.Visible = false;
                        tempCancel.Visible = false;
                        MessageBox.Show("添加成功", "成功", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("请检查数据格式后重新添加", "失败", MessageBoxButtons.OK);
                    }
                    modifyTempRowIndex = -1;
                    newTempRowIndex = -1;
                }
            }
        }

        private void tempCancel_Click(object sender, EventArgs e)
        {
            tempModifyState(false);
        }

        private ProductTemperature getTempItem()
        {
            String instruction = temperatureDataView.CurrentRow.Cells["TemperaturesInstruction"].Value.ToString();
            String duration = temperatureDataView.CurrentRow.Cells["TemperaturesDuration"].Value.ToString();
            String temperatureString = temperatureDataView.CurrentRow.Cells["TemperaturesTemp"].Value.ToString();
            int id = Convert.ToInt32(temperatureDataView.CurrentRow.Cells["TemperaturesId"].Value.ToString());
            ProductTemperature temperature = new ProductTemperature(id, instruction, duration, temperatureString, 0);
            return temperature;
        }

        private void setTempItem(int index, ProductTemperature temp)
        {
            temperatureDataView.Rows[index].Cells["TemperaturesInstruction"].Value = temp.instruction;
            temperatureDataView.Rows[index].Cells["TemperaturesDuration"].Value = temp.duration;
            temperatureDataView.Rows[index].Cells["TemperaturesTemp"].Value = temp.temperature;
            temperatureDataView.Rows[index].Cells["TemperaturesId"].Value = temp.id;
        }

        private void tempModifyState(bool ifModify)
        {
            temperatureDataView.ReadOnly = !ifModify;
            temperatureDataView.BeginEdit(ifModify);
            tempSure.Visible = ifModify;
            tempCancel.Visible = ifModify;

            if (!ifModify)
            {
                modifyTempRowIndex = -1;
                if (newTempRowIndex != -1)
                {
                    temperatureDataView.Rows.RemoveAt(newTempRowIndex);
                    newTempRowIndex = -1;
                }
            }

        }

        private void temperatureDataView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (modifyTempRowIndex != -1)
            {
                if (modifyTempRowIndex != e.RowIndex)
                {
                    setTempItem(modifyTempRowIndex, tempItem);
                    tempModifyState(false);
                }
            }
        }

        private void temperatureDataView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            modifyTempRowIndex = e.RowIndex;
            if (modifyTempRowIndex != newTempRowIndex)
                tempItem = getTempItem();
            tempModifyState(true);
        }
    }
}
