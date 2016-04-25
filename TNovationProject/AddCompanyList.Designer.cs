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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelHeading = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.PictureBox();
            this.labelClientInformation = new System.Windows.Forms.Label();
            this.dataGridViewC = new System.Windows.Forms.DataGridView();
            this.labelCompanyDetails = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.listboxCompany = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxClientDet = new System.Windows.Forms.TextBox();
            this.buttonClientDet = new System.Windows.Forms.Button();
            this.buttonPopulate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.labelLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewC)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.Navy;
            this.labelHeading.Location = new System.Drawing.Point(298, 32);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(334, 73);
            this.labelHeading.TabIndex = 28;
            this.labelHeading.Text = "TNovation";
            // 
            // labelLogo
            // 
            this.labelLogo.Image = ((System.Drawing.Image)(resources.GetObject("labelLogo.Image")));
            this.labelLogo.Location = new System.Drawing.Point(103, 31);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(164, 74);
            this.labelLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.labelLogo.TabIndex = 27;
            this.labelLogo.TabStop = false;
            // 
            // labelClientInformation
            // 
            this.labelClientInformation.AutoSize = true;
            this.labelClientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientInformation.Location = new System.Drawing.Point(41, 153);
            this.labelClientInformation.Name = "labelClientInformation";
            this.labelClientInformation.Size = new System.Drawing.Size(209, 20);
            this.labelClientInformation.TabIndex = 60;
            this.labelClientInformation.Text = "List company information";
            // 
            // dataGridViewC
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewC.Location = new System.Drawing.Point(203, 208);
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
            this.dataGridViewC.TabIndex = 78;
            // 
            // labelCompanyDetails
            // 
            this.labelCompanyDetails.AutoSize = true;
            this.labelCompanyDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyDetails.ForeColor = System.Drawing.Color.Maroon;
            this.labelCompanyDetails.Location = new System.Drawing.Point(200, 189);
            this.labelCompanyDetails.Name = "labelCompanyDetails";
            this.labelCompanyDetails.Size = new System.Drawing.Size(124, 16);
            this.labelCompanyDetails.TabIndex = 77;
            this.labelCompanyDetails.Text = "Company details";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Maroon;
            this.labelUser.Location = new System.Drawing.Point(21, 189);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(123, 16);
            this.labelUser.TabIndex = 76;
            this.labelUser.Text = "Company names";
            // 
            // listboxCompany
            // 
            this.listboxCompany.FormattingEnabled = true;
            this.listboxCompany.Location = new System.Drawing.Point(21, 208);
            this.listboxCompany.Name = "listboxCompany";
            this.listboxCompany.Size = new System.Drawing.Size(167, 238);
            this.listboxCompany.TabIndex = 75;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(731, 473);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(86, 23);
            this.buttonDelete.TabIndex = 81;
            this.buttonDelete.Text = "Delete Client";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(628, 473);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(86, 23);
            this.buttonUpdate.TabIndex = 80;
            this.buttonUpdate.Text = "Update Client";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(520, 473);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(86, 23);
            this.buttonAdd.TabIndex = 79;
            this.buttonAdd.Text = "Add Client";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxClientDet
            // 
            this.textBoxClientDet.Location = new System.Drawing.Point(18, 473);
            this.textBoxClientDet.Name = "textBoxClientDet";
            this.textBoxClientDet.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientDet.TabIndex = 84;
            // 
            // buttonClientDet
            // 
            this.buttonClientDet.Location = new System.Drawing.Point(124, 473);
            this.buttonClientDet.Name = "buttonClientDet";
            this.buttonClientDet.Size = new System.Drawing.Size(75, 23);
            this.buttonClientDet.TabIndex = 83;
            this.buttonClientDet.Text = "Find client";
            this.buttonClientDet.UseVisualStyleBackColor = true;
            // 
            // buttonPopulate
            // 
            this.buttonPopulate.Location = new System.Drawing.Point(205, 474);
            this.buttonPopulate.Name = "buttonPopulate";
            this.buttonPopulate.Size = new System.Drawing.Size(98, 23);
            this.buttonPopulate.TabIndex = 82;
            this.buttonPopulate.Text = "Populate list box";
            this.buttonPopulate.UseVisualStyleBackColor = true;
            // 
            // AddCompanyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 665);
            this.Controls.Add(this.textBoxClientDet);
            this.Controls.Add(this.buttonClientDet);
            this.Controls.Add(this.buttonPopulate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewC);
            this.Controls.Add(this.labelCompanyDetails);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.listboxCompany);
            this.Controls.Add(this.labelClientInformation);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.labelLogo);
            this.Name = "AddCompanyList";
            this.Text = "AddCompanyList";
            ((System.ComponentModel.ISupportInitialize)(this.labelLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.PictureBox labelLogo;
        private System.Windows.Forms.Label labelClientInformation;
        private System.Windows.Forms.DataGridView dataGridViewC;
        private System.Windows.Forms.Label labelCompanyDetails;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ListBox listboxCompany;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxClientDet;
        private System.Windows.Forms.Button buttonClientDet;
        private System.Windows.Forms.Button buttonPopulate;
    }
}