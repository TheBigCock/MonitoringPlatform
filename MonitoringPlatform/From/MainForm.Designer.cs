namespace MonitoringPlatform
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle76 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle77 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle78 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle79 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle80 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle81 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle82 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle83 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle84 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle85 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle86 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle87 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle88 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle89 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle90 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle73 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle74 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle75 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMapWeb = new System.Windows.Forms.WebBrowser();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.mainTemperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxMainMap = new System.Windows.Forms.GroupBox();
            this.mainTaskInfoMapTip = new System.Windows.Forms.Label();
            this.groupBoxMainTemperature = new System.Windows.Forms.GroupBox();
            this.line = new System.Windows.Forms.Label();
            this.mainTaskInfoAlarm = new System.Windows.Forms.GroupBox();
            this.temperatureAlert = new System.Windows.Forms.PictureBox();
            this.mainTaskInfoAlarmTips = new System.Windows.Forms.RichTextBox();
            this.mainTaskInfoTruckDriverName = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mainTaskInfoTruckPlateNum = new System.Windows.Forms.Label();
            this.mainTaskInfoTruckModel = new System.Windows.Forms.Label();
            this.mainTaskInfoTruckLoad = new System.Windows.Forms.Label();
            this.directorNameLabel = new System.Windows.Forms.Label();
            this.mainTaskInfoTruckPhoneNum = new System.Windows.Forms.Label();
            this.mainTaskInfoProduct = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelProductInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.mainTaskInfoProductName = new System.Windows.Forms.Label();
            this.mainTaskInfoProductNum = new System.Windows.Forms.Label();
            this.mainTaskInfoProductPlace = new System.Windows.Forms.Label();
            this.mainTaskInfoProductDate = new System.Windows.Forms.Label();
            this.mainTaskInfoProductTemp = new System.Windows.Forms.Label();
            this.mainTaskInfoProductStartDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加车辆信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车辆信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.产品信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.驾驶员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.模拟一次任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止一次任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureChange = new System.Windows.Forms.ToolStripMenuItem();
            this.homeTabControl = new System.Windows.Forms.TabControl();
            this.tabMainTask = new System.Windows.Forms.TabPage();
            this.panelMainTask = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMainTaskInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMainTaskList = new System.Windows.Forms.Panel();
            this.mainTaskList = new System.Windows.Forms.DataGridView();
            this.plateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginDatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMainAll = new System.Windows.Forms.Panel();
            this.webBrowserMainAll = new System.Windows.Forms.WebBrowser();
            this.labelAllMapLoadTip = new System.Windows.Forms.Label();
            this.historyTab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.historySearchTextBox = new System.Windows.Forms.TextBox();
            this.historySearchButton = new System.Windows.Forms.PictureBox();
            this.historyTaskList = new System.Windows.Forms.DataGridView();
            this.panelHistoryTask = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHistoryTaskInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.historyTaskInfo = new System.Windows.Forms.GroupBox();
            this.historyEndDatetimeLabel = new System.Windows.Forms.Label();
            this.historyBeginDatetimeLabel = new System.Windows.Forms.Label();
            this.historyProductTemperatureLabel = new System.Windows.Forms.Label();
            this.historyProductNameLabel = new System.Windows.Forms.Label();
            this.historyTruckInfo = new System.Windows.Forms.GroupBox();
            this.historyDirectorNumLabel = new System.Windows.Forms.Label();
            this.historyDirectorNameLabel = new System.Windows.Forms.Label();
            this.historyPlateNumLabel = new System.Windows.Forms.Label();
            this.historyTemperatureGroupBox = new System.Windows.Forms.GroupBox();
            this.ChartDetail = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.historyTemperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.historyMapGroupBox = new System.Windows.Forms.GroupBox();
            this.historyMapWeb = new System.Windows.Forms.WebBrowser();
            this.label4 = new System.Windows.Forms.Label();
            this.infoTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.truckAdd = new System.Windows.Forms.PictureBox();
            this.truckDelete = new System.Windows.Forms.PictureBox();
            this.truckModify = new System.Windows.Forms.PictureBox();
            this.truckCancel = new System.Windows.Forms.PictureBox();
            this.truckDataView = new System.Windows.Forms.DataGridView();
            this.TruckPlateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TruckModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TruckLoad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TruckState = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TruckID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.userAdd = new System.Windows.Forms.PictureBox();
            this.userDelete = new System.Windows.Forms.PictureBox();
            this.userSure = new System.Windows.Forms.PictureBox();
            this.userCancel = new System.Windows.Forms.PictureBox();
            this.userDataView = new System.Windows.Forms.DataGridView();
            this.UserInfoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserInfoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserInfoNickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserInfoSex = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UserInfoPhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserInfoIdNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserInfoType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UserInfoPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.productAdd = new System.Windows.Forms.PictureBox();
            this.productDelete = new System.Windows.Forms.PictureBox();
            this.productSure = new System.Windows.Forms.PictureBox();
            this.productCancel = new System.Windows.Forms.PictureBox();
            this.productDataView = new System.Windows.Forms.DataGridView();
            this.ProductInfoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductInfoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductInfoNickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductInfoCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductInfoRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductInfoTemperatures = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataViewInfoInfo = new System.Windows.Forms.DataGridView();
            this.panelInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.labelMenuInfo = new System.Windows.Forms.Label();
            this.pictureMenuInfo = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.labelMenuHistory = new System.Windows.Forms.Label();
            this.pictureMenuHistory = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelAll = new System.Windows.Forms.FlowLayoutPanel();
            this.labelMenuAll = new System.Windows.Forms.Label();
            this.pictureMenuAll = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mainTemperatureChart)).BeginInit();
            this.groupBoxMainMap.SuspendLayout();
            this.groupBoxMainTemperature.SuspendLayout();
            this.mainTaskInfoAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureAlert)).BeginInit();
            this.mainTaskInfoTruckDriverName.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.mainTaskInfoProduct.SuspendLayout();
            this.flowLayoutPanelProductInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.homeTabControl.SuspendLayout();
            this.tabMainTask.SuspendLayout();
            this.panelMainTask.SuspendLayout();
            this.panelMainTaskInfo.SuspendLayout();
            this.panelMainTaskList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTaskList)).BeginInit();
            this.panelMainAll.SuspendLayout();
            this.historyTab.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historySearchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyTaskList)).BeginInit();
            this.panelHistoryTask.SuspendLayout();
            this.panelHistoryTaskInfo.SuspendLayout();
            this.historyTaskInfo.SuspendLayout();
            this.historyTruckInfo.SuspendLayout();
            this.historyTemperatureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyTemperatureChart)).BeginInit();
            this.historyMapGroupBox.SuspendLayout();
            this.infoTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truckAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckModify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckDataView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewInfoInfo)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.flowLayoutPanelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenuInfo)).BeginInit();
            this.flowLayoutPanelHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenuHistory)).BeginInit();
            this.flowLayoutPanelAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenuAll)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMapWeb
            // 
            this.mainMapWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMapWeb.Location = new System.Drawing.Point(3, 17);
            this.mainMapWeb.MinimumSize = new System.Drawing.Size(20, 20);
            this.mainMapWeb.Name = "mainMapWeb";
            this.mainMapWeb.Size = new System.Drawing.Size(686, 696);
            this.mainMapWeb.TabIndex = 0;
            this.mainMapWeb.Visible = false;
            this.mainMapWeb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser4Map_DocumentCompleted);
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.temperatureLabel.Location = new System.Drawing.Point(19, 31);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(89, 12);
            this.temperatureLabel.TabIndex = 1;
            this.temperatureLabel.Text = "当前车内温度：";
            // 
            // mainTemperatureChart
            // 
            this.mainTemperatureChart.BackColor = System.Drawing.Color.Transparent;
            chartArea9.AxisX.Interval = 1D;
            chartArea9.AxisX.IsLabelAutoFit = false;
            chartArea9.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea9.AxisX.MajorGrid.Enabled = false;
            chartArea9.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea9.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea9.AxisX.ScaleView.Position = 0D;
            chartArea9.AxisX.ScaleView.Size = 8D;
            chartArea9.AxisX.ScrollBar.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea9.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.WhiteSmoke;
            chartArea9.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea9.AxisX.Title = "时间";
            chartArea9.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea9.AxisY.IsLabelAutoFit = false;
            chartArea9.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea9.AxisY.MajorGrid.Enabled = false;
            chartArea9.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea9.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea9.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea9.AxisY.Title = "温度";
            chartArea9.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea9.BackColor = System.Drawing.Color.Transparent;
            chartArea9.Name = "ChartArea";
            this.mainTemperatureChart.ChartAreas.Add(chartArea9);
            this.mainTemperatureChart.Location = new System.Drawing.Point(6, 67);
            this.mainTemperatureChart.Name = "mainTemperatureChart";
            series9.ChartArea = "ChartArea";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series9.IsValueShownAsLabel = true;
            series9.Label = "#VAL";
            series9.LabelForeColor = System.Drawing.Color.SteelBlue;
            series9.LabelToolTip = "#VAL℃/#VALX";
            series9.Name = "TemperatureChange";
            series9.SmartLabelStyle.CalloutBackColor = System.Drawing.SystemColors.Control;
            this.mainTemperatureChart.Series.Add(series9);
            this.mainTemperatureChart.Size = new System.Drawing.Size(688, 179);
            this.mainTemperatureChart.TabIndex = 4;
            // 
            // groupBoxMainMap
            // 
            this.groupBoxMainMap.Controls.Add(this.mainTaskInfoMapTip);
            this.groupBoxMainMap.Controls.Add(this.mainMapWeb);
            this.groupBoxMainMap.Location = new System.Drawing.Point(3, 607);
            this.groupBoxMainMap.Name = "groupBoxMainMap";
            this.groupBoxMainMap.Size = new System.Drawing.Size(692, 716);
            this.groupBoxMainMap.TabIndex = 5;
            this.groupBoxMainMap.TabStop = false;
            this.groupBoxMainMap.Text = "运输线路";
            // 
            // mainTaskInfoMapTip
            // 
            this.mainTaskInfoMapTip.AutoSize = true;
            this.mainTaskInfoMapTip.Location = new System.Drawing.Point(155, 2);
            this.mainTaskInfoMapTip.Name = "mainTaskInfoMapTip";
            this.mainTaskInfoMapTip.Size = new System.Drawing.Size(401, 12);
            this.mainTaskInfoMapTip.TabIndex = 1;
            this.mainTaskInfoMapTip.Text = "GPS数据接收中，受环境影响或GPS模块损坏可能导致无法正常显示车辆定位";
            // 
            // groupBoxMainTemperature
            // 
            this.groupBoxMainTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMainTemperature.Controls.Add(this.line);
            this.groupBoxMainTemperature.Controls.Add(this.mainTemperatureChart);
            this.groupBoxMainTemperature.Controls.Add(this.temperatureLabel);
            this.groupBoxMainTemperature.Location = new System.Drawing.Point(3, 349);
            this.groupBoxMainTemperature.Name = "groupBoxMainTemperature";
            this.groupBoxMainTemperature.Size = new System.Drawing.Size(692, 252);
            this.groupBoxMainTemperature.TabIndex = 6;
            this.groupBoxMainTemperature.TabStop = false;
            this.groupBoxMainTemperature.Text = "车内温度";
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.line.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.line.Location = new System.Drawing.Point(19, 52);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(653, 12);
            this.line.TabIndex = 5;
            this.line.Text = "——————————————————————————————————————————————————————";
            // 
            // mainTaskInfoAlarm
            // 
            this.mainTaskInfoAlarm.Controls.Add(this.temperatureAlert);
            this.mainTaskInfoAlarm.Controls.Add(this.mainTaskInfoAlarmTips);
            this.mainTaskInfoAlarm.Location = new System.Drawing.Point(471, 3);
            this.mainTaskInfoAlarm.Name = "mainTaskInfoAlarm";
            this.mainTaskInfoAlarm.Size = new System.Drawing.Size(218, 334);
            this.mainTaskInfoAlarm.TabIndex = 9;
            this.mainTaskInfoAlarm.TabStop = false;
            this.mainTaskInfoAlarm.Text = "温度警报";
            // 
            // temperatureAlert
            // 
            this.temperatureAlert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("temperatureAlert.BackgroundImage")));
            this.temperatureAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.temperatureAlert.Location = new System.Drawing.Point(179, 277);
            this.temperatureAlert.Name = "temperatureAlert";
            this.temperatureAlert.Size = new System.Drawing.Size(33, 33);
            this.temperatureAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.temperatureAlert.TabIndex = 1;
            this.temperatureAlert.TabStop = false;
            this.temperatureAlert.Visible = false;
            this.temperatureAlert.Click += new System.EventHandler(this.temperatureAlert_Click);
            // 
            // mainTaskInfoAlarmTips
            // 
            this.mainTaskInfoAlarmTips.BackColor = System.Drawing.Color.White;
            this.mainTaskInfoAlarmTips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTaskInfoAlarmTips.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mainTaskInfoAlarmTips.ForeColor = System.Drawing.Color.Black;
            this.mainTaskInfoAlarmTips.Location = new System.Drawing.Point(21, 36);
            this.mainTaskInfoAlarmTips.Name = "mainTaskInfoAlarmTips";
            this.mainTaskInfoAlarmTips.ReadOnly = true;
            this.mainTaskInfoAlarmTips.Size = new System.Drawing.Size(180, 43);
            this.mainTaskInfoAlarmTips.TabIndex = 0;
            this.mainTaskInfoAlarmTips.Text = "";
            // 
            // mainTaskInfoTruckDriverName
            // 
            this.mainTaskInfoTruckDriverName.Controls.Add(this.flowLayoutPanel1);
            this.mainTaskInfoTruckDriverName.Location = new System.Drawing.Point(237, 3);
            this.mainTaskInfoTruckDriverName.Name = "mainTaskInfoTruckDriverName";
            this.mainTaskInfoTruckDriverName.Size = new System.Drawing.Size(228, 334);
            this.mainTaskInfoTruckDriverName.TabIndex = 8;
            this.mainTaskInfoTruckDriverName.TabStop = false;
            this.mainTaskInfoTruckDriverName.Text = "车辆信息";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.mainTaskInfoTruckPlateNum);
            this.flowLayoutPanel1.Controls.Add(this.mainTaskInfoTruckModel);
            this.flowLayoutPanel1.Controls.Add(this.mainTaskInfoTruckLoad);
            this.flowLayoutPanel1.Controls.Add(this.directorNameLabel);
            this.flowLayoutPanel1.Controls.Add(this.mainTaskInfoTruckPhoneNum);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(24, 32, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(222, 314);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // mainTaskInfoTruckPlateNum
            // 
            this.mainTaskInfoTruckPlateNum.AutoSize = true;
            this.mainTaskInfoTruckPlateNum.Location = new System.Drawing.Point(27, 32);
            this.mainTaskInfoTruckPlateNum.Name = "mainTaskInfoTruckPlateNum";
            this.mainTaskInfoTruckPlateNum.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.mainTaskInfoTruckPlateNum.Size = new System.Drawing.Size(53, 28);
            this.mainTaskInfoTruckPlateNum.TabIndex = 2;
            this.mainTaskInfoTruckPlateNum.Text = "车牌号：";
            // 
            // mainTaskInfoTruckModel
            // 
            this.mainTaskInfoTruckModel.AutoSize = true;
            this.mainTaskInfoTruckModel.Location = new System.Drawing.Point(27, 60);
            this.mainTaskInfoTruckModel.Name = "mainTaskInfoTruckModel";
            this.mainTaskInfoTruckModel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.mainTaskInfoTruckModel.Size = new System.Drawing.Size(41, 28);
            this.mainTaskInfoTruckModel.TabIndex = 5;
            this.mainTaskInfoTruckModel.Text = "车型：";
            // 
            // mainTaskInfoTruckLoad
            // 
            this.mainTaskInfoTruckLoad.AutoSize = true;
            this.mainTaskInfoTruckLoad.Location = new System.Drawing.Point(27, 88);
            this.mainTaskInfoTruckLoad.Name = "mainTaskInfoTruckLoad";
            this.mainTaskInfoTruckLoad.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.mainTaskInfoTruckLoad.Size = new System.Drawing.Size(41, 28);
            this.mainTaskInfoTruckLoad.TabIndex = 6;
            this.mainTaskInfoTruckLoad.Text = "载重：";
            // 
            // directorNameLabel
            // 
            this.directorNameLabel.AutoSize = true;
            this.directorNameLabel.Location = new System.Drawing.Point(27, 116);
            this.directorNameLabel.Name = "directorNameLabel";
            this.directorNameLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.directorNameLabel.Size = new System.Drawing.Size(77, 28);
            this.directorNameLabel.TabIndex = 3;
            this.directorNameLabel.Text = "负责人姓名：";
            // 
            // mainTaskInfoTruckPhoneNum
            // 
            this.mainTaskInfoTruckPhoneNum.AutoSize = true;
            this.mainTaskInfoTruckPhoneNum.Location = new System.Drawing.Point(27, 144);
            this.mainTaskInfoTruckPhoneNum.Name = "mainTaskInfoTruckPhoneNum";
            this.mainTaskInfoTruckPhoneNum.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.mainTaskInfoTruckPhoneNum.Size = new System.Drawing.Size(77, 28);
            this.mainTaskInfoTruckPhoneNum.TabIndex = 4;
            this.mainTaskInfoTruckPhoneNum.Text = "负责人手机：";
            // 
            // mainTaskInfoProduct
            // 
            this.mainTaskInfoProduct.Controls.Add(this.flowLayoutPanelProductInfo);
            this.mainTaskInfoProduct.Controls.Add(this.label6);
            this.mainTaskInfoProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTaskInfoProduct.Location = new System.Drawing.Point(3, 3);
            this.mainTaskInfoProduct.Name = "mainTaskInfoProduct";
            this.mainTaskInfoProduct.Size = new System.Drawing.Size(228, 334);
            this.mainTaskInfoProduct.TabIndex = 7;
            this.mainTaskInfoProduct.TabStop = false;
            this.mainTaskInfoProduct.Text = "产品信息";
            // 
            // flowLayoutPanelProductInfo
            // 
            this.flowLayoutPanelProductInfo.Controls.Add(this.mainTaskInfoProductName);
            this.flowLayoutPanelProductInfo.Controls.Add(this.mainTaskInfoProductNum);
            this.flowLayoutPanelProductInfo.Controls.Add(this.mainTaskInfoProductPlace);
            this.flowLayoutPanelProductInfo.Controls.Add(this.mainTaskInfoProductDate);
            this.flowLayoutPanelProductInfo.Controls.Add(this.mainTaskInfoProductTemp);
            this.flowLayoutPanelProductInfo.Controls.Add(this.mainTaskInfoProductStartDate);
            this.flowLayoutPanelProductInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelProductInfo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelProductInfo.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanelProductInfo.Name = "flowLayoutPanelProductInfo";
            this.flowLayoutPanelProductInfo.Padding = new System.Windows.Forms.Padding(24, 32, 0, 0);
            this.flowLayoutPanelProductInfo.Size = new System.Drawing.Size(222, 314);
            this.flowLayoutPanelProductInfo.TabIndex = 5;
            // 
            // mainTaskInfoProductName
            // 
            this.mainTaskInfoProductName.AutoSize = true;
            this.mainTaskInfoProductName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTaskInfoProductName.Location = new System.Drawing.Point(27, 32);
            this.mainTaskInfoProductName.Name = "mainTaskInfoProductName";
            this.mainTaskInfoProductName.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.mainTaskInfoProductName.Size = new System.Drawing.Size(53, 28);
            this.mainTaskInfoProductName.TabIndex = 0;
            this.mainTaskInfoProductName.Text = "产品名：";
            // 
            // mainTaskInfoProductNum
            // 
            this.mainTaskInfoProductNum.AutoSize = true;
            this.mainTaskInfoProductNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTaskInfoProductNum.Location = new System.Drawing.Point(27, 60);
            this.mainTaskInfoProductNum.Name = "mainTaskInfoProductNum";
            this.mainTaskInfoProductNum.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.mainTaskInfoProductNum.Size = new System.Drawing.Size(65, 28);
            this.mainTaskInfoProductNum.TabIndex = 4;
            this.mainTaskInfoProductNum.Text = "产品数量：";
            // 
            // mainTaskInfoProductPlace
            // 
            this.mainTaskInfoProductPlace.AutoSize = true;
            this.mainTaskInfoProductPlace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTaskInfoProductPlace.Location = new System.Drawing.Point(27, 88);
            this.mainTaskInfoProductPlace.Name = "mainTaskInfoProductPlace";
            this.mainTaskInfoProductPlace.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.mainTaskInfoProductPlace.Size = new System.Drawing.Size(41, 28);
            this.mainTaskInfoProductPlace.TabIndex = 5;
            this.mainTaskInfoProductPlace.Text = "产地：";
            // 
            // mainTaskInfoProductDate
            // 
            this.mainTaskInfoProductDate.AutoSize = true;
            this.mainTaskInfoProductDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTaskInfoProductDate.Location = new System.Drawing.Point(27, 116);
            this.mainTaskInfoProductDate.Name = "mainTaskInfoProductDate";
            this.mainTaskInfoProductDate.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.mainTaskInfoProductDate.Size = new System.Drawing.Size(65, 28);
            this.mainTaskInfoProductDate.TabIndex = 6;
            this.mainTaskInfoProductDate.Text = "生产日期：";
            // 
            // mainTaskInfoProductTemp
            // 
            this.mainTaskInfoProductTemp.AutoSize = true;
            this.mainTaskInfoProductTemp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTaskInfoProductTemp.Location = new System.Drawing.Point(27, 144);
            this.mainTaskInfoProductTemp.Name = "mainTaskInfoProductTemp";
            this.mainTaskInfoProductTemp.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.mainTaskInfoProductTemp.Size = new System.Drawing.Size(89, 28);
            this.mainTaskInfoProductTemp.TabIndex = 1;
            this.mainTaskInfoProductTemp.Text = "适宜运输温度：";
            // 
            // mainTaskInfoProductStartDate
            // 
            this.mainTaskInfoProductStartDate.AutoSize = true;
            this.mainTaskInfoProductStartDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTaskInfoProductStartDate.Location = new System.Drawing.Point(27, 172);
            this.mainTaskInfoProductStartDate.Name = "mainTaskInfoProductStartDate";
            this.mainTaskInfoProductStartDate.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.mainTaskInfoProductStartDate.Size = new System.Drawing.Size(89, 28);
            this.mainTaskInfoProductStartDate.TabIndex = 2;
            this.mainTaskInfoProductStartDate.Text = "运输开始时间：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加车辆信息ToolStripMenuItem,
            this.模拟一次任务ToolStripMenuItem,
            this.停止一次任务ToolStripMenuItem,
            this.temperatureChange});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // 添加车辆信息ToolStripMenuItem
            // 
            this.添加车辆信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.车辆信息ToolStripMenuItem,
            this.产品信息ToolStripMenuItem,
            this.驾驶员信息ToolStripMenuItem});
            this.添加车辆信息ToolStripMenuItem.Name = "添加车辆信息ToolStripMenuItem";
            this.添加车辆信息ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.添加车辆信息ToolStripMenuItem.Text = "添加";
            // 
            // 车辆信息ToolStripMenuItem
            // 
            this.车辆信息ToolStripMenuItem.Name = "车辆信息ToolStripMenuItem";
            this.车辆信息ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.车辆信息ToolStripMenuItem.Text = "车辆信息";
            this.车辆信息ToolStripMenuItem.Click += new System.EventHandler(this.车辆信息ToolStripMenuItem_Click);
            // 
            // 产品信息ToolStripMenuItem
            // 
            this.产品信息ToolStripMenuItem.Name = "产品信息ToolStripMenuItem";
            this.产品信息ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.产品信息ToolStripMenuItem.Text = "产品信息";
            this.产品信息ToolStripMenuItem.Click += new System.EventHandler(this.产品信息ToolStripMenuItem_Click);
            // 
            // 驾驶员信息ToolStripMenuItem
            // 
            this.驾驶员信息ToolStripMenuItem.Name = "驾驶员信息ToolStripMenuItem";
            this.驾驶员信息ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.驾驶员信息ToolStripMenuItem.Text = "驾驶员信息";
            this.驾驶员信息ToolStripMenuItem.Click += new System.EventHandler(this.驾驶员信息ToolStripMenuItem_Click);
            // 
            // 模拟一次任务ToolStripMenuItem
            // 
            this.模拟一次任务ToolStripMenuItem.Name = "模拟一次任务ToolStripMenuItem";
            this.模拟一次任务ToolStripMenuItem.ShortcutKeyDisplayString = "(Ctrl+S)";
            this.模拟一次任务ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.模拟一次任务ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.模拟一次任务ToolStripMenuItem.Text = "模拟一次任务";
            this.模拟一次任务ToolStripMenuItem.Click += new System.EventHandler(this.模拟一次任务ToolStripMenuItem_Click);
            // 
            // 停止一次任务ToolStripMenuItem
            // 
            this.停止一次任务ToolStripMenuItem.Name = "停止一次任务ToolStripMenuItem";
            this.停止一次任务ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.停止一次任务ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.停止一次任务ToolStripMenuItem.Text = "停止一次任务";
            this.停止一次任务ToolStripMenuItem.Click += new System.EventHandler(this.停止一次任务ToolStripMenuItem_Click);
            // 
            // temperatureChange
            // 
            this.temperatureChange.Name = "temperatureChange";
            this.temperatureChange.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.temperatureChange.Size = new System.Drawing.Size(116, 21);
            this.temperatureChange.Text = "添加一次异常温度";
            this.temperatureChange.Click += new System.EventHandler(this.temperatureChange_Click);
            // 
            // homeTabControl
            // 
            this.homeTabControl.Controls.Add(this.tabMainTask);
            this.homeTabControl.Controls.Add(this.historyTab);
            this.homeTabControl.Controls.Add(this.infoTab);
            this.homeTabControl.Location = new System.Drawing.Point(0, -20);
            this.homeTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.homeTabControl.Name = "homeTabControl";
            this.homeTabControl.SelectedIndex = 0;
            this.homeTabControl.Size = new System.Drawing.Size(978, 680);
            this.homeTabControl.TabIndex = 12;
            this.homeTabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabMainTask
            // 
            this.tabMainTask.Controls.Add(this.panelMainTask);
            this.tabMainTask.Controls.Add(this.panelMainTaskList);
            this.tabMainTask.Controls.Add(this.panelMainAll);
            this.tabMainTask.Location = new System.Drawing.Point(4, 22);
            this.tabMainTask.Name = "tabMainTask";
            this.tabMainTask.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainTask.Size = new System.Drawing.Size(970, 654);
            this.tabMainTask.TabIndex = 0;
            this.tabMainTask.Text = "正在运行的任务";
            this.tabMainTask.UseVisualStyleBackColor = true;
            // 
            // panelMainTask
            // 
            this.panelMainTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainTask.AutoScroll = true;
            this.panelMainTask.Controls.Add(this.panelMainTaskInfo);
            this.panelMainTask.Controls.Add(this.groupBoxMainTemperature);
            this.panelMainTask.Controls.Add(this.groupBoxMainMap);
            this.panelMainTask.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelMainTask.Location = new System.Drawing.Point(251, 0);
            this.panelMainTask.Margin = new System.Windows.Forms.Padding(0);
            this.panelMainTask.Name = "panelMainTask";
            this.panelMainTask.Size = new System.Drawing.Size(716, 640);
            this.panelMainTask.TabIndex = 4;
            this.panelMainTask.WrapContents = false;
            // 
            // panelMainTaskInfo
            // 
            this.panelMainTaskInfo.Controls.Add(this.mainTaskInfoProduct);
            this.panelMainTaskInfo.Controls.Add(this.mainTaskInfoTruckDriverName);
            this.panelMainTaskInfo.Controls.Add(this.mainTaskInfoAlarm);
            this.panelMainTaskInfo.Location = new System.Drawing.Point(3, 3);
            this.panelMainTaskInfo.Name = "panelMainTaskInfo";
            this.panelMainTaskInfo.Size = new System.Drawing.Size(692, 340);
            this.panelMainTaskInfo.TabIndex = 0;
            // 
            // panelMainTaskList
            // 
            this.panelMainTaskList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMainTaskList.Controls.Add(this.mainTaskList);
            this.panelMainTaskList.Location = new System.Drawing.Point(0, 0);
            this.panelMainTaskList.Name = "panelMainTaskList";
            this.panelMainTaskList.Size = new System.Drawing.Size(256, 648);
            this.panelMainTaskList.TabIndex = 13;
            // 
            // mainTaskList
            // 
            this.mainTaskList.AllowUserToAddRows = false;
            this.mainTaskList.AllowUserToDeleteRows = false;
            this.mainTaskList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainTaskList.BackgroundColor = System.Drawing.Color.White;
            this.mainTaskList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTaskList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle76.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle76.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle76.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle76.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle76.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle76.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle76.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainTaskList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle76;
            this.mainTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainTaskList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plateNumber,
            this.productName,
            this.beginDatetime,
            this.taskId});
            dataGridViewCellStyle77.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle77.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle77.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle77.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle77.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle77.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle77.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainTaskList.DefaultCellStyle = dataGridViewCellStyle77;
            this.mainTaskList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTaskList.GridColor = System.Drawing.SystemColors.Control;
            this.mainTaskList.Location = new System.Drawing.Point(0, 0);
            this.mainTaskList.Name = "mainTaskList";
            this.mainTaskList.ReadOnly = true;
            dataGridViewCellStyle78.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle78.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle78.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle78.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle78.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle78.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle78.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainTaskList.RowHeadersDefaultCellStyle = dataGridViewCellStyle78;
            this.mainTaskList.RowHeadersVisible = false;
            this.mainTaskList.RowTemplate.Height = 23;
            this.mainTaskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainTaskList.Size = new System.Drawing.Size(256, 648);
            this.mainTaskList.TabIndex = 12;
            this.mainTaskList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.taskDataView_CellMouseDoubleClick);
            this.mainTaskList.SelectionChanged += new System.EventHandler(this.taskDataView_SelectionChanged);
            // 
            // plateNumber
            // 
            this.plateNumber.HeaderText = "车牌号";
            this.plateNumber.Name = "plateNumber";
            this.plateNumber.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.HeaderText = "产品名";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // beginDatetime
            // 
            this.beginDatetime.HeaderText = "开始时间";
            this.beginDatetime.Name = "beginDatetime";
            this.beginDatetime.ReadOnly = true;
            // 
            // taskId
            // 
            this.taskId.HeaderText = "任务Id";
            this.taskId.Name = "taskId";
            this.taskId.ReadOnly = true;
            this.taskId.Visible = false;
            // 
            // panelMainAll
            // 
            this.panelMainAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainAll.Controls.Add(this.webBrowserMainAll);
            this.panelMainAll.Controls.Add(this.labelAllMapLoadTip);
            this.panelMainAll.Location = new System.Drawing.Point(251, 0);
            this.panelMainAll.Name = "panelMainAll";
            this.panelMainAll.Size = new System.Drawing.Size(716, 648);
            this.panelMainAll.TabIndex = 1;
            // 
            // webBrowserMainAll
            // 
            this.webBrowserMainAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMainAll.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMainAll.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMainAll.Name = "webBrowserMainAll";
            this.webBrowserMainAll.Size = new System.Drawing.Size(716, 648);
            this.webBrowserMainAll.TabIndex = 2;
            this.webBrowserMainAll.Visible = false;
            this.webBrowserMainAll.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.allWebBrowser_DocumentCompleted);
            // 
            // labelAllMapLoadTip
            // 
            this.labelAllMapLoadTip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAllMapLoadTip.AutoSize = true;
            this.labelAllMapLoadTip.Location = new System.Drawing.Point(312, 304);
            this.labelAllMapLoadTip.Margin = new System.Windows.Forms.Padding(0);
            this.labelAllMapLoadTip.Name = "labelAllMapLoadTip";
            this.labelAllMapLoadTip.Size = new System.Drawing.Size(83, 12);
            this.labelAllMapLoadTip.TabIndex = 3;
            this.labelAllMapLoadTip.Text = "地图加载中...";
            // 
            // historyTab
            // 
            this.historyTab.Controls.Add(this.flowLayoutPanel2);
            this.historyTab.Controls.Add(this.panelHistoryTask);
            this.historyTab.Location = new System.Drawing.Point(4, 22);
            this.historyTab.Name = "historyTab";
            this.historyTab.Padding = new System.Windows.Forms.Padding(3);
            this.historyTab.Size = new System.Drawing.Size(970, 654);
            this.historyTab.TabIndex = 1;
            this.historyTab.Text = "历史任务";
            this.historyTab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.historyTaskList);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(256, 648);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.historySearchTextBox);
            this.flowLayoutPanel3.Controls.Add(this.historySearchButton);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(253, 30);
            this.flowLayoutPanel3.TabIndex = 14;
            // 
            // historySearchTextBox
            // 
            this.historySearchTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.historySearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historySearchTextBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.historySearchTextBox.Location = new System.Drawing.Point(3, 3);
            this.historySearchTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.historySearchTextBox.Name = "historySearchTextBox";
            this.historySearchTextBox.Size = new System.Drawing.Size(221, 22);
            this.historySearchTextBox.TabIndex = 0;
            // 
            // historySearchButton
            // 
            this.historySearchButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.historySearchButton.BackgroundImage = global::MonitoringPlatform.Properties.Resources.search;
            this.historySearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.historySearchButton.Location = new System.Drawing.Point(224, 3);
            this.historySearchButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.historySearchButton.Name = "historySearchButton";
            this.historySearchButton.Size = new System.Drawing.Size(22, 22);
            this.historySearchButton.TabIndex = 1;
            this.historySearchButton.TabStop = false;
            this.historySearchButton.Click += new System.EventHandler(this.historySearchButton_Click);
            // 
            // historyTaskList
            // 
            this.historyTaskList.AllowUserToAddRows = false;
            this.historyTaskList.AllowUserToDeleteRows = false;
            this.historyTaskList.AllowUserToOrderColumns = true;
            this.historyTaskList.BackgroundColor = System.Drawing.Color.White;
            this.historyTaskList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyTaskList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle79.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle79.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle79.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle79.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle79.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle79.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle79.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historyTaskList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle79;
            this.historyTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle80.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle80.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle80.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle80.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle80.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle80.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle80.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.historyTaskList.DefaultCellStyle = dataGridViewCellStyle80;
            this.historyTaskList.GridColor = System.Drawing.SystemColors.Control;
            this.historyTaskList.Location = new System.Drawing.Point(3, 39);
            this.historyTaskList.Name = "historyTaskList";
            this.historyTaskList.ReadOnly = true;
            dataGridViewCellStyle81.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle81.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle81.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle81.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle81.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle81.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle81.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historyTaskList.RowHeadersDefaultCellStyle = dataGridViewCellStyle81;
            this.historyTaskList.RowHeadersVisible = false;
            this.historyTaskList.RowTemplate.Height = 23;
            this.historyTaskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historyTaskList.Size = new System.Drawing.Size(251, 593);
            this.historyTaskList.TabIndex = 13;
            this.historyTaskList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.historyDataView_CellMouseDoubleClick);
            // 
            // panelHistoryTask
            // 
            this.panelHistoryTask.AutoScroll = true;
            this.panelHistoryTask.Controls.Add(this.panelHistoryTaskInfo);
            this.panelHistoryTask.Controls.Add(this.historyTemperatureGroupBox);
            this.panelHistoryTask.Controls.Add(this.historyMapGroupBox);
            this.panelHistoryTask.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelHistoryTask.Location = new System.Drawing.Point(257, 0);
            this.panelHistoryTask.Margin = new System.Windows.Forms.Padding(0);
            this.panelHistoryTask.Name = "panelHistoryTask";
            this.panelHistoryTask.Size = new System.Drawing.Size(710, 648);
            this.panelHistoryTask.TabIndex = 15;
            this.panelHistoryTask.WrapContents = false;
            // 
            // panelHistoryTaskInfo
            // 
            this.panelHistoryTaskInfo.Controls.Add(this.historyTaskInfo);
            this.panelHistoryTaskInfo.Controls.Add(this.historyTruckInfo);
            this.panelHistoryTaskInfo.Location = new System.Drawing.Point(3, 3);
            this.panelHistoryTaskInfo.Name = "panelHistoryTaskInfo";
            this.panelHistoryTaskInfo.Size = new System.Drawing.Size(692, 340);
            this.panelHistoryTaskInfo.TabIndex = 12;
            // 
            // historyTaskInfo
            // 
            this.historyTaskInfo.Controls.Add(this.historyEndDatetimeLabel);
            this.historyTaskInfo.Controls.Add(this.historyBeginDatetimeLabel);
            this.historyTaskInfo.Controls.Add(this.historyProductTemperatureLabel);
            this.historyTaskInfo.Controls.Add(this.historyProductNameLabel);
            this.historyTaskInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.historyTaskInfo.Location = new System.Drawing.Point(3, 3);
            this.historyTaskInfo.Name = "historyTaskInfo";
            this.historyTaskInfo.Size = new System.Drawing.Size(228, 334);
            this.historyTaskInfo.TabIndex = 7;
            this.historyTaskInfo.TabStop = false;
            this.historyTaskInfo.Text = "产品信息";
            // 
            // historyEndDatetimeLabel
            // 
            this.historyEndDatetimeLabel.AutoSize = true;
            this.historyEndDatetimeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.historyEndDatetimeLabel.Location = new System.Drawing.Point(19, 138);
            this.historyEndDatetimeLabel.Name = "historyEndDatetimeLabel";
            this.historyEndDatetimeLabel.Size = new System.Drawing.Size(89, 12);
            this.historyEndDatetimeLabel.TabIndex = 3;
            this.historyEndDatetimeLabel.Text = "运输结束时间：";
            // 
            // historyBeginDatetimeLabel
            // 
            this.historyBeginDatetimeLabel.AutoSize = true;
            this.historyBeginDatetimeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.historyBeginDatetimeLabel.Location = new System.Drawing.Point(19, 105);
            this.historyBeginDatetimeLabel.Name = "historyBeginDatetimeLabel";
            this.historyBeginDatetimeLabel.Size = new System.Drawing.Size(89, 12);
            this.historyBeginDatetimeLabel.TabIndex = 2;
            this.historyBeginDatetimeLabel.Text = "运输开始时间：";
            // 
            // historyProductTemperatureLabel
            // 
            this.historyProductTemperatureLabel.AutoSize = true;
            this.historyProductTemperatureLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.historyProductTemperatureLabel.Location = new System.Drawing.Point(19, 69);
            this.historyProductTemperatureLabel.Name = "historyProductTemperatureLabel";
            this.historyProductTemperatureLabel.Size = new System.Drawing.Size(89, 12);
            this.historyProductTemperatureLabel.TabIndex = 1;
            this.historyProductTemperatureLabel.Text = "适宜运输温度：";
            // 
            // historyProductNameLabel
            // 
            this.historyProductNameLabel.AutoSize = true;
            this.historyProductNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.historyProductNameLabel.Location = new System.Drawing.Point(19, 35);
            this.historyProductNameLabel.Name = "historyProductNameLabel";
            this.historyProductNameLabel.Size = new System.Drawing.Size(53, 12);
            this.historyProductNameLabel.TabIndex = 0;
            this.historyProductNameLabel.Text = "产品名：";
            // 
            // historyTruckInfo
            // 
            this.historyTruckInfo.Controls.Add(this.historyDirectorNumLabel);
            this.historyTruckInfo.Controls.Add(this.historyDirectorNameLabel);
            this.historyTruckInfo.Controls.Add(this.historyPlateNumLabel);
            this.historyTruckInfo.Location = new System.Drawing.Point(237, 3);
            this.historyTruckInfo.Name = "historyTruckInfo";
            this.historyTruckInfo.Size = new System.Drawing.Size(228, 334);
            this.historyTruckInfo.TabIndex = 8;
            this.historyTruckInfo.TabStop = false;
            this.historyTruckInfo.Text = "车辆信息";
            // 
            // historyDirectorNumLabel
            // 
            this.historyDirectorNumLabel.AutoSize = true;
            this.historyDirectorNumLabel.Location = new System.Drawing.Point(18, 103);
            this.historyDirectorNumLabel.Name = "historyDirectorNumLabel";
            this.historyDirectorNumLabel.Size = new System.Drawing.Size(77, 12);
            this.historyDirectorNumLabel.TabIndex = 4;
            this.historyDirectorNumLabel.Text = "负责人手机：";
            // 
            // historyDirectorNameLabel
            // 
            this.historyDirectorNameLabel.AutoSize = true;
            this.historyDirectorNameLabel.Location = new System.Drawing.Point(18, 69);
            this.historyDirectorNameLabel.Name = "historyDirectorNameLabel";
            this.historyDirectorNameLabel.Size = new System.Drawing.Size(77, 12);
            this.historyDirectorNameLabel.TabIndex = 3;
            this.historyDirectorNameLabel.Text = "负责人姓名：";
            // 
            // historyPlateNumLabel
            // 
            this.historyPlateNumLabel.AutoSize = true;
            this.historyPlateNumLabel.Location = new System.Drawing.Point(18, 35);
            this.historyPlateNumLabel.Name = "historyPlateNumLabel";
            this.historyPlateNumLabel.Size = new System.Drawing.Size(53, 12);
            this.historyPlateNumLabel.TabIndex = 2;
            this.historyPlateNumLabel.Text = "车牌号：";
            // 
            // historyTemperatureGroupBox
            // 
            this.historyTemperatureGroupBox.Controls.Add(this.ChartDetail);
            this.historyTemperatureGroupBox.Controls.Add(this.label7);
            this.historyTemperatureGroupBox.Controls.Add(this.historyTemperatureChart);
            this.historyTemperatureGroupBox.Location = new System.Drawing.Point(3, 349);
            this.historyTemperatureGroupBox.Name = "historyTemperatureGroupBox";
            this.historyTemperatureGroupBox.Size = new System.Drawing.Size(692, 252);
            this.historyTemperatureGroupBox.TabIndex = 6;
            this.historyTemperatureGroupBox.TabStop = false;
            this.historyTemperatureGroupBox.Text = "车内温度";
            // 
            // ChartDetail
            // 
            this.ChartDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChartDetail.BackgroundImage")));
            this.ChartDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChartDetail.Location = new System.Drawing.Point(548, 67);
            this.ChartDetail.Name = "ChartDetail";
            this.ChartDetail.Size = new System.Drawing.Size(25, 25);
            this.ChartDetail.TabIndex = 11;
            this.ChartDetail.TabStop = false;
            this.ChartDetail.Click += new System.EventHandler(this.ChartDetail_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(19, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(581, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "————————————————————————————————————————————————";
            // 
            // historyTemperatureChart
            // 
            this.historyTemperatureChart.BackColor = System.Drawing.Color.Transparent;
            chartArea10.AxisX.IsLabelAutoFit = false;
            chartArea10.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea10.AxisX.MajorGrid.Enabled = false;
            chartArea10.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea10.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea10.AxisX.ScaleView.Position = 0D;
            chartArea10.AxisX.ScaleView.Size = 8D;
            chartArea10.AxisX.ScrollBar.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea10.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.WhiteSmoke;
            chartArea10.AxisX.Title = "时间";
            chartArea10.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea10.AxisY.IsLabelAutoFit = false;
            chartArea10.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea10.AxisY.MajorGrid.Enabled = false;
            chartArea10.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea10.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea10.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea10.AxisY.Title = "温度";
            chartArea10.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea10.BackColor = System.Drawing.Color.Transparent;
            chartArea10.Name = "ChartArea";
            this.historyTemperatureChart.ChartAreas.Add(chartArea10);
            this.historyTemperatureChart.Location = new System.Drawing.Point(6, 67);
            this.historyTemperatureChart.Name = "historyTemperatureChart";
            series10.ChartArea = "ChartArea";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series10.IsValueShownAsLabel = true;
            series10.Label = "#VAL";
            series10.LabelForeColor = System.Drawing.SystemColors.ActiveCaption;
            series10.LabelToolTip = "#VAL℃/#VALX";
            series10.Name = "TemperatureChange";
            series10.SmartLabelStyle.CalloutBackColor = System.Drawing.SystemColors.Control;
            this.historyTemperatureChart.Series.Add(series10);
            this.historyTemperatureChart.Size = new System.Drawing.Size(594, 179);
            this.historyTemperatureChart.TabIndex = 4;
            // 
            // historyMapGroupBox
            // 
            this.historyMapGroupBox.Controls.Add(this.historyMapWeb);
            this.historyMapGroupBox.Controls.Add(this.label4);
            this.historyMapGroupBox.Location = new System.Drawing.Point(3, 607);
            this.historyMapGroupBox.Name = "historyMapGroupBox";
            this.historyMapGroupBox.Size = new System.Drawing.Size(692, 716);
            this.historyMapGroupBox.TabIndex = 5;
            this.historyMapGroupBox.TabStop = false;
            this.historyMapGroupBox.Text = "运输线路";
            // 
            // historyMapWeb
            // 
            this.historyMapWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyMapWeb.Location = new System.Drawing.Point(3, 17);
            this.historyMapWeb.MinimumSize = new System.Drawing.Size(20, 20);
            this.historyMapWeb.Name = "historyMapWeb";
            this.historyMapWeb.Size = new System.Drawing.Size(686, 696);
            this.historyMapWeb.TabIndex = 0;
            this.historyMapWeb.Visible = false;
            this.historyMapWeb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.historyWebBrowser_DocumentCompleted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "地图加载中...";
            // 
            // infoTab
            // 
            this.infoTab.Controls.Add(this.dataViewInfoInfo);
            this.infoTab.Controls.Add(this.panelInfo);
            this.infoTab.Location = new System.Drawing.Point(4, 22);
            this.infoTab.Name = "infoTab";
            this.infoTab.Padding = new System.Windows.Forms.Padding(3);
            this.infoTab.Size = new System.Drawing.Size(970, 654);
            this.infoTab.TabIndex = 2;
            this.infoTab.Text = "信息管理";
            this.infoTab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(263, -20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(753, 680);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(745, 654);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel5.Controls.Add(this.truckDataView);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(739, 648);
            this.flowLayoutPanel5.TabIndex = 15;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel6.Controls.Add(this.truckAdd);
            this.flowLayoutPanel6.Controls.Add(this.truckDelete);
            this.flowLayoutPanel6.Controls.Add(this.truckModify);
            this.flowLayoutPanel6.Controls.Add(this.truckCancel);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.flowLayoutPanel6.Size = new System.Drawing.Size(739, 32);
            this.flowLayoutPanel6.TabIndex = 16;
            // 
            // truckAdd
            // 
            this.truckAdd.BackgroundImage = global::MonitoringPlatform.Properties.Resources.add;
            this.truckAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.truckAdd.Location = new System.Drawing.Point(19, 3);
            this.truckAdd.Name = "truckAdd";
            this.truckAdd.Size = new System.Drawing.Size(24, 24);
            this.truckAdd.TabIndex = 0;
            this.truckAdd.TabStop = false;
            this.truckAdd.Click += new System.EventHandler(this.truckAdd_Click);
            // 
            // truckDelete
            // 
            this.truckDelete.BackgroundImage = global::MonitoringPlatform.Properties.Resources.delete;
            this.truckDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.truckDelete.Location = new System.Drawing.Point(49, 3);
            this.truckDelete.Name = "truckDelete";
            this.truckDelete.Size = new System.Drawing.Size(24, 24);
            this.truckDelete.TabIndex = 15;
            this.truckDelete.TabStop = false;
            this.truckDelete.Click += new System.EventHandler(this.truckDelete_Click);
            // 
            // truckModify
            // 
            this.truckModify.BackgroundImage = global::MonitoringPlatform.Properties.Resources.sure;
            this.truckModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.truckModify.Location = new System.Drawing.Point(79, 3);
            this.truckModify.Name = "truckModify";
            this.truckModify.Size = new System.Drawing.Size(24, 24);
            this.truckModify.TabIndex = 16;
            this.truckModify.TabStop = false;
            this.truckModify.Visible = false;
            this.truckModify.Click += new System.EventHandler(this.truckModify_Click);
            // 
            // truckCancel
            // 
            this.truckCancel.BackgroundImage = global::MonitoringPlatform.Properties.Resources.cancel;
            this.truckCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.truckCancel.Location = new System.Drawing.Point(109, 3);
            this.truckCancel.Name = "truckCancel";
            this.truckCancel.Size = new System.Drawing.Size(24, 24);
            this.truckCancel.TabIndex = 17;
            this.truckCancel.TabStop = false;
            this.truckCancel.Visible = false;
            this.truckCancel.Click += new System.EventHandler(this.truckCancel_Click);
            // 
            // truckDataView
            // 
            this.truckDataView.AllowUserToAddRows = false;
            this.truckDataView.AllowUserToDeleteRows = false;
            this.truckDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.truckDataView.BackgroundColor = System.Drawing.Color.White;
            this.truckDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.truckDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle82.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle82.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle82.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle82.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle82.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle82.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle82.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.truckDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle82;
            this.truckDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.truckDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TruckPlateNumber,
            this.TruckModel,
            this.TruckLoad,
            this.TruckState,
            this.TruckID});
            dataGridViewCellStyle83.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle83.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle83.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle83.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle83.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle83.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle83.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.truckDataView.DefaultCellStyle = dataGridViewCellStyle83;
            this.truckDataView.GridColor = System.Drawing.SystemColors.Control;
            this.truckDataView.Location = new System.Drawing.Point(3, 41);
            this.truckDataView.Name = "truckDataView";
            this.truckDataView.ReadOnly = true;
            dataGridViewCellStyle84.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle84.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle84.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle84.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle84.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle84.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle84.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.truckDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle84;
            this.truckDataView.RowHeadersVisible = false;
            this.truckDataView.RowHeadersWidth = 40;
            this.truckDataView.RowTemplate.Height = 23;
            this.truckDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.truckDataView.Size = new System.Drawing.Size(739, 600);
            this.truckDataView.TabIndex = 14;
            this.truckDataView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.truckDataView_CellMouseClick);
            this.truckDataView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.truckDataView_CellMouseDoubleClick);
            // 
            // TruckPlateNumber
            // 
            this.TruckPlateNumber.HeaderText = "车牌号";
            this.TruckPlateNumber.Name = "TruckPlateNumber";
            this.TruckPlateNumber.ReadOnly = true;
            // 
            // TruckModel
            // 
            this.TruckModel.HeaderText = "车型";
            this.TruckModel.Name = "TruckModel";
            this.TruckModel.ReadOnly = true;
            // 
            // TruckLoad
            // 
            this.TruckLoad.HeaderText = "载重";
            this.TruckLoad.Name = "TruckLoad";
            this.TruckLoad.ReadOnly = true;
            // 
            // TruckState
            // 
            this.TruckState.HeaderText = "车辆状态";
            this.TruckState.Items.AddRange(new object[] {
            "待机中",
            "运输中",
            "检修中"});
            this.TruckState.Name = "TruckState";
            this.TruckState.ReadOnly = true;
            // 
            // TruckID
            // 
            this.TruckID.HeaderText = "车辆ID";
            this.TruckID.Name = "TruckID";
            this.TruckID.ReadOnly = true;
            this.TruckID.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(745, 654);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel7.Controls.Add(this.userDataView);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(739, 648);
            this.flowLayoutPanel7.TabIndex = 16;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel8.Controls.Add(this.userAdd);
            this.flowLayoutPanel8.Controls.Add(this.userDelete);
            this.flowLayoutPanel8.Controls.Add(this.userSure);
            this.flowLayoutPanel8.Controls.Add(this.userCancel);
            this.flowLayoutPanel8.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.flowLayoutPanel8.Size = new System.Drawing.Size(739, 32);
            this.flowLayoutPanel8.TabIndex = 17;
            // 
            // userAdd
            // 
            this.userAdd.BackgroundImage = global::MonitoringPlatform.Properties.Resources.add;
            this.userAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userAdd.Location = new System.Drawing.Point(19, 3);
            this.userAdd.Name = "userAdd";
            this.userAdd.Size = new System.Drawing.Size(24, 24);
            this.userAdd.TabIndex = 0;
            this.userAdd.TabStop = false;
            this.userAdd.Click += new System.EventHandler(this.userAdd_Click);
            // 
            // userDelete
            // 
            this.userDelete.BackgroundImage = global::MonitoringPlatform.Properties.Resources.delete;
            this.userDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userDelete.Location = new System.Drawing.Point(49, 3);
            this.userDelete.Name = "userDelete";
            this.userDelete.Size = new System.Drawing.Size(24, 24);
            this.userDelete.TabIndex = 15;
            this.userDelete.TabStop = false;
            this.userDelete.Click += new System.EventHandler(this.userDelete_Click);
            // 
            // userSure
            // 
            this.userSure.BackgroundImage = global::MonitoringPlatform.Properties.Resources.sure;
            this.userSure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userSure.Location = new System.Drawing.Point(79, 3);
            this.userSure.Name = "userSure";
            this.userSure.Size = new System.Drawing.Size(24, 24);
            this.userSure.TabIndex = 15;
            this.userSure.TabStop = false;
            this.userSure.Visible = false;
            this.userSure.Click += new System.EventHandler(this.userSure_Click);
            // 
            // userCancel
            // 
            this.userCancel.BackgroundImage = global::MonitoringPlatform.Properties.Resources.cancel;
            this.userCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userCancel.Location = new System.Drawing.Point(109, 3);
            this.userCancel.Name = "userCancel";
            this.userCancel.Size = new System.Drawing.Size(24, 24);
            this.userCancel.TabIndex = 18;
            this.userCancel.TabStop = false;
            this.userCancel.Visible = false;
            this.userCancel.Click += new System.EventHandler(this.userCancel_Click);
            // 
            // userDataView
            // 
            this.userDataView.AllowUserToAddRows = false;
            this.userDataView.AllowUserToDeleteRows = false;
            this.userDataView.AllowUserToOrderColumns = true;
            this.userDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataView.BackgroundColor = System.Drawing.Color.White;
            this.userDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle85.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle85.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle85.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle85.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle85.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle85.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle85.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle85;
            this.userDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserInfoId,
            this.UserInfoName,
            this.UserInfoNickname,
            this.UserInfoSex,
            this.UserInfoPhoneNum,
            this.UserInfoIdNum,
            this.UserInfoType,
            this.UserInfoPassword});
            dataGridViewCellStyle86.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle86.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle86.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle86.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle86.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle86.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle86.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userDataView.DefaultCellStyle = dataGridViewCellStyle86;
            this.userDataView.GridColor = System.Drawing.SystemColors.Control;
            this.userDataView.Location = new System.Drawing.Point(3, 41);
            this.userDataView.Name = "userDataView";
            this.userDataView.ReadOnly = true;
            dataGridViewCellStyle87.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle87.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle87.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle87.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle87.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle87.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle87.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle87;
            this.userDataView.RowHeadersVisible = false;
            this.userDataView.RowTemplate.Height = 23;
            this.userDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDataView.Size = new System.Drawing.Size(739, 600);
            this.userDataView.TabIndex = 15;
            this.userDataView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.userDataView_CellMouseClick);
            this.userDataView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.userDataView_CellMouseDoubleClick);
            // 
            // UserInfoId
            // 
            this.UserInfoId.HeaderText = "ID";
            this.UserInfoId.Name = "UserInfoId";
            this.UserInfoId.ReadOnly = true;
            this.UserInfoId.Visible = false;
            // 
            // UserInfoName
            // 
            this.UserInfoName.HeaderText = "姓名";
            this.UserInfoName.Name = "UserInfoName";
            this.UserInfoName.ReadOnly = true;
            // 
            // UserInfoNickname
            // 
            this.UserInfoNickname.HeaderText = "昵称";
            this.UserInfoNickname.Name = "UserInfoNickname";
            this.UserInfoNickname.ReadOnly = true;
            // 
            // UserInfoSex
            // 
            this.UserInfoSex.HeaderText = "性别";
            this.UserInfoSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.UserInfoSex.Name = "UserInfoSex";
            this.UserInfoSex.ReadOnly = true;
            this.UserInfoSex.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserInfoSex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UserInfoPhoneNum
            // 
            this.UserInfoPhoneNum.HeaderText = "账号";
            this.UserInfoPhoneNum.Name = "UserInfoPhoneNum";
            this.UserInfoPhoneNum.ReadOnly = true;
            // 
            // UserInfoIdNum
            // 
            this.UserInfoIdNum.HeaderText = "身份证号";
            this.UserInfoIdNum.Name = "UserInfoIdNum";
            this.UserInfoIdNum.ReadOnly = true;
            // 
            // UserInfoType
            // 
            this.UserInfoType.HeaderText = "用户类型";
            this.UserInfoType.Items.AddRange(new object[] {
            "普通用户",
            "司机",
            "管理员"});
            this.UserInfoType.Name = "UserInfoType";
            this.UserInfoType.ReadOnly = true;
            this.UserInfoType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserInfoType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UserInfoPassword
            // 
            this.UserInfoPassword.HeaderText = "密码";
            this.UserInfoPassword.Name = "UserInfoPassword";
            this.UserInfoPassword.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flowLayoutPanel9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(745, 654);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanel9.Controls.Add(this.productDataView);
            this.flowLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel9.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(739, 648);
            this.flowLayoutPanel9.TabIndex = 17;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel10.Controls.Add(this.productAdd);
            this.flowLayoutPanel10.Controls.Add(this.productDelete);
            this.flowLayoutPanel10.Controls.Add(this.productSure);
            this.flowLayoutPanel10.Controls.Add(this.productCancel);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.flowLayoutPanel10.Size = new System.Drawing.Size(739, 32);
            this.flowLayoutPanel10.TabIndex = 19;
            // 
            // productAdd
            // 
            this.productAdd.BackgroundImage = global::MonitoringPlatform.Properties.Resources.add;
            this.productAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.productAdd.Location = new System.Drawing.Point(19, 3);
            this.productAdd.Name = "productAdd";
            this.productAdd.Size = new System.Drawing.Size(24, 24);
            this.productAdd.TabIndex = 0;
            this.productAdd.TabStop = false;
            this.productAdd.Click += new System.EventHandler(this.productAdd_Click);
            // 
            // productDelete
            // 
            this.productDelete.BackgroundImage = global::MonitoringPlatform.Properties.Resources.delete;
            this.productDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.productDelete.Location = new System.Drawing.Point(49, 3);
            this.productDelete.Name = "productDelete";
            this.productDelete.Size = new System.Drawing.Size(24, 24);
            this.productDelete.TabIndex = 15;
            this.productDelete.TabStop = false;
            this.productDelete.Click += new System.EventHandler(this.productDelete_Click);
            // 
            // productSure
            // 
            this.productSure.BackgroundImage = global::MonitoringPlatform.Properties.Resources.sure;
            this.productSure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.productSure.Location = new System.Drawing.Point(79, 3);
            this.productSure.Name = "productSure";
            this.productSure.Size = new System.Drawing.Size(24, 24);
            this.productSure.TabIndex = 15;
            this.productSure.TabStop = false;
            this.productSure.Visible = false;
            this.productSure.Click += new System.EventHandler(this.productModify_Click);
            // 
            // productCancel
            // 
            this.productCancel.BackgroundImage = global::MonitoringPlatform.Properties.Resources.cancel;
            this.productCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.productCancel.Location = new System.Drawing.Point(109, 3);
            this.productCancel.Name = "productCancel";
            this.productCancel.Size = new System.Drawing.Size(24, 24);
            this.productCancel.TabIndex = 18;
            this.productCancel.TabStop = false;
            this.productCancel.Visible = false;
            this.productCancel.Click += new System.EventHandler(this.productCancel_Click);
            // 
            // productDataView
            // 
            this.productDataView.AllowUserToAddRows = false;
            this.productDataView.AllowUserToDeleteRows = false;
            this.productDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataView.BackgroundColor = System.Drawing.Color.White;
            this.productDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle88.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle88.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle88.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle88.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle88.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle88.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle88.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle88;
            this.productDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductInfoId,
            this.ProductInfoName,
            this.ProductInfoNickname,
            this.ProductInfoCategory,
            this.ProductInfoRemark,
            this.ProductInfoTemperatures});
            dataGridViewCellStyle89.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle89.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle89.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle89.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle89.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle89.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle89.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productDataView.DefaultCellStyle = dataGridViewCellStyle89;
            this.productDataView.GridColor = System.Drawing.SystemColors.Control;
            this.productDataView.Location = new System.Drawing.Point(3, 41);
            this.productDataView.Name = "productDataView";
            this.productDataView.ReadOnly = true;
            dataGridViewCellStyle90.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle90.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle90.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle90.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle90.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle90.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle90.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle90;
            this.productDataView.RowHeadersVisible = false;
            this.productDataView.RowTemplate.Height = 23;
            this.productDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataView.Size = new System.Drawing.Size(739, 600);
            this.productDataView.TabIndex = 18;
            this.productDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataView_CellContentClick);
            // 
            // ProductInfoId
            // 
            this.ProductInfoId.HeaderText = "ID";
            this.ProductInfoId.Name = "ProductInfoId";
            this.ProductInfoId.ReadOnly = true;
            // 
            // ProductInfoName
            // 
            this.ProductInfoName.HeaderText = "名称";
            this.ProductInfoName.Name = "ProductInfoName";
            this.ProductInfoName.ReadOnly = true;
            // 
            // ProductInfoNickname
            // 
            this.ProductInfoNickname.HeaderText = "别名";
            this.ProductInfoNickname.Name = "ProductInfoNickname";
            this.ProductInfoNickname.ReadOnly = true;
            // 
            // ProductInfoCategory
            // 
            this.ProductInfoCategory.HeaderText = "类型";
            this.ProductInfoCategory.Name = "ProductInfoCategory";
            this.ProductInfoCategory.ReadOnly = true;
            // 
            // ProductInfoRemark
            // 
            this.ProductInfoRemark.HeaderText = "注意事项";
            this.ProductInfoRemark.Name = "ProductInfoRemark";
            this.ProductInfoRemark.ReadOnly = true;
            // 
            // ProductInfoTemperatures
            // 
            this.ProductInfoTemperatures.HeaderText = "温度";
            this.ProductInfoTemperatures.Name = "ProductInfoTemperatures";
            this.ProductInfoTemperatures.ReadOnly = true;
            this.ProductInfoTemperatures.Text = "";
            // 
            // dataViewInfoInfo
            // 
            this.dataViewInfoInfo.AllowUserToAddRows = false;
            this.dataViewInfoInfo.AllowUserToDeleteRows = false;
            this.dataViewInfoInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataViewInfoInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataViewInfoInfo.BackgroundColor = System.Drawing.Color.White;
            this.dataViewInfoInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataViewInfoInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle73.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle73.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle73.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle73.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle73.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle73.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle73.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataViewInfoInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle73;
            this.dataViewInfoInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle74.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle74.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle74.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle74.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle74.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle74.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataViewInfoInfo.DefaultCellStyle = dataGridViewCellStyle74;
            this.dataViewInfoInfo.GridColor = System.Drawing.SystemColors.Control;
            this.dataViewInfoInfo.Location = new System.Drawing.Point(204, 0);
            this.dataViewInfoInfo.Margin = new System.Windows.Forms.Padding(0);
            this.dataViewInfoInfo.Name = "dataViewInfoInfo";
            this.dataViewInfoInfo.ReadOnly = true;
            dataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle75.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle75.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle75.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle75.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle75.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle75.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataViewInfoInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle75;
            this.dataViewInfoInfo.RowHeadersVisible = false;
            this.dataViewInfoInfo.RowHeadersWidth = 40;
            this.dataViewInfoInfo.RowTemplate.Height = 23;
            this.dataViewInfoInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataViewInfoInfo.Size = new System.Drawing.Size(770, 648);
            this.dataViewInfoInfo.TabIndex = 15;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.panel1);
            this.panelInfo.Controls.Add(this.panel2);
            this.panelInfo.Controls.Add(this.panel3);
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(2);
            this.panelInfo.Size = new System.Drawing.Size(204, 680);
            this.panelInfo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 70);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.showTruckList);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "车辆";
            this.label1.Click += new System.EventHandler(this.showTruckList);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(26, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 37);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.showTruckList);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(2, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 70);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.showUserList);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户";
            this.label2.Click += new System.EventHandler(this.showUserList);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(26, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 37);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.showUserList);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(2, 142);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 70);
            this.panel3.TabIndex = 3;
            this.panel3.Click += new System.EventHandler(this.showProductList);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "产品";
            this.label3.Click += new System.EventHandler(this.showProductList);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(26, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 37);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.showProductList);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Location = new System.Drawing.Point(3, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 1);
            this.panel4.TabIndex = 16;
            // 
            // flowLayoutPanelInfo
            // 
            this.flowLayoutPanelInfo.AutoSize = true;
            this.flowLayoutPanelInfo.Controls.Add(this.labelMenuInfo);
            this.flowLayoutPanelInfo.Controls.Add(this.pictureMenuInfo);
            this.flowLayoutPanelInfo.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanelInfo.Location = new System.Drawing.Point(3, 131);
            this.flowLayoutPanelInfo.Name = "flowLayoutPanelInfo";
            this.flowLayoutPanelInfo.Size = new System.Drawing.Size(39, 51);
            this.flowLayoutPanelInfo.TabIndex = 15;
            // 
            // labelMenuInfo
            // 
            this.labelMenuInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMenuInfo.AutoSize = true;
            this.labelMenuInfo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMenuInfo.Location = new System.Drawing.Point(3, 39);
            this.labelMenuInfo.Name = "labelMenuInfo";
            this.labelMenuInfo.Size = new System.Drawing.Size(33, 12);
            this.labelMenuInfo.TabIndex = 1;
            this.labelMenuInfo.Text = "信息";
            this.labelMenuInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMenuInfo.Visible = false;
            // 
            // pictureMenuInfo
            // 
            this.pictureMenuInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureMenuInfo.BackgroundImage")));
            this.pictureMenuInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureMenuInfo.Location = new System.Drawing.Point(3, 3);
            this.pictureMenuInfo.Name = "pictureMenuInfo";
            this.pictureMenuInfo.Size = new System.Drawing.Size(33, 33);
            this.pictureMenuInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureMenuInfo.TabIndex = 0;
            this.pictureMenuInfo.TabStop = false;
            this.pictureMenuInfo.Click += new System.EventHandler(this.infoPicture_Click);
            // 
            // flowLayoutPanelHistory
            // 
            this.flowLayoutPanelHistory.AutoSize = true;
            this.flowLayoutPanelHistory.Controls.Add(this.labelMenuHistory);
            this.flowLayoutPanelHistory.Controls.Add(this.pictureMenuHistory);
            this.flowLayoutPanelHistory.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanelHistory.Location = new System.Drawing.Point(3, 67);
            this.flowLayoutPanelHistory.Name = "flowLayoutPanelHistory";
            this.flowLayoutPanelHistory.Size = new System.Drawing.Size(39, 51);
            this.flowLayoutPanelHistory.TabIndex = 14;
            // 
            // labelMenuHistory
            // 
            this.labelMenuHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMenuHistory.AutoSize = true;
            this.labelMenuHistory.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMenuHistory.Location = new System.Drawing.Point(3, 39);
            this.labelMenuHistory.Name = "labelMenuHistory";
            this.labelMenuHistory.Size = new System.Drawing.Size(33, 12);
            this.labelMenuHistory.TabIndex = 1;
            this.labelMenuHistory.Text = "历史";
            this.labelMenuHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMenuHistory.Visible = false;
            // 
            // pictureMenuHistory
            // 
            this.pictureMenuHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureMenuHistory.BackgroundImage")));
            this.pictureMenuHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureMenuHistory.Location = new System.Drawing.Point(3, 3);
            this.pictureMenuHistory.Name = "pictureMenuHistory";
            this.pictureMenuHistory.Size = new System.Drawing.Size(33, 33);
            this.pictureMenuHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureMenuHistory.TabIndex = 0;
            this.pictureMenuHistory.TabStop = false;
            this.pictureMenuHistory.Click += new System.EventHandler(this.historyPicture_Click);
            // 
            // flowLayoutPanelAll
            // 
            this.flowLayoutPanelAll.AutoSize = true;
            this.flowLayoutPanelAll.Controls.Add(this.labelMenuAll);
            this.flowLayoutPanelAll.Controls.Add(this.pictureMenuAll);
            this.flowLayoutPanelAll.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanelAll.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelAll.Name = "flowLayoutPanelAll";
            this.flowLayoutPanelAll.Size = new System.Drawing.Size(39, 51);
            this.flowLayoutPanelAll.TabIndex = 3;
            // 
            // labelMenuAll
            // 
            this.labelMenuAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMenuAll.AutoSize = true;
            this.labelMenuAll.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMenuAll.Location = new System.Drawing.Point(3, 39);
            this.labelMenuAll.Name = "labelMenuAll";
            this.labelMenuAll.Size = new System.Drawing.Size(33, 12);
            this.labelMenuAll.TabIndex = 1;
            this.labelMenuAll.Text = "总览";
            this.labelMenuAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureMenuAll
            // 
            this.pictureMenuAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureMenuAll.BackgroundImage")));
            this.pictureMenuAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureMenuAll.Location = new System.Drawing.Point(3, 3);
            this.pictureMenuAll.Name = "pictureMenuAll";
            this.pictureMenuAll.Size = new System.Drawing.Size(33, 33);
            this.pictureMenuAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureMenuAll.TabIndex = 0;
            this.pictureMenuAll.TabStop = false;
            this.pictureMenuAll.Click += new System.EventHandler(this.allPicture_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.Controls.Add(this.flowLayoutPanelAll);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.flowLayoutPanelHistory);
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.flowLayoutPanelInfo);
            this.panelMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(46, 680);
            this.panelMenu.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Location = new System.Drawing.Point(3, 124);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(40, 1);
            this.panel5.TabIndex = 18;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMain.Controls.Add(this.homeTabControl);
            this.panelMain.Location = new System.Drawing.Point(48, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(978, 680);
            this.panelMain.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1022, 641);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "监控平台";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainTemperatureChart)).EndInit();
            this.groupBoxMainMap.ResumeLayout(false);
            this.groupBoxMainMap.PerformLayout();
            this.groupBoxMainTemperature.ResumeLayout(false);
            this.groupBoxMainTemperature.PerformLayout();
            this.mainTaskInfoAlarm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.temperatureAlert)).EndInit();
            this.mainTaskInfoTruckDriverName.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.mainTaskInfoProduct.ResumeLayout(false);
            this.mainTaskInfoProduct.PerformLayout();
            this.flowLayoutPanelProductInfo.ResumeLayout(false);
            this.flowLayoutPanelProductInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.homeTabControl.ResumeLayout(false);
            this.tabMainTask.ResumeLayout(false);
            this.panelMainTask.ResumeLayout(false);
            this.panelMainTaskInfo.ResumeLayout(false);
            this.panelMainTaskList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainTaskList)).EndInit();
            this.panelMainAll.ResumeLayout(false);
            this.panelMainAll.PerformLayout();
            this.historyTab.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historySearchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyTaskList)).EndInit();
            this.panelHistoryTask.ResumeLayout(false);
            this.panelHistoryTaskInfo.ResumeLayout(false);
            this.historyTaskInfo.ResumeLayout(false);
            this.historyTaskInfo.PerformLayout();
            this.historyTruckInfo.ResumeLayout(false);
            this.historyTruckInfo.PerformLayout();
            this.historyTemperatureGroupBox.ResumeLayout(false);
            this.historyTemperatureGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyTemperatureChart)).EndInit();
            this.historyMapGroupBox.ResumeLayout(false);
            this.historyMapGroupBox.PerformLayout();
            this.infoTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.truckAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckModify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckDataView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewInfoInfo)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.flowLayoutPanelInfo.ResumeLayout(false);
            this.flowLayoutPanelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenuInfo)).EndInit();
            this.flowLayoutPanelHistory.ResumeLayout(false);
            this.flowLayoutPanelHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenuHistory)).EndInit();
            this.flowLayoutPanelAll.ResumeLayout(false);
            this.flowLayoutPanelAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenuAll)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser mainMapWeb;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainTemperatureChart;
        private System.Windows.Forms.GroupBox groupBoxMainMap;
        private System.Windows.Forms.GroupBox groupBoxMainTemperature;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加车辆信息ToolStripMenuItem;
        private System.Windows.Forms.GroupBox mainTaskInfoProduct;
        private System.Windows.Forms.Label mainTaskInfoProductTemp;
        private System.Windows.Forms.Label mainTaskInfoProductName;
        private System.Windows.Forms.ToolStripMenuItem 车辆信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 产品信息ToolStripMenuItem;
        private System.Windows.Forms.GroupBox mainTaskInfoTruckDriverName;
        private System.Windows.Forms.Label mainTaskInfoTruckPhoneNum;
        private System.Windows.Forms.Label directorNameLabel;
        private System.Windows.Forms.Label mainTaskInfoTruckPlateNum;
        private System.Windows.Forms.Label mainTaskInfoProductStartDate;
        private System.Windows.Forms.GroupBox mainTaskInfoAlarm;
        private System.Windows.Forms.RichTextBox mainTaskInfoAlarmTips;
        private System.Windows.Forms.TabControl homeTabControl;
        private System.Windows.Forms.TabPage tabMainTask;
        private System.Windows.Forms.TabPage historyTab;
        private System.Windows.Forms.ToolStripMenuItem 模拟一次任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止一次任务ToolStripMenuItem;
        private System.Windows.Forms.DataGridView mainTaskList;
        private System.Windows.Forms.DataGridView historyTaskList;
        private System.Windows.Forms.ToolStripMenuItem 驾驶员信息ToolStripMenuItem;
        private System.Windows.Forms.TabPage infoTab;
        private System.Windows.Forms.Panel panelMainAll;
        private System.Windows.Forms.WebBrowser webBrowserMainAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAll;
        private System.Windows.Forms.PictureBox pictureMenuAll;
        private System.Windows.Forms.Label labelMenuAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelInfo;
        private System.Windows.Forms.Label labelMenuInfo;
        private System.Windows.Forms.PictureBox pictureMenuInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHistory;
        private System.Windows.Forms.Label labelMenuHistory;
        private System.Windows.Forms.PictureBox pictureMenuHistory;
        private System.Windows.Forms.FlowLayoutPanel panelInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView truckDataView;
        private System.Windows.Forms.DataGridView userDataView;
        private System.Windows.Forms.PictureBox temperatureAlert;
        private System.Windows.Forms.Label mainTaskInfoMapTip;
        private System.Windows.Forms.Label labelAllMapLoadTip;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.PictureBox truckAdd;
        private System.Windows.Forms.PictureBox truckDelete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.PictureBox userAdd;
        private System.Windows.Forms.PictureBox userDelete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.DataGridView productDataView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.PictureBox productAdd;
        private System.Windows.Forms.PictureBox productDelete;
        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem temperatureChange;
        private System.Windows.Forms.Panel panelMainTaskList;
        private System.Windows.Forms.FlowLayoutPanel panelMainTask;
        private System.Windows.Forms.FlowLayoutPanel panelMainTaskInfo;
        private System.Windows.Forms.DataGridView dataViewInfoInfo;
        private System.Windows.Forms.FlowLayoutPanel panelHistoryTask;
        private System.Windows.Forms.FlowLayoutPanel panelHistoryTaskInfo;
        private System.Windows.Forms.GroupBox historyTaskInfo;
        private System.Windows.Forms.Label historyEndDatetimeLabel;
        private System.Windows.Forms.Label historyBeginDatetimeLabel;
        private System.Windows.Forms.Label historyProductTemperatureLabel;
        private System.Windows.Forms.Label historyProductNameLabel;
        private System.Windows.Forms.GroupBox historyTruckInfo;
        private System.Windows.Forms.Label historyDirectorNumLabel;
        private System.Windows.Forms.Label historyDirectorNameLabel;
        private System.Windows.Forms.Label historyPlateNumLabel;
        private System.Windows.Forms.GroupBox historyTemperatureGroupBox;
        private System.Windows.Forms.PictureBox ChartDetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart historyTemperatureChart;
        private System.Windows.Forms.GroupBox historyMapGroupBox;
        private System.Windows.Forms.WebBrowser historyMapWeb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginDatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label mainTaskInfoTruckModel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProductInfo;
        private System.Windows.Forms.Label mainTaskInfoProductNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label mainTaskInfoTruckLoad;
        private System.Windows.Forms.Label mainTaskInfoProductPlace;
        private System.Windows.Forms.Label mainTaskInfoProductDate;
        private System.Windows.Forms.PictureBox truckModify;
        private System.Windows.Forms.PictureBox userSure;
        private System.Windows.Forms.PictureBox productSure;
        private System.Windows.Forms.DataGridViewTextBoxColumn TruckPlateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TruckModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TruckLoad;
        private System.Windows.Forms.DataGridViewComboBoxColumn TruckState;
        private System.Windows.Forms.DataGridViewTextBoxColumn TruckID;
        private System.Windows.Forms.PictureBox truckCancel;
        private System.Windows.Forms.PictureBox userCancel;
        private System.Windows.Forms.PictureBox productCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserInfoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserInfoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserInfoNickname;
        private System.Windows.Forms.DataGridViewComboBoxColumn UserInfoSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserInfoPhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserInfoIdNum;
        private System.Windows.Forms.DataGridViewComboBoxColumn UserInfoType;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserInfoPassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox historySearchTextBox;
        private System.Windows.Forms.PictureBox historySearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductInfoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductInfoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductInfoNickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductInfoCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductInfoRemark;
        private System.Windows.Forms.DataGridViewButtonColumn ProductInfoTemperatures;
    }
}

