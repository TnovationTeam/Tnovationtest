namespace TNovationProject
{
    partial class AddProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProject));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelHeading = new System.Windows.Forms.Label();
            this.lblProjectCode = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblProjectConsultant = new System.Windows.Forms.Label();
            this.lblCompnayContact = new System.Windows.Forms.Label();
            this.lblExpectedEndDate = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblProjectLocation = new System.Windows.Forms.Label();
            this.textBoxProjectCode = new System.Windows.Forms.TextBox();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.textBoxProjectConsultant = new System.Windows.Forms.TextBox();
            this.textBoxCompanyContact = new System.Windows.Forms.TextBox();
            this.textBoxExpectedEndDate = new System.Windows.Forms.TextBox();
            this.textBoxStartDate = new System.Windows.Forms.TextBox();
            this.textBoxProjectLocation = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(833, 242);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(132, 63);
            this.buttonAdd.TabIndex = 44;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBack.Location = new System.Drawing.Point(833, 444);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(132, 58);
            this.buttonBack.TabIndex = 45;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(43, 35);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(125, 91);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 46;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.Navy;
            this.labelHeading.Location = new System.Drawing.Point(187, 35);
            this.labelHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(466, 91);
            this.labelHeading.TabIndex = 47;
            this.labelHeading.Text = "T{Novation}";
            // 
            // lblProjectCode
            // 
            this.lblProjectCode.AutoSize = true;
            this.lblProjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectCode.Location = new System.Drawing.Point(44, 196);
            this.lblProjectCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectCode.Name = "lblProjectCode";
            this.lblProjectCode.Size = new System.Drawing.Size(106, 17);
            this.lblProjectCode.TabIndex = 48;
            this.lblProjectCode.Text = "Project Code:";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.Location = new System.Drawing.Point(40, 267);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(110, 17);
            this.lblProjectName.TabIndex = 49;
            this.lblProjectName.Text = "Project Name:";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(40, 335);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(125, 17);
            this.lblCompany.TabIndex = 50;
            this.lblCompany.Text = "Company Name:";
            // 
            // lblProjectConsultant
            // 
            this.lblProjectConsultant.AutoSize = true;
            this.lblProjectConsultant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectConsultant.Location = new System.Drawing.Point(40, 392);
            this.lblProjectConsultant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectConsultant.Name = "lblProjectConsultant";
            this.lblProjectConsultant.Size = new System.Drawing.Size(146, 17);
            this.lblProjectConsultant.TabIndex = 51;
            this.lblProjectConsultant.Text = "Project Consultant:";
            // 
            // lblCompnayContact
            // 
            this.lblCompnayContact.AutoSize = true;
            this.lblCompnayContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompnayContact.Location = new System.Drawing.Point(396, 196);
            this.lblCompnayContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompnayContact.Name = "lblCompnayContact";
            this.lblCompnayContact.Size = new System.Drawing.Size(139, 17);
            this.lblCompnayContact.TabIndex = 52;
            this.lblCompnayContact.Text = "Company Contact:";
            // 
            // lblExpectedEndDate
            // 
            this.lblExpectedEndDate.AutoSize = true;
            this.lblExpectedEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpectedEndDate.Location = new System.Drawing.Point(392, 267);
            this.lblExpectedEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpectedEndDate.Name = "lblExpectedEndDate";
            this.lblExpectedEndDate.Size = new System.Drawing.Size(151, 17);
            this.lblExpectedEndDate.TabIndex = 53;
            this.lblExpectedEndDate.Text = "Expected End Date:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(404, 333);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(87, 17);
            this.lblLocation.TabIndex = 54;
            this.lblLocation.Text = "Start Date:";
            // 
            // lblProjectLocation
            // 
            this.lblProjectLocation.AutoSize = true;
            this.lblProjectLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectLocation.Location = new System.Drawing.Point(404, 389);
            this.lblProjectLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectLocation.Name = "lblProjectLocation";
            this.lblProjectLocation.Size = new System.Drawing.Size(131, 17);
            this.lblProjectLocation.TabIndex = 55;
            this.lblProjectLocation.Text = "Project Location:";
            this.lblProjectLocation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxProjectCode
            // 
            this.textBoxProjectCode.Location = new System.Drawing.Point(158, 194);
            this.textBoxProjectCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProjectCode.Name = "textBoxProjectCode";
            this.textBoxProjectCode.Size = new System.Drawing.Size(196, 22);
            this.textBoxProjectCode.TabIndex = 56;
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Location = new System.Drawing.Point(158, 265);
            this.textBoxProjectName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size(196, 22);
            this.textBoxProjectName.TabIndex = 57;
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(173, 333);
            this.textBoxCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(196, 22);
            this.textBoxCompanyName.TabIndex = 58;
            // 
            // textBoxProjectConsultant
            // 
            this.textBoxProjectConsultant.Location = new System.Drawing.Point(194, 387);
            this.textBoxProjectConsultant.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProjectConsultant.Name = "textBoxProjectConsultant";
            this.textBoxProjectConsultant.Size = new System.Drawing.Size(196, 22);
            this.textBoxProjectConsultant.TabIndex = 59;
            // 
            // textBoxCompanyContact
            // 
            this.textBoxCompanyContact.Location = new System.Drawing.Point(543, 194);
            this.textBoxCompanyContact.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCompanyContact.Name = "textBoxCompanyContact";
            this.textBoxCompanyContact.Size = new System.Drawing.Size(196, 22);
            this.textBoxCompanyContact.TabIndex = 60;
            // 
            // textBoxExpectedEndDate
            // 
            this.textBoxExpectedEndDate.Location = new System.Drawing.Point(551, 262);
            this.textBoxExpectedEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxExpectedEndDate.Name = "textBoxExpectedEndDate";
            this.textBoxExpectedEndDate.Size = new System.Drawing.Size(196, 22);
            this.textBoxExpectedEndDate.TabIndex = 61;
            // 
            // textBoxStartDate
            // 
            this.textBoxStartDate.Location = new System.Drawing.Point(499, 331);
            this.textBoxStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStartDate.Name = "textBoxStartDate";
            this.textBoxStartDate.Size = new System.Drawing.Size(196, 22);
            this.textBoxStartDate.TabIndex = 62;
            // 
            // textBoxProjectLocation
            // 
            this.textBoxProjectLocation.Location = new System.Drawing.Point(543, 387);
            this.textBoxProjectLocation.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProjectLocation.Name = "textBoxProjectLocation";
            this.textBoxProjectLocation.Size = new System.Drawing.Size(196, 22);
            this.textBoxProjectLocation.TabIndex = 63;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(322, 454);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 64;
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 565);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.textBoxProjectLocation);
            this.Controls.Add(this.textBoxStartDate);
            this.Controls.Add(this.textBoxExpectedEndDate);
            this.Controls.Add(this.textBoxCompanyContact);
            this.Controls.Add(this.textBoxProjectConsultant);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.textBoxProjectName);
            this.Controls.Add(this.textBoxProjectCode);
            this.Controls.Add(this.lblProjectLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblExpectedEndDate);
            this.Controls.Add(this.lblCompnayContact);
            this.Controls.Add(this.lblProjectConsultant);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.lblProjectCode);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Name = "AddProject";
            this.Text = "AddProject";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label lblProjectCode;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblProjectConsultant;
        private System.Windows.Forms.Label lblCompnayContact;
        private System.Windows.Forms.Label lblExpectedEndDate;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblProjectLocation;
        private System.Windows.Forms.TextBox textBoxProjectCode;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.TextBox textBoxProjectConsultant;
        private System.Windows.Forms.TextBox textBoxCompanyContact;
        private System.Windows.Forms.TextBox textBoxExpectedEndDate;
        private System.Windows.Forms.TextBox textBoxStartDate;
        private System.Windows.Forms.TextBox textBoxProjectLocation;
        private System.Windows.Forms.Label lblError;
    }
}