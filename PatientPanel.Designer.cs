namespace Hospital
{
    partial class PatientPanel
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
            this.components = new System.ComponentModel.Container();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.registerBtn = new System.Windows.Forms.Button();
            this.specialityTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appointmentDate = new System.Windows.Forms.DateTimePicker();
            this.doctorList = new System.Windows.Forms.ComboBox();
            this.hospital_DBDataSet = new Hospital.Hospital_DBDataSet();
            this.hospitalDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentIdLbl = new System.Windows.Forms.Label();
            this.appointmentId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(710, 535);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(48, 16);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.registerBtn.Location = new System.Drawing.Point(12, 243);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(156, 46);
            this.registerBtn.TabIndex = 20;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // specialityTxt
            // 
            this.specialityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialityTxt.Location = new System.Drawing.Point(263, 184);
            this.specialityTxt.Multiline = true;
            this.specialityTxt.Name = "specialityTxt";
            this.specialityTxt.Size = new System.Drawing.Size(226, 41);
            this.specialityTxt.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Speciality";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Doctor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 76);
            this.panel1.TabIndex = 11;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Appointment date";
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.refreshBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refreshBtn.Location = new System.Drawing.Point(602, 319);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(156, 46);
            this.refreshBtn.TabIndex = 24;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateBtn.Location = new System.Drawing.Point(602, 386);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(156, 46);
            this.updateBtn.TabIndex = 25;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteBtn.Location = new System.Drawing.Point(602, 455);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(156, 46);
            this.deleteBtn.TabIndex = 26;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 182);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // appointmentDate
            // 
            this.appointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDate.Location = new System.Drawing.Point(530, 184);
            this.appointmentDate.Name = "appointmentDate";
            this.appointmentDate.Size = new System.Drawing.Size(228, 38);
            this.appointmentDate.TabIndex = 28;
            // 
            // doctorList
            // 
            this.doctorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorList.FormattingEnabled = true;
            this.doctorList.Location = new System.Drawing.Point(12, 184);
            this.doctorList.Name = "doctorList";
            this.doctorList.Size = new System.Drawing.Size(211, 37);
            this.doctorList.TabIndex = 29;
            this.doctorList.SelectedIndexChanged += new System.EventHandler(this.doctorList_SelectedIndexChanged);
            // 
            // hospital_DBDataSet
            // 
            this.hospital_DBDataSet.DataSetName = "Hospital_DBDataSet";
            this.hospital_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalDBDataSetBindingSource
            // 
            this.hospitalDBDataSetBindingSource.DataSource = this.hospital_DBDataSet;
            this.hospitalDBDataSetBindingSource.Position = 0;
            // 
            // appointmentIdLbl
            // 
            this.appointmentIdLbl.AutoSize = true;
            this.appointmentIdLbl.Location = new System.Drawing.Point(202, 258);
            this.appointmentIdLbl.Name = "appointmentIdLbl";
            this.appointmentIdLbl.Size = new System.Drawing.Size(0, 16);
            this.appointmentIdLbl.TabIndex = 30;
            this.appointmentIdLbl.Visible = false;
            // 
            // appointmentId
            // 
            this.appointmentId.AutoSize = true;
            this.appointmentId.Location = new System.Drawing.Point(228, 258);
            this.appointmentId.Name = "appointmentId";
            this.appointmentId.Size = new System.Drawing.Size(37, 16);
            this.appointmentId.TabIndex = 31;
            this.appointmentId.Text = "none";
            this.appointmentId.Visible = false;
            // 
            // PatientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.appointmentId);
            this.Controls.Add(this.appointmentIdLbl);
            this.Controls.Add(this.doctorList);
            this.Controls.Add(this.appointmentDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.specialityTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "PatientPanel";
            this.Text = "PersonalPanel";
            this.Load += new System.EventHandler(this.PatientPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox specialityTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker appointmentDate;
        private System.Windows.Forms.ComboBox doctorList;
        private Hospital_DBDataSet hospital_DBDataSet;
        private System.Windows.Forms.BindingSource hospitalDBDataSetBindingSource;
        private System.Windows.Forms.Label appointmentIdLbl;
        private System.Windows.Forms.Label appointmentId;
    }
}