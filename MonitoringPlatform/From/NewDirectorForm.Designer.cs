namespace MonitoringPlatform
{
    partial class NewDirectorForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.directorNumText = new System.Windows.Forms.TextBox();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.directorNameText = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(175, 143);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(67, 25);
            this.addButton.TabIndex = 27;
            this.addButton.Text = "添  加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "—————————";
            // 
            // directorNumText
            // 
            this.directorNumText.BackColor = System.Drawing.SystemColors.Control;
            this.directorNumText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.directorNumText.Location = new System.Drawing.Point(153, 95);
            this.directorNumText.Name = "directorNumText";
            this.directorNumText.Size = new System.Drawing.Size(63, 14);
            this.directorNumText.TabIndex = 25;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.temperatureLabel.Location = new System.Drawing.Point(28, 95);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(101, 12);
            this.temperatureLabel.TabIndex = 24;
            this.temperatureLabel.Text = "负责人联系电话：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "—————————";
            // 
            // directorNameText
            // 
            this.directorNameText.BackColor = System.Drawing.SystemColors.Control;
            this.directorNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.directorNameText.Location = new System.Drawing.Point(153, 58);
            this.directorNameText.Name = "directorNameText";
            this.directorNameText.Size = new System.Drawing.Size(63, 14);
            this.directorNameText.TabIndex = 22;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(52, 58);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(77, 12);
            this.productNameLabel.TabIndex = 21;
            this.productNameLabel.Text = "负责人姓名：";
            // 
            // NewDirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 203);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.directorNumText);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directorNameText);
            this.Controls.Add(this.productNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewDirectorForm";
            this.Text = "NewDirectorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox directorNumText;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox directorNameText;
        private System.Windows.Forms.Label productNameLabel;
    }
}