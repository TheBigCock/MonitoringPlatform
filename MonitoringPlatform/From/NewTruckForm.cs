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
    public partial class NewTruckForm : Form
    {
        public NewTruckForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (plateNumberText.Text != "" && directorNameText.Text != "" && directorNumText.Text != "")
            {
                DbOperation.Instance.insertTruck(new Truck(null, "0","0", plateNumberText.Text, directorNameText.Text, directorNumText.Text, terminalIdText.Text));
                this.Close();
            }
            else

                MessageBox.Show("请输入完整的车辆信息", "提示", MessageBoxButtons.OK);

        }
    }
}
