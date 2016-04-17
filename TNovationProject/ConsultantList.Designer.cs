namespace TNovationProject
{
    partial class ConsultantList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultantList));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ConsultantNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateofBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TelNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmergencyContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmploymentDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoursofWork = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmploymentHistory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ConsultantNo,
            this.Name,
            this.DateofBirth,
            this.Address,
            this.Email,
            this.TelNo,
            this.EmergencyContact,
            this.EmploymentDate,
            this.HoursofWork,
            this.EmploymentHistory,
            this.Status});
            this.listView1.Location = new System.Drawing.Point(41, 119);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(851, 429);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ConsultantNo
            // 
            this.ConsultantNo.Text = "ConsultantNo";
            this.ConsultantNo.Width = 78;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            // 
            // DateofBirth
            // 
            this.DateofBirth.Text = "Date of birth";
            this.DateofBirth.Width = 72;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            // 
            // Email
            // 
            this.Email.Text = "E-mail";
            // 
            // TelNo
            // 
            this.TelNo.Text = "TelNo";
            // 
            // EmergencyContact
            // 
            this.EmergencyContact.Text = "Emergency contact";
            this.EmergencyContact.Width = 110;
            // 
            // EmploymentDate
            // 
            this.EmploymentDate.Text = "Employment Date";
            this.EmploymentDate.Width = 97;
            // 
            // HoursofWork
            // 
            this.HoursofWork.Text = "Hours of work";
            this.HoursofWork.Width = 82;
            // 
            // EmploymentHistory
            // 
            this.EmploymentHistory.Text = "Employment history";
            this.EmploymentHistory.Width = 106;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 63;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(913, 495);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 42);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(913, 446);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(112, 43);
            this.buttonFilter.TabIndex = 12;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(913, 385);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 45);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(913, 323);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(112, 46);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(913, 262);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 46);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.Navy;
            this.labelHeading.Location = new System.Drawing.Point(256, 40);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(334, 73);
            this.labelHeading.TabIndex = 70;
            this.labelHeading.Text = "TNovation";
            // 
            // ConsultantList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 625);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ConsultantList";
            this.Text = "ConsultantForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ConsultantNo;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader DateofBirth;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader TelNo;
        private System.Windows.Forms.ColumnHeader EmergencyContact;
        private System.Windows.Forms.ColumnHeader EmploymentDate;
        private System.Windows.Forms.ColumnHeader HoursofWork;
        private System.Windows.Forms.ColumnHeader EmploymentHistory;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelHeading;
    }
}