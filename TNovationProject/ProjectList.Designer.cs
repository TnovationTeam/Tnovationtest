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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectList));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelHeading = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonArchive = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tNovationDataSet1 = new TNovationProject.TNovationDataSet1();
            this.tblProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProjectTableAdapter = new TNovationProject.TNovationDataSet1TableAdapters.tblProjectTableAdapter();
            this.projectCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectConsultantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNovationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(22, 20);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(94, 74);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 23;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.Navy;
            this.labelHeading.Location = new System.Drawing.Point(134, 20);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(378, 73);
            this.labelHeading.TabIndex = 24;
            this.labelHeading.Text = "T{Novation}";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(610, 119);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 37);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(610, 210);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(88, 33);
            this.buttonUpdate.TabIndex = 30;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonArchive
            // 
            this.buttonArchive.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArchive.Location = new System.Drawing.Point(610, 303);
            this.buttonArchive.Name = "buttonArchive";
            this.buttonArchive.Size = new System.Drawing.Size(88, 34);
            this.buttonArchive.TabIndex = 31;
            this.buttonArchive.Text = "Archive";
            this.buttonArchive.UseVisualStyleBackColor = false;
            this.buttonArchive.Click += new System.EventHandler(this.buttonArchive_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 119);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 290);
            this.listBox1.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectCodeDataGridViewTextBoxColumn,
            this.projectNameDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.projectConsultantDataGridViewTextBoxColumn,
            this.companyContactDataGridViewTextBoxColumn,
            this.expectedEndDateDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.projectLocationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblProjectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(187, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 290);
            this.dataGridView1.TabIndex = 33;
            // 
            // tNovationDataSet1
            // 
            this.tNovationDataSet1.DataSetName = "TNovationDataSet1";
            this.tNovationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProjectBindingSource
            // 
            this.tblProjectBindingSource.DataMember = "tblProject";
            this.tblProjectBindingSource.DataSource = this.tNovationDataSet1;
            // 
            // tblProjectTableAdapter
            // 
            this.tblProjectTableAdapter.ClearBeforeFill = true;
            // 
            // projectCodeDataGridViewTextBoxColumn
            // 
            this.projectCodeDataGridViewTextBoxColumn.DataPropertyName = "ProjectCode";
            this.projectCodeDataGridViewTextBoxColumn.HeaderText = "ProjectCode";
            this.projectCodeDataGridViewTextBoxColumn.Name = "projectCodeDataGridViewTextBoxColumn";
            // 
            // projectNameDataGridViewTextBoxColumn
            // 
            this.projectNameDataGridViewTextBoxColumn.DataPropertyName = "ProjectName";
            this.projectNameDataGridViewTextBoxColumn.HeaderText = "ProjectName";
            this.projectNameDataGridViewTextBoxColumn.Name = "projectNameDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // projectConsultantDataGridViewTextBoxColumn
            // 
            this.projectConsultantDataGridViewTextBoxColumn.DataPropertyName = "ProjectConsultant";
            this.projectConsultantDataGridViewTextBoxColumn.HeaderText = "ProjectConsultant";
            this.projectConsultantDataGridViewTextBoxColumn.Name = "projectConsultantDataGridViewTextBoxColumn";
            // 
            // companyContactDataGridViewTextBoxColumn
            // 
            this.companyContactDataGridViewTextBoxColumn.DataPropertyName = "CompanyContact";
            this.companyContactDataGridViewTextBoxColumn.HeaderText = "CompanyContact";
            this.companyContactDataGridViewTextBoxColumn.Name = "companyContactDataGridViewTextBoxColumn";
            // 
            // expectedEndDateDataGridViewTextBoxColumn
            // 
            this.expectedEndDateDataGridViewTextBoxColumn.DataPropertyName = "ExpectedEndDate";
            this.expectedEndDateDataGridViewTextBoxColumn.HeaderText = "ExpectedEndDate";
            this.expectedEndDateDataGridViewTextBoxColumn.Name = "expectedEndDateDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // projectLocationDataGridViewTextBoxColumn
            // 
            this.projectLocationDataGridViewTextBoxColumn.DataPropertyName = "ProjectLocation";
            this.projectLocationDataGridViewTextBoxColumn.HeaderText = "ProjectLocation";
            this.projectLocationDataGridViewTextBoxColumn.Name = "projectLocationDataGridViewTextBoxColumn";
            // 
            // ProjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 462);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonArchive);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.pictureBoxLogo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProjectList";
            this.Text = "ProjectList";
            this.Load += new System.EventHandler(this.ProjectList_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNovationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonArchive;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TNovationDataSet1 tNovationDataSet1;
        private System.Windows.Forms.BindingSource tblProjectBindingSource;
        private TNovationDataSet1TableAdapters.tblProjectTableAdapter tblProjectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectConsultantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectLocationDataGridViewTextBoxColumn;
    }
}