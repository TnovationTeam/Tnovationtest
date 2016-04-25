namespace TNovationProject
{
    partial class UpdateCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCompany));
            this.labelHeading = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.labelLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.Navy;
            this.labelHeading.Location = new System.Drawing.Point(326, 70);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(334, 73);
            this.labelHeading.TabIndex = 27;
            this.labelHeading.Text = "TNovation";
            // 
            // labelLogo
            // 
            this.labelLogo.Image = ((System.Drawing.Image)(resources.GetObject("labelLogo.Image")));
            this.labelLogo.Location = new System.Drawing.Point(65, 70);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(164, 74);
            this.labelLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.labelLogo.TabIndex = 28;
            this.labelLogo.TabStop = false;
            // 
            // UpdateCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 597);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.labelHeading);
            this.Name = "UpdateCompany";
            this.Text = "UpdateCompany";
            ((System.ComponentModel.ISupportInitialize)(this.labelLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.PictureBox labelLogo;
    }
}