﻿namespace TNovationProject
{
    partial class ClientList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelClientInformation = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.labelInfo3 = new System.Windows.Forms.Label();
            this.buttonPopulate = new System.Windows.Forms.Button();
            this.labelFound = new System.Windows.Forms.Label();
            this.listboxClient = new System.Windows.Forms.ListBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelHeading = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewC = new System.Windows.Forms.DataGridView();
            this.clientNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientQualificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tNovationDataSetFinalHandIN = new TNovationProject.TNovationDataSetFinalHandIN();
            this.buttonClientDet = new System.Windows.Forms.Button();
            this.textBoxClientDet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tblClientTableAdapter = new TNovationProject.TNovationDataSetFinalHandINTableAdapters.tblClientTableAdapter();
            this.tNovationDataSetLATESTAPRIL = new TNovationProject.TNovationDataSetLATESTAPRIL();
            this.tblClientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblClientTableAdapter1 = new TNovationProject.TNovationDataSetLATESTAPRILTableAdapters.tblClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNovationDataSetFinalHandIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNovationDataSetLATESTAPRIL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClientInformation
            // 
            this.labelClientInformation.AutoSize = true;
            this.labelClientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientInformation.Location = new System.Drawing.Point(12, 62);
            this.labelClientInformation.Name = "labelClientInformation";
            this.labelClientInformation.Size = new System.Drawing.Size(181, 20);
            this.labelClientInformation.TabIndex = 59;
            this.labelClientInformation.Text = "List client information";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(754, 376);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(86, 23);
            this.buttonDelete.TabIndex = 58;
            this.buttonDelete.Text = "Delete Client";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(651, 376);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(86, 23);
            this.buttonUpdate.TabIndex = 57;
            this.buttonUpdate.Text = "Update Client";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(543, 376);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(86, 23);
            this.buttonAdd.TabIndex = 56;
            this.buttonAdd.Text = "Add Client";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(18, 380);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 25);
            this.labelError.TabIndex = 61;
            // 
            // labelInfo2
            // 
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo2.Location = new System.Drawing.Point(10, 480);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(556, 18);
            this.labelInfo2.TabIndex = 62;
            this.labelInfo2.Text = "To update, select a record in the listbox on the left and click Update Client but" +
    "ton";
            // 
            // labelInfo1
            // 
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo1.Location = new System.Drawing.Point(10, 449);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(320, 18);
            this.labelInfo1.TabIndex = 63;
            this.labelInfo1.Text = "To add a record click on the Add Client button";
            // 
            // labelInfo3
            // 
            this.labelInfo3.AutoSize = true;
            this.labelInfo3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo3.Location = new System.Drawing.Point(10, 512);
            this.labelInfo3.Name = "labelInfo3";
            this.labelInfo3.Size = new System.Drawing.Size(546, 18);
            this.labelInfo3.TabIndex = 64;
            this.labelInfo3.Text = "To delete, select a record in the listbox on the left and click Delete Client but" +
    "ton";
            // 
            // buttonPopulate
            // 
            this.buttonPopulate.Location = new System.Drawing.Point(199, 376);
            this.buttonPopulate.Name = "buttonPopulate";
            this.buttonPopulate.Size = new System.Drawing.Size(98, 23);
            this.buttonPopulate.TabIndex = 65;
            this.buttonPopulate.Text = "Populate list box";
            this.buttonPopulate.UseVisualStyleBackColor = true;
            this.buttonPopulate.Click += new System.EventHandler(this.buttonPopulate_Click);
            // 
            // labelFound
            // 
            this.labelFound.AutoSize = true;
            this.labelFound.Location = new System.Drawing.Point(367, 314);
            this.labelFound.Name = "labelFound";
            this.labelFound.Size = new System.Drawing.Size(0, 13);
            this.labelFound.TabIndex = 66;
            // 
            // listboxClient
            // 
            this.listboxClient.FormattingEnabled = true;
            this.listboxClient.Location = new System.Drawing.Point(12, 117);
            this.listboxClient.Name = "listboxClient";
            this.listboxClient.Size = new System.Drawing.Size(167, 238);
            this.listboxClient.TabIndex = 60;
            this.listboxClient.SelectedIndexChanged += new System.EventHandler(this.listboxClient_SelectedIndexChanged);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Maroon;
            this.labelUser.Location = new System.Drawing.Point(12, 98);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(97, 16);
            this.labelUser.TabIndex = 67;
            this.labelUser.Text = "Client names";
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.Navy;
            this.labelHeading.Location = new System.Drawing.Point(558, 9);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(334, 73);
            this.labelHeading.TabIndex = 69;
            this.labelHeading.Text = "TNovation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(383, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(191, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 71;
            this.label1.Text = "Client details";
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
            this.clientNoDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientEmailDataGridViewTextBoxColumn,
            this.clientPositionDataGridViewTextBoxColumn,
            this.clientQualificationDataGridViewTextBoxColumn,
            this.clientServiceDataGridViewTextBoxColumn,
            this.clientAddressDataGridViewTextBoxColumn,
            this.clientTelDataGridViewTextBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.dataGridViewC.DataSource = this.tblClientBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewC.Location = new System.Drawing.Point(194, 117);
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
            this.dataGridViewC.TabIndex = 74;
            // 
            // clientNoDataGridViewTextBoxColumn
            // 
            this.clientNoDataGridViewTextBoxColumn.DataPropertyName = "ClientNo";
            this.clientNoDataGridViewTextBoxColumn.HeaderText = "ClientNo";
            this.clientNoDataGridViewTextBoxColumn.Name = "clientNoDataGridViewTextBoxColumn";
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            // 
            // clientEmailDataGridViewTextBoxColumn
            // 
            this.clientEmailDataGridViewTextBoxColumn.DataPropertyName = "ClientEmail";
            this.clientEmailDataGridViewTextBoxColumn.HeaderText = "ClientEmail";
            this.clientEmailDataGridViewTextBoxColumn.Name = "clientEmailDataGridViewTextBoxColumn";
            // 
            // clientPositionDataGridViewTextBoxColumn
            // 
            this.clientPositionDataGridViewTextBoxColumn.DataPropertyName = "ClientPosition";
            this.clientPositionDataGridViewTextBoxColumn.HeaderText = "ClientPosition";
            this.clientPositionDataGridViewTextBoxColumn.Name = "clientPositionDataGridViewTextBoxColumn";
            // 
            // clientQualificationDataGridViewTextBoxColumn
            // 
            this.clientQualificationDataGridViewTextBoxColumn.DataPropertyName = "ClientQualification";
            this.clientQualificationDataGridViewTextBoxColumn.HeaderText = "ClientQualification";
            this.clientQualificationDataGridViewTextBoxColumn.Name = "clientQualificationDataGridViewTextBoxColumn";
            // 
            // clientServiceDataGridViewTextBoxColumn
            // 
            this.clientServiceDataGridViewTextBoxColumn.DataPropertyName = "ClientService";
            this.clientServiceDataGridViewTextBoxColumn.HeaderText = "ClientService";
            this.clientServiceDataGridViewTextBoxColumn.Name = "clientServiceDataGridViewTextBoxColumn";
            // 
            // clientAddressDataGridViewTextBoxColumn
            // 
            this.clientAddressDataGridViewTextBoxColumn.DataPropertyName = "ClientAddress";
            this.clientAddressDataGridViewTextBoxColumn.HeaderText = "ClientAddress";
            this.clientAddressDataGridViewTextBoxColumn.Name = "clientAddressDataGridViewTextBoxColumn";
            // 
            // clientTelDataGridViewTextBoxColumn
            // 
            this.clientTelDataGridViewTextBoxColumn.DataPropertyName = "ClientTel";
            this.clientTelDataGridViewTextBoxColumn.HeaderText = "ClientTel";
            this.clientTelDataGridViewTextBoxColumn.Name = "clientTelDataGridViewTextBoxColumn";
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            // 
            // tblClientBindingSource
            // 
            this.tblClientBindingSource.DataMember = "tblClient";
            this.tblClientBindingSource.DataSource = this.tNovationDataSetFinalHandIN;
            // 
            // tNovationDataSetFinalHandIN
            // 
            this.tNovationDataSetFinalHandIN.DataSetName = "TNovationDataSetFinalHandIN";
            this.tNovationDataSetFinalHandIN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonClientDet
            // 
            this.buttonClientDet.Location = new System.Drawing.Point(118, 375);
            this.buttonClientDet.Name = "buttonClientDet";
            this.buttonClientDet.Size = new System.Drawing.Size(75, 23);
            this.buttonClientDet.TabIndex = 75;
            this.buttonClientDet.Text = "Find client";
            this.buttonClientDet.UseVisualStyleBackColor = true;
            this.buttonClientDet.Click += new System.EventHandler(this.buttonClientDet_Click);
            // 
            // textBoxClientDet
            // 
            this.textBoxClientDet.Location = new System.Drawing.Point(12, 375);
            this.textBoxClientDet.Name = "textBoxClientDet";
            this.textBoxClientDet.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientDet.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(10, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 36);
            this.label2.TabIndex = 77;
            this.label2.Text = "To find a client, please enter the first name of the client \r\nand it will be high" +
    "lighted.";
            // 
            // tblClientTableAdapter
            // 
            this.tblClientTableAdapter.ClearBeforeFill = true;
            // 
            // tNovationDataSetLATESTAPRIL
            // 
            this.tNovationDataSetLATESTAPRIL.DataSetName = "TNovationDataSetLATESTAPRIL";
            this.tNovationDataSetLATESTAPRIL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblClientBindingSource1
            // 
            this.tblClientBindingSource1.DataMember = "tblClient";
            this.tblClientBindingSource1.DataSource = this.tNovationDataSetLATESTAPRIL;
            // 
            // tblClientTableAdapter1
            // 
            this.tblClientTableAdapter1.ClearBeforeFill = true;
            // 
            // ClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1241, 565);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxClientDet);
            this.Controls.Add(this.buttonClientDet);
            this.Controls.Add(this.dataGridViewC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelFound);
            this.Controls.Add(this.buttonPopulate);
            this.Controls.Add(this.labelInfo3);
            this.Controls.Add(this.labelInfo1);
            this.Controls.Add(this.labelInfo2);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.listboxClient);
            this.Controls.Add(this.labelClientInformation);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ClientList";
            this.Text = "ClientList";
            this.Load += new System.EventHandler(this.ClientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNovationDataSetFinalHandIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNovationDataSetLATESTAPRIL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClientInformation;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.Label labelInfo3;
        private System.Windows.Forms.Button buttonPopulate;
        private System.Windows.Forms.Label labelFound;
        private System.Windows.Forms.ListBox listboxClient;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.PictureBox pictureBox1;
      
     
        private System.Windows.Forms.Label label1;
            
           
    
 
        private System.Windows.Forms.DataGridView dataGridViewC;
        private System.Windows.Forms.Button buttonClientDet;
        private System.Windows.Forms.TextBox textBoxClientDet;
        private System.Windows.Forms.Label label2;
        private TNovationDataSetFinalHandIN tNovationDataSetFinalHandIN;
        private System.Windows.Forms.BindingSource tblClientBindingSource;
        private TNovationDataSetFinalHandINTableAdapters.tblClientTableAdapter tblClientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientQualificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private TNovationDataSetLATESTAPRIL tNovationDataSetLATESTAPRIL;
        private System.Windows.Forms.BindingSource tblClientBindingSource1;
        private TNovationDataSetLATESTAPRILTableAdapters.tblClientTableAdapter tblClientTableAdapter1;
    }
}