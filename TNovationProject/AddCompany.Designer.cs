namespace TNovationProject
{
    partial class AddCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCompany));
            this.labelLogo = new System.Windows.Forms.PictureBox();
            this.labelHeading = new System.Windows.Forms.Label();
            this.labelCompanyInformation = new System.Windows.Forms.Label();
            this.textBoxCompanyCode = new System.Windows.Forms.TextBox();
            this.textBoxCompanyAddress = new System.Windows.Forms.TextBox();
            this.textBoxCompanyEmailAddress = new System.Windows.Forms.TextBox();
            this.textBoxInvolvedClient = new System.Windows.Forms.TextBox();
            this.textBoxInvolvedProject = new System.Windows.Forms.TextBox();
            this.textBoxMobileNumber = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelCompanyCode = new System.Windows.Forms.Label();
            this.labelCompanyAddress = new System.Windows.Forms.Label();
            this.labelCompanyEmailAddress = new System.Windows.Forms.Label();
            this.labelInvolvedClient = new System.Windows.Forms.Label();
            this.labelInvolvedProject = new System.Windows.Forms.Label();
            this.labelMobileNumber = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.labelLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogo
            // 
            this.labelLogo.Image = ((System.Drawing.Image)(resources.GetObject("labelLogo.Image")));
            this.labelLogo.Location = new System.Drawing.Point(25, 42);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(164, 74);
            this.labelLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.labelLogo.TabIndex = 24;
            this.labelLogo.TabStop = false;
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.Navy;
            this.labelHeading.Location = new System.Drawing.Point(220, 43);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(334, 73);
            this.labelHeading.TabIndex = 26;
            this.labelHeading.Text = "TNovation";
            // 
            // labelCompanyInformation
            // 
            this.labelCompanyInformation.AutoSize = true;
            this.labelCompanyInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyInformation.Location = new System.Drawing.Point(21, 182);
            this.labelCompanyInformation.Name = "labelCompanyInformation";
            this.labelCompanyInformation.Size = new System.Drawing.Size(212, 20);
            this.labelCompanyInformation.TabIndex = 55;
            this.labelCompanyInformation.Text = "Add company information";
            // 
            // textBoxCompanyCode
            // 
            this.textBoxCompanyCode.Location = new System.Drawing.Point(194, 240);
            this.textBoxCompanyCode.Name = "textBoxCompanyCode";
            this.textBoxCompanyCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompanyCode.TabIndex = 56;
            // 
            // textBoxCompanyAddress
            // 
            this.textBoxCompanyAddress.Location = new System.Drawing.Point(194, 276);
            this.textBoxCompanyAddress.Name = "textBoxCompanyAddress";
            this.textBoxCompanyAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompanyAddress.TabIndex = 57;
            // 
            // textBoxCompanyEmailAddress
            // 
            this.textBoxCompanyEmailAddress.Location = new System.Drawing.Point(194, 314);
            this.textBoxCompanyEmailAddress.Name = "textBoxCompanyEmailAddress";
            this.textBoxCompanyEmailAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompanyEmailAddress.TabIndex = 58;
            // 
            // textBoxInvolvedClient
            // 
            this.textBoxInvolvedClient.Location = new System.Drawing.Point(194, 353);
            this.textBoxInvolvedClient.Name = "textBoxInvolvedClient";
            this.textBoxInvolvedClient.Size = new System.Drawing.Size(100, 20);
            this.textBoxInvolvedClient.TabIndex = 59;
            // 
            // textBoxInvolvedProject
            // 
            this.textBoxInvolvedProject.Location = new System.Drawing.Point(464, 240);
            this.textBoxInvolvedProject.Name = "textBoxInvolvedProject";
            this.textBoxInvolvedProject.Size = new System.Drawing.Size(100, 20);
            this.textBoxInvolvedProject.TabIndex = 60;
            // 
            // textBoxMobileNumber
            // 
            this.textBoxMobileNumber.Location = new System.Drawing.Point(464, 276);
            this.textBoxMobileNumber.Name = "textBoxMobileNumber";
            this.textBoxMobileNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxMobileNumber.TabIndex = 61;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(464, 314);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhoneNumber.TabIndex = 62;
            // 
            // labelCompanyCode
            // 
            this.labelCompanyCode.AutoSize = true;
            this.labelCompanyCode.Location = new System.Drawing.Point(109, 243);
            this.labelCompanyCode.Name = "labelCompanyCode";
            this.labelCompanyCode.Size = new System.Drawing.Size(79, 13);
            this.labelCompanyCode.TabIndex = 63;
            this.labelCompanyCode.Text = "Company Code";
            // 
            // labelCompanyAddress
            // 
            this.labelCompanyAddress.AutoSize = true;
            this.labelCompanyAddress.Location = new System.Drawing.Point(96, 276);
            this.labelCompanyAddress.Name = "labelCompanyAddress";
            this.labelCompanyAddress.Size = new System.Drawing.Size(92, 13);
            this.labelCompanyAddress.TabIndex = 64;
            this.labelCompanyAddress.Text = "Company Address";
            // 
            // labelCompanyEmailAddress
            // 
            this.labelCompanyEmailAddress.AutoSize = true;
            this.labelCompanyEmailAddress.Location = new System.Drawing.Point(68, 317);
            this.labelCompanyEmailAddress.Name = "labelCompanyEmailAddress";
            this.labelCompanyEmailAddress.Size = new System.Drawing.Size(120, 13);
            this.labelCompanyEmailAddress.TabIndex = 65;
            this.labelCompanyEmailAddress.Text = "Company Email Address";
            // 
            // labelInvolvedClient
            // 
            this.labelInvolvedClient.AutoSize = true;
            this.labelInvolvedClient.Location = new System.Drawing.Point(111, 356);
            this.labelInvolvedClient.Name = "labelInvolvedClient";
            this.labelInvolvedClient.Size = new System.Drawing.Size(77, 13);
            this.labelInvolvedClient.TabIndex = 66;
            this.labelInvolvedClient.Text = "Involved Client";
            // 
            // labelInvolvedProject
            // 
            this.labelInvolvedProject.AutoSize = true;
            this.labelInvolvedProject.Location = new System.Drawing.Point(374, 243);
            this.labelInvolvedProject.Name = "labelInvolvedProject";
            this.labelInvolvedProject.Size = new System.Drawing.Size(84, 13);
            this.labelInvolvedProject.TabIndex = 67;
            this.labelInvolvedProject.Text = "Involved Project";
            // 
            // labelMobileNumber
            // 
            this.labelMobileNumber.AutoSize = true;
            this.labelMobileNumber.Location = new System.Drawing.Point(380, 279);
            this.labelMobileNumber.Name = "labelMobileNumber";
            this.labelMobileNumber.Size = new System.Drawing.Size(78, 13);
            this.labelMobileNumber.TabIndex = 68;
            this.labelMobileNumber.Text = "Mobile Number";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(380, 317);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.labelPhoneNumber.TabIndex = 69;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(157, 458);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 70;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(284, 457);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 71;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(401, 457);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 72;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // AddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 544);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelMobileNumber);
            this.Controls.Add(this.labelInvolvedProject);
            this.Controls.Add(this.labelInvolvedClient);
            this.Controls.Add(this.labelCompanyEmailAddress);
            this.Controls.Add(this.labelCompanyAddress);
            this.Controls.Add(this.labelCompanyCode);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxMobileNumber);
            this.Controls.Add(this.textBoxInvolvedProject);
            this.Controls.Add(this.textBoxInvolvedClient);
            this.Controls.Add(this.textBoxCompanyEmailAddress);
            this.Controls.Add(this.textBoxCompanyAddress);
            this.Controls.Add(this.textBoxCompanyCode);
            this.Controls.Add(this.labelCompanyInformation);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.labelLogo);
            this.Name = "AddCompany";
            this.Text = "AddCompany";
            this.Load += new System.EventHandler(this.AddCompany_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.labelLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox labelLogo;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label labelCompanyInformation;
        private System.Windows.Forms.TextBox textBoxCompanyCode;
        private System.Windows.Forms.TextBox textBoxCompanyAddress;
        private System.Windows.Forms.TextBox textBoxCompanyEmailAddress;
        private System.Windows.Forms.TextBox textBoxInvolvedClient;
        private System.Windows.Forms.TextBox textBoxInvolvedProject;
        private System.Windows.Forms.TextBox textBoxMobileNumber;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelCompanyCode;
        private System.Windows.Forms.Label labelCompanyAddress;
        private System.Windows.Forms.Label labelCompanyEmailAddress;
        private System.Windows.Forms.Label labelInvolvedClient;
        private System.Windows.Forms.Label labelInvolvedProject;
        private System.Windows.Forms.Label labelMobileNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonBack;
    }
}