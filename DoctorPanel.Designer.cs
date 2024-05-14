namespace Hospital
{
    partial class DoctorPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.denyBtn = new System.Windows.Forms.Button();
            this.approveBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.serviceTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.patientTxt = new System.Windows.Forms.TextBox();
            this.appointmentDate = new System.Windows.Forms.DateTimePicker();
            this.appointmentId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 182);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // denyBtn
            // 
            this.denyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.denyBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.denyBtn.Location = new System.Drawing.Point(605, 432);
            this.denyBtn.Name = "denyBtn";
            this.denyBtn.Size = new System.Drawing.Size(156, 46);
            this.denyBtn.TabIndex = 39;
            this.denyBtn.Text = "Deny";
            this.denyBtn.UseVisualStyleBackColor = false;
            this.denyBtn.Click += new System.EventHandler(this.denyBtn_Click);
            // 
            // approveBtn
            // 
            this.approveBtn.BackColor = System.Drawing.Color.Teal;
            this.approveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.approveBtn.Location = new System.Drawing.Point(605, 363);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(156, 46);
            this.approveBtn.TabIndex = 38;
            this.approveBtn.Text = "Approve";
            this.approveBtn.UseVisualStyleBackColor = false;
            this.approveBtn.Click += new System.EventHandler(this.approveBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.refreshBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refreshBtn.Location = new System.Drawing.Point(605, 296);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(156, 46);
            this.refreshBtn.TabIndex = 37;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Appointment date";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(713, 512);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(48, 16);
            this.linkLabel1.TabIndex = 34;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // serviceTxt
            // 
            this.serviceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceTxt.Location = new System.Drawing.Point(266, 161);
            this.serviceTxt.Multiline = true;
            this.serviceTxt.Name = "serviceTxt";
            this.serviceTxt.Size = new System.Drawing.Size(226, 41);
            this.serviceTxt.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Patient";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 76);
            this.panel1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "HealthyLifeChoice Hospital - Home";
            // 
            // patientTxt
            // 
            this.patientTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientTxt.Location = new System.Drawing.Point(15, 161);
            this.patientTxt.Multiline = true;
            this.patientTxt.Name = "patientTxt";
            this.patientTxt.Size = new System.Drawing.Size(226, 41);
            this.patientTxt.TabIndex = 41;
            // 
            // appointmentDate
            // 
            this.appointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDate.Location = new System.Drawing.Point(533, 161);
            this.appointmentDate.Name = "appointmentDate";
            this.appointmentDate.Size = new System.Drawing.Size(228, 38);
            this.appointmentDate.TabIndex = 42;
            // 
            // appointmentId
            // 
            this.appointmentId.AutoSize = true;
            this.appointmentId.Location = new System.Drawing.Point(16, 246);
            this.appointmentId.Name = "appointmentId";
            this.appointmentId.Size = new System.Drawing.Size(37, 16);
            this.appointmentId.TabIndex = 43;
            this.appointmentId.Text = "none";
            this.appointmentId.Visible = false;
            // 
            // DoctorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.appointmentId);
            this.Controls.Add(this.appointmentDate);
            this.Controls.Add(this.patientTxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.denyBtn);
            this.Controls.Add(this.approveBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.serviceTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "DoctorPanel";
            this.Text = "DoctorPanel";
            this.Load += new System.EventHandler(this.DoctorPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button denyBtn;
        private System.Windows.Forms.Button approveBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox serviceTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patientTxt;
        private System.Windows.Forms.DateTimePicker appointmentDate;
        private System.Windows.Forms.Label appointmentId;
    }
}