namespace TNovationProject
{
    partial class CompanyList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelHeading = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewC = new System.Windows.Forms.DataGridView();
            this.companyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyEmailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.involvedClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.involvedProjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCompanyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tNovationDataSetLATESTAPRIL = new TNovationProject.TNovationDataSetLATESTAPRIL();
            this.tblCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tNovationDataSetFinalHandIN = new TNovationProject.TNovationDataSetFinalHandIN();
            this.labelCompanydetails = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.listboxClient = new System.Windows.Forms.ListBox();
            this.labelCompanyInformation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCompanyDet = new System.Windows.Forms.TextBox();
            this.buttonCompanyDet = new System.Windows.Forms.Button();
            this.buttonPopulate = new System.Windows.Forms.Button();
            this.labelInfo3 = new System.Windows.Forms.Label();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tblCompanyTableAdapter = new TNovationProject.TNovationDataSetFinalHandINTableAdapters.tblCompanyTableAdapter();
            this.tblCompanyTableAdapter1 = new TNovationProject.TNovationDataSetLATESTAPRILTableAdapters.tblCompanyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNovationDataSetLATESTAPRIL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNovationDataSetFinalHandIN)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.Navy;
            this.labelHeading.Location = new System.Drawing.Point(344, 27);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(334, 73);
            this.labelHeading.TabIndex = 71;
            this.labelHeading.Text = "TNovation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(169, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewC
            // 
            this.dataGridViewC.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyCodeDataGridViewTextBoxColumn,
            this.companyAddressDataGridViewTextBoxColumn,
            this.companyEmailAddressDataGridViewTextBoxColumn,
            this.involvedClientDataGridViewTextBoxColumn,
            this.involvedProjectDataGridViewTextBoxColumn,
            this.mobileNumberDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.dataGridViewC.DataSource = this.tblCompanyBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewC.Location = new System.Drawing.Point(219, 196);
            this.dataGridViewC.Name = "dataGridViewC";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewC.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewC.Size = new System.Drawing.Size(1035, 238);
            this.dataGridViewC.TabIndex = 79;
            // 
            // companyCodeDataGridViewTextBoxColumn
            // 
            this.companyCodeDataGridViewTextBoxColumn.DataPropertyName = "CompanyCode";
            this.companyCodeDataGridViewTextBoxColumn.HeaderText = "CompanyCode";
            this.companyCodeDataGridViewTextBoxColumn.Name = "companyCodeDataGridViewTextBoxColumn";
            // 
            // companyAddressDataGridViewTextBoxColumn
            // 
            this.companyAddressDataGridViewTextBoxColumn.DataPropertyName = "CompanyAddress";
            this.companyAddressDataGridViewTextBoxColumn.HeaderText = "CompanyAddress";
            this.companyAddressDataGridViewTextBoxColumn.Name = "companyAddressDataGridViewTextBoxColumn";
            // 
            // companyEmailAddressDataGridViewTextBoxColumn
            // 
            this.companyEmailAddressDataGridViewTextBoxColumn.DataPropertyName = "CompanyEmailAddress";
            this.companyEmailAddressDataGridViewTextBoxColumn.HeaderText = "CompanyEmailAddress";
            this.companyEmailAddressDataGridViewTextBoxColumn.Name = "companyEmailAddressDataGridViewTextBoxColumn";
            // 
            // involvedClientDataGridViewTextBoxColumn
            // 
            this.involvedClientDataGridViewTextBoxColumn.DataPropertyName = "InvolvedClient";
            this.involvedClientDataGridViewTextBoxColumn.HeaderText = "InvolvedClient";
            this.involvedClientDataGridViewTextBoxColumn.Name = "involvedClientDataGridViewTextBoxColumn";
            // 
            // involvedProjectDataGridViewTextBoxColumn
            // 
            this.involvedProjectDataGridViewTextBoxColumn.DataPropertyName = "InvolvedProject";
            this.involvedProjectDataGridViewTextBoxColumn.HeaderText = "InvolvedProject";
            this.involvedProjectDataGridViewTextBoxColumn.Name = "involvedProjectDataGridViewTextBoxColumn";
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            this.mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "MobileNumber";
            this.mobileNumberDataGridViewTextBoxColumn.HeaderText = "MobileNumber";
            this.mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // tblCompanyBindingSource1
            // 
            this.tblCompanyBindingSource1.DataMember = "tblCompany";
            this.tblCompanyBindingSource1.DataSource = this.tNovationDataSetLATESTAPRIL;
            // 
            // tNovationDataSetLATESTAPRIL
            // 
            this.tNovationDataSetLATESTAPRIL.DataSetName = "TNovationDataSetLATESTAPRIL";
            this.tNovationDataSetLATESTAPRIL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCompanyBindingSource
            // 
            this.tblCompanyBindingSource.DataMember = "tblCompany";
            this.tblCompanyBindingSource.DataSource = this.tNovationDataSetFinalHandIN;
            // 
            // tNovationDataSetFinalHandIN
            // 
            this.tNovationDataSetFinalHandIN.DataSetName = "TNovationDataSetFinalHandIN";
            this.tNovationDataSetFinalHandIN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelCompanydetails
            // 
            this.labelCompanydetails.AutoSize = true;
            this.labelCompanydetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanydetails.ForeColor = System.Drawing.Color.Maroon;
            this.labelCompanydetails.Location = new System.Drawing.Point(216, 177);
            this.labelCompanydetails.Name = "labelCompanydetails";
            this.labelCompanydetails.Size = new System.Drawing.Size(124, 16);
            this.labelCompanydetails.TabIndex = 78;
            this.labelCompanydetails.Text = "Company details";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Maroon;
            this.labelUser.Location = new System.Drawing.Point(37, 177);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(123, 16);
            this.labelUser.TabIndex = 77;
            this.labelUser.Text = "Company names";
            // 
            // listboxClient
            // 
            this.listboxClient.FormattingEnabled = true;
            this.listboxClient.Location = new System.Drawing.Point(37, 196);
            this.listboxClient.Name = "listboxClient";
            this.listboxClient.Size = new System.Drawing.Size(167, 238);
            this.listboxClient.TabIndex = 76;
            // 
            // labelCompanyInformation
            // 
            this.labelCompanyInformation.AutoSize = true;
            this.labelCompanyInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyInformation.Location = new System.Drawing.Point(37, 141);
            this.labelCompanyInformation.Name = "labelCompanyInformation";
            this.labelCompanyInformation.Size = new System.Drawing.Size(209, 20);
            this.labelCompanyInformation.TabIndex = 75;
            this.labelCompanyInformation.Text = "List company information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(37, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 36);
            this.label2.TabIndex = 90;
            this.label2.Text = "To find a company, please enter the first name of the company \r\nand it shall be h" +
    "ighlighted.";
            // 
            // textBoxCompanyDet
            // 
            this.textBoxCompanyDet.Location = new System.Drawing.Point(39, 457);
            this.textBoxCompanyDet.Name = "textBoxCompanyDet";
            this.textBoxCompanyDet.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompanyDet.TabIndex = 89;
            // 
            // buttonCompanyDet
            // 
            this.buttonCompanyDet.Location = new System.Drawing.Point(145, 457);
            this.buttonCompanyDet.Name = "buttonCompanyDet";
            this.buttonCompanyDet.Size = new System.Drawing.Size(75, 23);
            this.buttonCompanyDet.TabIndex = 88;
            this.buttonCompanyDet.Text = "Find client";
            this.buttonCompanyDet.UseVisualStyleBackColor = true;
            // 
            // buttonPopulate
            // 
            this.buttonPopulate.Location = new System.Drawing.Point(226, 458);
            this.buttonPopulate.Name = "buttonPopulate";
            this.buttonPopulate.Size = new System.Drawing.Size(98, 23);
            this.buttonPopulate.TabIndex = 87;
            this.buttonPopulate.Text = "Populate list box";
            this.buttonPopulate.UseVisualStyleBackColor = true;
            // 
            // labelInfo3
            // 
            this.labelInfo3.AutoSize = true;
            this.labelInfo3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo3.Location = new System.Drawing.Point(37, 594);
            this.labelInfo3.Name = "labelInfo3";
            this.labelInfo3.Size = new System.Drawing.Size(573, 18);
            this.labelInfo3.TabIndex = 86;
            this.labelInfo3.Text = "To delete, select a record in the listbox on the left and click Delete Company bu" +
    "tton";
            // 
            // labelInfo1
            // 
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo1.Location = new System.Drawing.Point(37, 531);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(347, 18);
            this.labelInfo1.TabIndex = 85;
            this.labelInfo1.Text = "To add a record click on the Add Company button";
            // 
            // labelInfo2
            // 
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo2.Location = new System.Drawing.Point(37, 562);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(583, 18);
            this.labelInfo2.TabIndex = 84;
            this.labelInfo2.Text = "To update, select a record in the listbox on the left and click Update Company bu" +
    "tton";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(45, 462);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 25);
            this.labelError.TabIndex = 83;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(781, 452);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(104, 36);
            this.buttonDelete.TabIndex = 82;
            this.buttonDelete.Text = "Delete Company";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(671, 451);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(104, 37);
            this.buttonUpdate.TabIndex = 81;
            this.buttonUpdate.Text = "Update Company";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(561, 451);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 37);
            this.buttonAdd.TabIndex = 80;
            this.buttonAdd.Text = "Add Company";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tblCompanyTableAdapter
            // 
            this.tblCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // tblCompanyTableAdapter1
            // 
            this.tblCompanyTableAdapter1.ClearBeforeFill = true;
            // 
            // CompanyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 640);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCompanyDet);
            this.Controls.Add(this.buttonCompanyDet);
            this.Controls.Add(this.buttonPopulate);
            this.Controls.Add(this.labelInfo3);
            this.Controls.Add(this.labelInfo1);
            this.Controls.Add(this.labelInfo2);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewC);
            this.Controls.Add(this.labelCompanydetails);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.listboxClient);
            this.Controls.Add(this.labelCompanyInformation);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CompanyList";
            this.Text = "CompanyList";
            this.Load += new System.EventHandler(this.CompanyList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNovationDataSetLATESTAPRIL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNovationDataSetFinalHandIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewC;
        private System.Windows.Forms.Label labelCompanydetails;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ListBox listboxClient;
        private System.Windows.Forms.Label labelCompanyInformation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCompanyDet;
        private System.Windows.Forms.Button buttonCompanyDet;
        private System.Windows.Forms.Button buttonPopulate;
        private System.Windows.Forms.Label labelInfo3;
        private System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private TNovationDataSetFinalHandIN tNovationDataSetFinalHandIN;
        private System.Windows.Forms.BindingSource tblCompanyBindingSource;
        private TNovationDataSetFinalHandINTableAdapters.tblCompanyTableAdapter tblCompanyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyEmailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn involvedClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn involvedProjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private TNovationDataSetLATESTAPRIL tNovationDataSetLATESTAPRIL;
        private System.Windows.Forms.BindingSource tblCompanyBindingSource1;
        private TNovationDataSetLATESTAPRILTableAdapters.tblCompanyTableAdapter tblCompanyTableAdapter1;
    }
}