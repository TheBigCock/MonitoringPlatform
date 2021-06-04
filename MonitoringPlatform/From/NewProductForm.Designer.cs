namespace MonitoringPlatform
{
    partial class NewProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainFLPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.temperatureDataView = new System.Windows.Forms.DataGridView();
            this.tempAdd = new System.Windows.Forms.PictureBox();
            this.tempDelete = new System.Windows.Forms.PictureBox();
            this.tempSure = new System.Windows.Forms.PictureBox();
            this.tempCancel = new System.Windows.Forms.PictureBox();
            this.TemperaturesInstruction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemperaturesDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemperaturesTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemperaturesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            this.mainFLPanel.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempSure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.mainFLPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(496, 281);
            this.mainPanel.TabIndex = 0;
            // 
            // mainFLPanel
            // 
            this.mainFLPanel.Controls.Add(this.flowLayoutPanel10);
            this.mainFLPanel.Controls.Add(this.temperatureDataView);
            this.mainFLPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFLPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainFLPanel.Location = new System.Drawing.Point(0, 0);
            this.mainFLPanel.Name = "mainFLPanel";
            this.mainFLPanel.Size = new System.Drawing.Size(496, 281);
            this.mainFLPanel.TabIndex = 0;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel10.Controls.Add(this.tempAdd);
            this.flowLayoutPanel10.Controls.Add(this.tempDelete);
            this.flowLayoutPanel10.Controls.Add(this.tempSure);
            this.flowLayoutPanel10.Controls.Add(this.tempCancel);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.flowLayoutPanel10.Size = new System.Drawing.Size(490, 32);
            this.flowLayoutPanel10.TabIndex = 20;
            // 
            // temperatureDataView
            // 
            this.temperatureDataView.AllowUserToAddRows = false;
            this.temperatureDataView.AllowUserToDeleteRows = false;
            this.temperatureDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.temperatureDataView.BackgroundColor = System.Drawing.Color.White;
            this.temperatureDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.temperatureDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.temperatureDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.temperatureDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.temperatureDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TemperaturesInstruction,
            this.TemperaturesDuration,
            this.TemperaturesTemp,
            this.TemperaturesId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.temperatureDataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.temperatureDataView.GridColor = System.Drawing.SystemColors.Control;
            this.temperatureDataView.Location = new System.Drawing.Point(3, 38);
            this.temperatureDataView.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.temperatureDataView.Name = "temperatureDataView";
            this.temperatureDataView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.temperatureDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.temperatureDataView.RowHeadersVisible = false;
            this.temperatureDataView.RowTemplate.Height = 23;
            this.temperatureDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.temperatureDataView.Size = new System.Drawing.Size(490, 237);
            this.temperatureDataView.TabIndex = 21;
            this.temperatureDataView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.temperatureDataView_CellMouseClick);
            this.temperatureDataView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.temperatureDataView_CellMouseDoubleClick);
            // 
            // tempAdd
            // 
            this.tempAdd.BackgroundImage = global::MonitoringPlatform.Properties.Resources.add;
            this.tempAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tempAdd.Location = new System.Drawing.Point(19, 3);
            this.tempAdd.Name = "tempAdd";
            this.tempAdd.Size = new System.Drawing.Size(24, 24);
            this.tempAdd.TabIndex = 0;
            this.tempAdd.TabStop = false;
            this.tempAdd.Click += new System.EventHandler(this.tempAdd_Click);
            // 
            // tempDelete
            // 
            this.tempDelete.BackgroundImage = global::MonitoringPlatform.Properties.Resources.delete;
            this.tempDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tempDelete.Location = new System.Drawing.Point(49, 3);
            this.tempDelete.Name = "tempDelete";
            this.tempDelete.Size = new System.Drawing.Size(24, 24);
            this.tempDelete.TabIndex = 15;
            this.tempDelete.TabStop = false;
            this.tempDelete.Click += new System.EventHandler(this.tempDelete_Click);
            // 
            // tempSure
            // 
            this.tempSure.BackgroundImage = global::MonitoringPlatform.Properties.Resources.sure;
            this.tempSure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tempSure.Location = new System.Drawing.Point(79, 3);
            this.tempSure.Name = "tempSure";
            this.tempSure.Size = new System.Drawing.Size(24, 24);
            this.tempSure.TabIndex = 15;
            this.tempSure.TabStop = false;
            this.tempSure.Visible = false;
            this.tempSure.Click += new System.EventHandler(this.tempSure_Click);
            // 
            // tempCancel
            // 
            this.tempCancel.BackgroundImage = global::MonitoringPlatform.Properties.Resources.cancel;
            this.tempCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tempCancel.Location = new System.Drawing.Point(109, 3);
            this.tempCancel.Name = "tempCancel";
            this.tempCancel.Size = new System.Drawing.Size(24, 24);
            this.tempCancel.TabIndex = 18;
            this.tempCancel.TabStop = false;
            this.tempCancel.Visible = false;
            this.tempCancel.Click += new System.EventHandler(this.tempCancel_Click);
            // 
            // TemperaturesInstruction
            // 
            this.TemperaturesInstruction.HeaderText = "说明";
            this.TemperaturesInstruction.Name = "TemperaturesInstruction";
            this.TemperaturesInstruction.ReadOnly = true;
            // 
            // TemperaturesDuration
            // 
            this.TemperaturesDuration.HeaderText = "运输期限";
            this.TemperaturesDuration.Name = "TemperaturesDuration";
            this.TemperaturesDuration.ReadOnly = true;
            // 
            // TemperaturesTemp
            // 
            this.TemperaturesTemp.HeaderText = "适宜运输温度";
            this.TemperaturesTemp.Name = "TemperaturesTemp";
            this.TemperaturesTemp.ReadOnly = true;
            // 
            // TemperaturesId
            // 
            this.TemperaturesId.HeaderText = "ID";
            this.TemperaturesId.Name = "TemperaturesId";
            this.TemperaturesId.ReadOnly = true;
            this.TemperaturesId.Visible = false;
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(496, 281);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewProductForm";
            this.Text = "产品运输温度信息--";
            this.mainPanel.ResumeLayout(false);
            this.mainFLPanel.ResumeLayout(false);
            this.flowLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.temperatureDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempSure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.FlowLayoutPanel mainFLPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.PictureBox tempAdd;
        private System.Windows.Forms.PictureBox tempDelete;
        private System.Windows.Forms.PictureBox tempSure;
        private System.Windows.Forms.PictureBox tempCancel;
        private System.Windows.Forms.DataGridView temperatureDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemperaturesInstruction;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemperaturesDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemperaturesTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemperaturesId;
    }
}