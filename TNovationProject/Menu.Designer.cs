namespace TNovationProject
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonConsultant = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonProject = new System.Windows.Forms.Button();
            this.buttonCompany = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConsultant
            // 
            this.buttonConsultant.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonConsultant.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultant.Location = new System.Drawing.Point(114, 156);
            this.buttonConsultant.Name = "buttonConsultant";
            this.buttonConsultant.Size = new System.Drawing.Size(135, 92);
            this.buttonConsultant.TabIndex = 0;
            this.buttonConsultant.Text = "Consultant";
            this.buttonConsultant.UseVisualStyleBackColor = false;
            this.buttonConsultant.Click += new System.EventHandler(this.buttonConsultant_Click);
            // 
            // buttonEvents
            // 
            this.buttonEvents.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonEvents.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEvents.Location = new System.Drawing.Point(456, 308);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(135, 92);
            this.buttonEvents.TabIndex = 1;
            this.buttonEvents.Text = "Events";
            this.buttonEvents.UseVisualStyleBackColor = false;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // buttonProject
            // 
            this.buttonProject.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonProject.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProject.Location = new System.Drawing.Point(114, 308);
            this.buttonProject.Name = "buttonProject";
            this.buttonProject.Size = new System.Drawing.Size(135, 92);
            this.buttonProject.TabIndex = 2;
            this.buttonProject.Text = "Project";
            this.buttonProject.UseVisualStyleBackColor = false;
            this.buttonProject.Click += new System.EventHandler(this.buttonProject_Click);
            // 
            // buttonCompany
            // 
            this.buttonCompany.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonCompany.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompany.Location = new System.Drawing.Point(292, 229);
            this.buttonCompany.Name = "buttonCompany";
            this.buttonCompany.Size = new System.Drawing.Size(135, 92);
            this.buttonCompany.TabIndex = 3;
            this.buttonCompany.Text = "Company";
            this.buttonCompany.UseVisualStyleBackColor = false;
            this.buttonCompany.Click += new System.EventHandler(this.buttonCompany_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonClient.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.Location = new System.Drawing.Point(456, 156);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(135, 92);
            this.buttonClient.TabIndex = 4;
            this.buttonClient.Text = "Client";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHeading.Location = new System.Drawing.Point(197, 40);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(378, 73);
            this.labelHeading.TabIndex = 70;
            this.labelHeading.Text = "T{Novation}";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(673, 483);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.buttonCompany);
            this.Controls.Add(this.buttonProject);
            this.Controls.Add(this.buttonEvents);
            this.Controls.Add(this.buttonConsultant);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConsultant;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.Button buttonProject;
        private System.Windows.Forms.Button buttonCompany;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHeading;
    }
}