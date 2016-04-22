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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultantList));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelHeading = new System.Windows.Forms.Label();
            this.lblConsultantListInfo = new System.Windows.Forms.Label();
            this.tNovationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.consultantNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursOfWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employmentHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblConsultantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mwenyaConsultantDataSet = new TNovationProject.MwenyaConsultantDataSet();
            this.tblConsultantTableAdapter = new TNovationProject.MwenyaConsultantDataSetTableAdapters.tblConsultantTableAdapter();
            this.tblConsultantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tNovationDataSetsall = new TNovationProject.TNovationDataSetsall();
            this.tblConsultantBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblConsultantTableAdapter1 = new TNovationProject.TNovationDataSetsallTableAdapters.tblConsultantTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNovationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblConsultantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mwenyaConsultantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblConsultantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNovationDataSetsall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblConsultantBindingSource2)).BeginInit();
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
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            // lblConsultantListInfo
            // 
            this.lblConsultantListInfo.AutoSize = true;
            this.lblConsultantListInfo.Location = new System.Drawing.Point(51, 146);
            this.lblConsultantListInfo.Name = "lblConsultantListInfo";
            this.lblConsultantListInfo.Size = new System.Drawing.Size(131, 13);
            this.lblConsultantListInfo.TabIndex = 71;
            this.lblConsultantListInfo.Text = "List Consultant Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.consultantNoDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telephoneNoDataGridViewTextBoxColumn,
            this.emergencyContactDataGridViewTextBoxColumn,
            this.employmentDateDataGridViewTextBoxColumn,
            this.hoursOfWorkDataGridViewTextBoxColumn,
            this.employmentHistoryDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblConsultantBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(912, 250);
            this.dataGridView1.TabIndex = 72;
            // 
            // consultantNoDataGridViewTextBoxColumn
            // 
            this.consultantNoDataGridViewTextBoxColumn.DataPropertyName = "ConsultantNo";
            this.consultantNoDataGridViewTextBoxColumn.HeaderText = "ConsultantNo";
            this.consultantNoDataGridViewTextBoxColumn.Name = "consultantNoDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telephoneNoDataGridViewTextBoxColumn
            // 
            this.telephoneNoDataGridViewTextBoxColumn.DataPropertyName = "TelephoneNo";
            this.telephoneNoDataGridViewTextBoxColumn.HeaderText = "TelephoneNo";
            this.telephoneNoDataGridViewTextBoxColumn.Name = "telephoneNoDataGridViewTextBoxColumn";
            // 
            // emergencyContactDataGridViewTextBoxColumn
            // 
            this.emergencyContactDataGridViewTextBoxColumn.DataPropertyName = "EmergencyContact";
            this.emergencyContactDataGridViewTextBoxColumn.HeaderText = "EmergencyContact";
            this.emergencyContactDataGridViewTextBoxColumn.Name = "emergencyContactDataGridViewTextBoxColumn";
            // 
            // employmentDateDataGridViewTextBoxColumn
            // 
            this.employmentDateDataGridViewTextBoxColumn.DataPropertyName = "EmploymentDate";
            this.employmentDateDataGridViewTextBoxColumn.HeaderText = "EmploymentDate";
            this.employmentDateDataGridViewTextBoxColumn.Name = "employmentDateDataGridViewTextBoxColumn";
            // 
            // hoursOfWorkDataGridViewTextBoxColumn
            // 
            this.hoursOfWorkDataGridViewTextBoxColumn.DataPropertyName = "HoursOfWork";
            this.hoursOfWorkDataGridViewTextBoxColumn.HeaderText = "HoursOfWork";
            this.hoursOfWorkDataGridViewTextBoxColumn.Name = "hoursOfWorkDataGridViewTextBoxColumn";
            // 
            // employmentHistoryDataGridViewTextBoxColumn
            // 
            this.employmentHistoryDataGridViewTextBoxColumn.DataPropertyName = "EmploymentHistory";
            this.employmentHistoryDataGridViewTextBoxColumn.HeaderText = "EmploymentHistory";
            this.employmentHistoryDataGridViewTextBoxColumn.Name = "employmentHistoryDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            // 
            // tblConsultantBindingSource
            // 
            this.tblConsultantBindingSource.DataMember = "tblConsultant";
            this.tblConsultantBindingSource.DataSource = this.mwenyaConsultantDataSet;
            // 
            // mwenyaConsultantDataSet
            // 
            this.mwenyaConsultantDataSet.DataSetName = "MwenyaConsultantDataSet";
            this.mwenyaConsultantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblConsultantTableAdapter
            // 
            this.tblConsultantTableAdapter.ClearBeforeFill = true;
            // 
            // tblConsultantBindingSource1
            // 
            this.tblConsultantBindingSource1.DataMember = "tblConsultant";
            this.tblConsultantBindingSource1.DataSource = this.mwenyaConsultantDataSet;
            // 
            // tNovationDataSetsall
            // 
            this.tNovationDataSetsall.DataSetName = "TNovationDataSetsall";
            this.tNovationDataSetsall.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblConsultantBindingSource2
            // 
            this.tblConsultantBindingSource2.DataMember = "tblConsultant";
            this.tblConsultantBindingSource2.DataSource = this.tNovationDataSetsall;
            // 
            // tblConsultantTableAdapter1
            // 
            this.tblConsultantTableAdapter1.ClearBeforeFill = true;
            // 
            // ConsultantList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 625);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblConsultantListInfo);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ConsultantList";
            this.Text = "ConsultantForm";
            this.Load += new System.EventHandler(this.ConsultantList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNovationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblConsultantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mwenyaConsultantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblConsultantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNovationDataSetsall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblConsultantBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label lblConsultantListInfo;
     
        private System.Windows.Forms.BindingSource tNovationDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MwenyaConsultantDataSet mwenyaConsultantDataSet;
        private System.Windows.Forms.BindingSource tblConsultantBindingSource;
        private MwenyaConsultantDataSetTableAdapters.tblConsultantTableAdapter tblConsultantTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultantNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursOfWorkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employmentHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblConsultantBindingSource1;
        private TNovationDataSetsall tNovationDataSetsall;
        private System.Windows.Forms.BindingSource tblConsultantBindingSource2;
        private TNovationDataSetsallTableAdapters.tblConsultantTableAdapter tblConsultantTableAdapter1;
    }
}