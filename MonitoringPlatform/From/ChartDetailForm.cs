using MonitoringPlatform.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace MonitoringPlatform
{
    public partial class ChartDetailForm : Form
    {
        private Task task;

        public ChartDetailForm(Task task)
        {
            InitializeComponent();

            this.task = task;
            drawHistoryChart();
            showAlarmList();
        }

        void drawHistoryChart()
        {
            historyTemperatureChart.Series[0].Points.Clear();
            foreach (MonitoringData data in task.getDatas())
            {
                DateTime datetime = Convert.ToDateTime(data.datetime);
                historyTemperatureChart.Series[0].Points.AddXY(datetime.ToString("HH:mm"), data.temperature.getMeanTemperature());
                DataPoint dataPoint = historyTemperatureChart.Series[0].Points[historyTemperatureChart.Series[0].Points.Count - 1];
                Double[] temperatureRange = task.product.getProductCategory().getTemperature(task.product.temperatureId).getTemperatureRange();
                if (dataPoint.YValues[0] > temperatureRange[1] || dataPoint.YValues[0] < temperatureRange[0])
                {
                    dataPoint.Color = Color.Red;
                    dataPoint.LabelForeColor = Color.Red;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void showAlarmList()
        {
            if (task.temperatureAlarms != null && task.temperatureAlarms.Count > 0)
            {
                DataTable alarmTable = new DataTable();
                alarmTable.Columns.Add("序号");
                alarmTable.Columns.Add("时间");
                alarmTable.Columns.Add("类型");
                alarmTable.Columns.Add("状态");
                int i = 0;
                foreach (Task.TemperatureAlarm alarm in task.temperatureAlarms)
                {
                    DataRow newRow = alarmTable.NewRow();
                    newRow[0] = i++;
                    newRow[1] = task.getDatas()[alarm.errorTemperatureIndex.First()].datetime;
                    newRow[2] = alarm.errorType == Task.TemperatureAlarm.ErrorType.NodeError ? "温度传感节点异常" : "车内平均温度异常";
                    newRow[3] = alarm.state == Task.TemperatureAlarm.State.Resolved ? "已解决" : "未解决";
                    alarmTable.Rows.Add(newRow);
                }
                alarmDataView.DataSource = alarmTable;
            }
            else
            {
                label2.Visible = true;
            }
        }
    }
}
