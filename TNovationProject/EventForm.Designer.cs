namespace TNovationProject
{
    partial class EventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtTypeOfEvent = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.textBoxEventCode = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblTypeOfEvent = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEventCode = new System.Windows.Forms.Label();
            this.txtConsultantAttending = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblConsultantAttending = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.buttonBookIn = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(13, 18);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(218, 91);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 22;
            this.picLogo.TabStop = false;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Navy;
            this.lblHeading.Location = new System.Drawing.Point(239, 18);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(466, 91);
            this.lblHeading.TabIndex = 24;
            this.lblHeading.Text = "T{Novation}";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(133, 405);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(196, 22);
            this.txtContact.TabIndex = 34;
            // 
            // txtTypeOfEvent
            // 
            this.txtTypeOfEvent.Location = new System.Drawing.Point(133, 339);
            this.txtTypeOfEvent.Margin = new System.Windows.Forms.Padding(4);
            this.txtTypeOfEvent.Name = "txtTypeOfEvent";
            this.txtTypeOfEvent.Size = new System.Drawing.Size(196, 22);
            this.txtTypeOfEvent.TabIndex = 33;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(133, 269);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(196, 22);
            this.txtStartDate.TabIndex = 32;
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(133, 185);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(196, 22);
            this.txtEventName.TabIndex = 31;
            // 
            // textBoxEventCode
            // 
            this.textBoxEventCode.Location = new System.Drawing.Point(133, 117);
            this.textBoxEventCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEventCode.Name = "textBoxEventCode";
            this.textBoxEventCode.Size = new System.Drawing.Size(196, 22);
            this.textBoxEventCode.TabIndex = 30;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(22, 408);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(68, 17);
            this.lblContact.TabIndex = 29;
            this.lblContact.Text = "Contact:";
            // 
            // lblTypeOfEvent
            // 
            this.lblTypeOfEvent.AutoSize = true;
            this.lblTypeOfEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfEvent.Location = new System.Drawing.Point(7, 343);
            this.lblTypeOfEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeOfEvent.Name = "lblTypeOfEvent";
            this.lblTypeOfEvent.Size = new System.Drawing.Size(114, 17);
            this.lblTypeOfEvent.TabIndex = 28;
            this.lblTypeOfEvent.Text = "Type of Event:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(22, 269);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(87, 17);
            this.lblStartDate.TabIndex = 27;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(22, 185);
            this.lblEventName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(100, 17);
            this.lblEventName.TabIndex = 26;
            this.lblEventName.Text = "Event Name:";
            // 
            // lblEventCode
            // 
            this.lblEventCode.AutoSize = true;
            this.lblEventCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventCode.Location = new System.Drawing.Point(22, 122);
            this.lblEventCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventCode.Name = "lblEventCode";
            this.lblEventCode.Size = new System.Drawing.Size(96, 17);
            this.lblEventCode.TabIndex = 25;
            this.lblEventCode.Text = "Event Code:";
            // 
            // txtConsultantAttending
            // 
            this.txtConsultantAttending.Location = new System.Drawing.Point(415, 339);
            this.txtConsultantAttending.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultantAttending.Multiline = true;
            this.txtConsultantAttending.Name = "txtConsultantAttending";
            this.txtConsultantAttending.Size = new System.Drawing.Size(272, 88);
            this.txtConsultantAttending.TabIndex = 42;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(415, 190);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(272, 85);
            this.txtLocation.TabIndex = 40;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(142, 473);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(204, 22);
            this.txtCompanyName.TabIndex = 39;
            // 
            // lblConsultantAttending
            // 
            this.lblConsultantAttending.AutoSize = true;
            this.lblConsultantAttending.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultantAttending.Location = new System.Drawing.Point(412, 318);
            this.lblConsultantAttending.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsultantAttending.Name = "lblConsultantAttending";
            this.lblConsultantAttending.Size = new System.Drawing.Size(172, 17);
            this.lblConsultantAttending.TabIndex = 38;
            this.lblConsultantAttending.Text = "Consultants Attending:";
            this.lblConsultantAttending.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(412, 169);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(75, 17);
            this.lblLocation.TabIndex = 37;
            this.lblLocation.Text = "Location:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(0, 478);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(125, 17);
            this.lblCompanyName.TabIndex = 35;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // buttonBookIn
            // 
            this.buttonBookIn.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonBookIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBookIn.Location = new System.Drawing.Point(765, 185);
            this.buttonBookIn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBookIn.Name = "buttonBookIn";
            this.buttonBookIn.Size = new System.Drawing.Size(132, 57);
            this.buttonBookIn.TabIndex = 45;
            this.buttonBookIn.Text = "Book In";
            this.buttonBookIn.UseVisualStyleBackColor = false;
            this.buttonBookIn.Click += new System.EventHandler(this.buttonBookIn_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBack.Location = new System.Drawing.Point(765, 405);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(132, 58);
            this.buttonBack.TabIndex = 44;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(765, 269);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(132, 63);
            this.buttonSave.TabIndex = 43;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 556);
            this.Controls.Add(this.buttonBookIn);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.txtConsultantAttending);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblConsultantAttending);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtTypeOfEvent);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.textBoxEventCode);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblTypeOfEvent);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.lblEventCode);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.picLogo);
            this.Name = "EventForm";
            this.Text = "EventForm";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtTypeOfEvent;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox textBoxEventCode;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblTypeOfEvent;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventCode;
        private System.Windows.Forms.TextBox txtConsultantAttending;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblConsultantAttending;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Button buttonBookIn;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSave;
    }
}