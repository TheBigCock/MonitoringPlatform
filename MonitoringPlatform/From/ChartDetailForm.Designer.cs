namespace MonitoringPlatform
{
    partial class ChartDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartDetailForm));
            this.historyTemperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.alarmDataView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.historyTemperatureChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // historyTemperatureChart
            // 
            this.historyTemperatureChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisX.ScaleView.Position = 0D;
            chartArea1.AxisX.ScaleView.Size = 20D;
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.Title = "时间";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisY.Maximum = 20D;
            chartArea1.AxisY.Minimum = -10D;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea1.AxisY.Title = "温度";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea";
            this.historyTemperatureChart.ChartAreas.Add(chartArea1);
            this.historyTemperatureChart.Location = new System.Drawing.Point(225, 9);
            this.historyTemperatureChart.Name = "historyTemperatureChart";
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Label = "#VAL";
            series1.LabelForeColor = System.Drawing.SystemColors.ActiveCaption;
            series1.LabelToolTip = "#VAL℃/#VALX";
            series1.Name = "TemperatureChange";
            series1.SmartLabelStyle.CalloutBackColor = System.Drawing.SystemColors.Control;
            this.historyTemperatureChart.Series.Add(series1);
            this.historyTemperatureChart.Size = new System.Drawing.Size(712, 403);
            this.historyTemperatureChart.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(884, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // alarmDataView
            // 
            this.alarmDataView.AllowUserToAddRows = false;
            this.alarmDataView.AllowUserToDeleteRows = false;
            this.alarmDataView.BackgroundColor = System.Drawing.Color.White;
            this.alarmDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alarmDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.alarmDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alarmDataView.GridColor = System.Drawing.SystemColors.Control;
            this.alarmDataView.Location = new System.Drawing.Point(28, 41);
            this.alarmDataView.Name = "alarmDataView";
            this.alarmDataView.ReadOnly = true;
            this.alarmDataView.RowHeadersVisible = false;
            this.alarmDataView.RowTemplate.Height = 23;
            this.alarmDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.alarmDataView.Size = new System.Drawing.Size(191, 374);
            this.alarmDataView.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "温度异常警报：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "无温度异常警报";
            this.label2.Visible = false;
            // 
            // ChartDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 427);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alarmDataView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.historyTemperatureChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChartDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "温度变化详情";
            ((System.ComponentModel.ISupportInitialize)(this.historyTemperatureChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart historyTemperatureChart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView alarmDataView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}