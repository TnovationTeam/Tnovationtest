namespace TNovationProject
{
    partial class AddCompanyList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCompanyList));
            this.labelHeading = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnCompanyCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCompanyAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCompanyEmailAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnInvolvedClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnInvolvedProject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMobileNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.labelLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.Navy;
            this.labelHeading.Location = new System.Drawing.Point(221, 30);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(334, 73);
            this.labelHeading.TabIndex = 28;
            this.labelHeading.Text = "TNovation";
            // 
            // labelLogo
            // 
            this.labelLogo.Image = ((System.Drawing.Image)(resources.GetObject("labelLogo.Image")));
            this.labelLogo.Location = new System.Drawing.Point(26, 29);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(164, 74);
            this.labelLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.labelLogo.TabIndex = 27;
            this.labelLogo.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCompanyCode,
            this.columnCompanyAddress,
            this.columnCompanyEmailAddress,
            this.columnInvolvedClient,
            this.columnInvolvedProject,
            this.columnMobileNumber,
            this.columnPhoneNumber});
            this.listView1.Location = new System.Drawing.Point(26, 136);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(737, 385);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnCompanyCode
            // 
            this.columnCompanyCode.Text = "CompanyCode";
            // 
            // columnCompanyAddress
            // 
            this.columnCompanyAddress.Text = "CompanyAddress";
            // 
            // columnCompanyEmailAddress
            // 
            this.columnCompanyEmailAddress.Text = "CompanyEmailAddress";
            this.columnCompanyEmailAddress.Width = 119;
            // 
            // columnInvolvedClient
            // 
            this.columnInvolvedClient.Text = "InvolvedClient";
            this.columnInvolvedClient.Width = 88;
            // 
            // columnInvolvedProject
            // 
            this.columnInvolvedProject.Text = "InvolvedProject";
            this.columnInvolvedProject.Width = 90;
            // 
            // columnMobileNumber
            // 
            this.columnMobileNumber.Text = "MobileNumber";
            this.columnMobileNumber.Width = 87;
            // 
            // columnPhoneNumber
            // 
            this.columnPhoneNumber.Text = "PhoneNumber";
            this.columnPhoneNumber.Width = 83;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(823, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(823, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(823, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AddCompanyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 601);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.labelLogo);
            this.Name = "AddCompanyList";
            this.Text = "AddCompanyList";
            ((System.ComponentModel.ISupportInitialize)(this.labelLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.PictureBox labelLogo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnCompanyCode;
        private System.Windows.Forms.ColumnHeader columnCompanyAddress;
        private System.Windows.Forms.ColumnHeader columnCompanyEmailAddress;
        private System.Windows.Forms.ColumnHeader columnInvolvedClient;
        private System.Windows.Forms.ColumnHeader columnInvolvedProject;
        private System.Windows.Forms.ColumnHeader columnMobileNumber;
        private System.Windows.Forms.ColumnHeader columnPhoneNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}