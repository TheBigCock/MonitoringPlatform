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
    public partial class StartFrom : Form
    {
        const int START_DELAY = 5;//程序开始的延迟（秒）

        public StartFrom()
        {
            InitializeComponent();
            System.Timers.Timer t = new System.Timers.Timer(START_DELAY);
            t.Elapsed += new System.Timers.ElapsedEventHandler(StartProgram);
            t.AutoReset = false;
            t.Enabled = true;
        }

        private void StartProgram(object source, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                MainForm mainForm = new MainForm(this);
                mainForm.Show();
                this.Hide();
            }));
        }
    }
}
