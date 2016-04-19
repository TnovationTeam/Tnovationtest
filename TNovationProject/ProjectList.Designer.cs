namespace TNovationProject
{
    partial class ProjectList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectList));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHeading = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonArchive = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnProjectCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProjectConsultant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCompanyContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnExpectedEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProjectLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.Navy;
            this.labelHeading.Location = new System.Drawing.Point(178, 25);
            this.labelHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(466, 91);
            this.labelHeading.TabIndex = 24;
            this.labelHeading.Text = "T{Novation}";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(814, 147);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 46);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(814, 217);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(117, 41);
            this.buttonUpdate.TabIndex = 30;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonArchive
            // 
            this.buttonArchive.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArchive.Location = new System.Drawing.Point(814, 284);
            this.buttonArchive.Margin = new System.Windows.Forms.Padding(4);
            this.buttonArchive.Name = "buttonArchive";
            this.buttonArchive.Size = new System.Drawing.Size(117, 42);
            this.buttonArchive.TabIndex = 31;
            this.buttonArchive.Text = "Archive";
            this.buttonArchive.UseVisualStyleBackColor = false;
            this.buttonArchive.Click += new System.EventHandler(this.buttonArchive_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBack.Location = new System.Drawing.Point(814, 477);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(117, 38);
            this.buttonBack.TabIndex = 32;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.White;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProjectCode,
            this.columnProjectName,
            this.columnCompanyName,
            this.columnProjectConsultant,
            this.columnCompanyContact,
            this.columnExpectedEndDate,
            this.columnStartDate,
            this.columnProjectLocation});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.Location = new System.Drawing.Point(30, 147);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(765, 368);
            this.listView2.TabIndex = 33;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnProjectCode
            // 
            this.columnProjectCode.Text = "Project Code";
            this.columnProjectCode.Width = 113;
            // 
            // columnProjectName
            // 
            this.columnProjectName.Text = "Project Name";
            this.columnProjectName.Width = 118;
            // 
            // columnCompanyName
            // 
            this.columnCompanyName.Text = "Company Name";
            this.columnCompanyName.Width = 68;
            // 
            // columnProjectConsultant
            // 
            this.columnProjectConsultant.Text = "Project Consultant";
            this.columnProjectConsultant.Width = 87;
            // 
            // columnCompanyContact
            // 
            this.columnCompanyContact.Text = "Company Contact";
            this.columnCompanyContact.Width = 117;
            // 
            // columnExpectedEndDate
            // 
            this.columnExpectedEndDate.Text = "Expected End Date";
            this.columnExpectedEndDate.Width = 61;
            // 
            // columnStartDate
            // 
            this.columnStartDate.Text = "Start Date";
            this.columnStartDate.Width = 100;
            // 
            // columnProjectLocation
            // 
            this.columnProjectLocation.Text = "Project Location";
            this.columnProjectLocation.Width = 170;
            // 
            // ProjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 569);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonArchive);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProjectList";
            this.Text = "ProjectList";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonArchive;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnProjectCode;
        private System.Windows.Forms.ColumnHeader columnProjectName;
        private System.Windows.Forms.ColumnHeader columnCompanyName;
        private System.Windows.Forms.ColumnHeader columnProjectConsultant;
        private System.Windows.Forms.ColumnHeader columnCompanyContact;
        private System.Windows.Forms.ColumnHeader columnExpectedEndDate;
        private System.Windows.Forms.ColumnHeader columnStartDate;
        private System.Windows.Forms.ColumnHeader columnProjectLocation;
    }
}