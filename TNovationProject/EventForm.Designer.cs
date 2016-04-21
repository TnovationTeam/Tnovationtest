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
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxTypeOfEvent = new System.Windows.Forms.TextBox();
            this.textBoxStartDate = new System.Windows.Forms.TextBox();
            this.textBoxEventName = new System.Windows.Forms.TextBox();
            this.textBoxEventCode = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblTypeOfEvent = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEventCode = new System.Windows.Forms.Label();
            this.textBoxConsultantAttending = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.lblConsultantAttending = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.buttonBookIn = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxGuestSpeaker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(10, 15);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(164, 74);
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
            this.lblHeading.Location = new System.Drawing.Point(179, 15);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(378, 73);
            this.lblHeading.TabIndex = 24;
            this.lblHeading.Text = "T{Novation}";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(100, 329);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(148, 20);
            this.textBoxContact.TabIndex = 34;
            // 
            // textBoxTypeOfEvent
            // 
            this.textBoxTypeOfEvent.Location = new System.Drawing.Point(100, 275);
            this.textBoxTypeOfEvent.Name = "textBoxTypeOfEvent";
            this.textBoxTypeOfEvent.Size = new System.Drawing.Size(148, 20);
            this.textBoxTypeOfEvent.TabIndex = 33;
            // 
            // textBoxStartDate
            // 
            this.textBoxStartDate.Location = new System.Drawing.Point(100, 219);
            this.textBoxStartDate.Name = "textBoxStartDate";
            this.textBoxStartDate.Size = new System.Drawing.Size(148, 20);
            this.textBoxStartDate.TabIndex = 32;
            // 
            // textBoxEventName
            // 
            this.textBoxEventName.Location = new System.Drawing.Point(100, 150);
            this.textBoxEventName.Name = "textBoxEventName";
            this.textBoxEventName.Size = new System.Drawing.Size(148, 20);
            this.textBoxEventName.TabIndex = 31;
            // 
            // textBoxEventCode
            // 
            this.textBoxEventCode.Location = new System.Drawing.Point(100, 95);
            this.textBoxEventCode.Name = "textBoxEventCode";
            this.textBoxEventCode.Size = new System.Drawing.Size(148, 20);
            this.textBoxEventCode.TabIndex = 30;
            this.textBoxEventCode.TextChanged += new System.EventHandler(this.textBoxEventCode_TextChanged);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(16, 332);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(55, 13);
            this.lblContact.TabIndex = 29;
            this.lblContact.Text = "Contact:";
            // 
            // lblTypeOfEvent
            // 
            this.lblTypeOfEvent.AutoSize = true;
            this.lblTypeOfEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfEvent.Location = new System.Drawing.Point(5, 279);
            this.lblTypeOfEvent.Name = "lblTypeOfEvent";
            this.lblTypeOfEvent.Size = new System.Drawing.Size(91, 13);
            this.lblTypeOfEvent.TabIndex = 28;
            this.lblTypeOfEvent.Text = "Type of Event:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(16, 219);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(69, 13);
            this.lblStartDate.TabIndex = 27;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(16, 150);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(80, 13);
            this.lblEventName.TabIndex = 26;
            this.lblEventName.Text = "Event Name:";
            // 
            // lblEventCode
            // 
            this.lblEventCode.AutoSize = true;
            this.lblEventCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventCode.Location = new System.Drawing.Point(16, 99);
            this.lblEventCode.Name = "lblEventCode";
            this.lblEventCode.Size = new System.Drawing.Size(77, 13);
            this.lblEventCode.TabIndex = 25;
            this.lblEventCode.Text = "Event Code:";
            // 
            // textBoxConsultantAttending
            // 
            this.textBoxConsultantAttending.Location = new System.Drawing.Point(311, 275);
            this.textBoxConsultantAttending.Multiline = true;
            this.textBoxConsultantAttending.Name = "textBoxConsultantAttending";
            this.textBoxConsultantAttending.Size = new System.Drawing.Size(205, 72);
            this.textBoxConsultantAttending.TabIndex = 42;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(311, 154);
            this.textBoxLocation.Multiline = true;
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(205, 70);
            this.textBoxLocation.TabIndex = 40;
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(106, 384);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(154, 20);
            this.textBoxCompanyName.TabIndex = 39;
            // 
            // lblConsultantAttending
            // 
            this.lblConsultantAttending.AutoSize = true;
            this.lblConsultantAttending.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultantAttending.Location = new System.Drawing.Point(309, 258);
            this.lblConsultantAttending.Name = "lblConsultantAttending";
            this.lblConsultantAttending.Size = new System.Drawing.Size(135, 13);
            this.lblConsultantAttending.TabIndex = 38;
            this.lblConsultantAttending.Text = "Consultants Attending:";
            this.lblConsultantAttending.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(309, 137);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(60, 13);
            this.lblLocation.TabIndex = 37;
            this.lblLocation.Text = "Location:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(0, 388);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(98, 13);
            this.lblCompanyName.TabIndex = 35;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // buttonBookIn
            // 
            this.buttonBookIn.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonBookIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBookIn.Location = new System.Drawing.Point(574, 279);
            this.buttonBookIn.Name = "buttonBookIn";
            this.buttonBookIn.Size = new System.Drawing.Size(99, 46);
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
            this.buttonBack.Location = new System.Drawing.Point(574, 384);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(99, 47);
            this.buttonBack.TabIndex = 44;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(417, 382);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(99, 51);
            this.buttonSave.TabIndex = 43;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(574, 187);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(99, 45);
            this.buttonAdd.TabIndex = 46;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxGuestSpeaker
            // 
            this.textBoxGuestSpeaker.Location = new System.Drawing.Point(112, 427);
            this.textBoxGuestSpeaker.Name = "textBoxGuestSpeaker";
            this.textBoxGuestSpeaker.Size = new System.Drawing.Size(148, 20);
            this.textBoxGuestSpeaker.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Guest Speaker:";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Maroon;
            this.labelError.Location = new System.Drawing.Point(274, 482);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(69, 13);
            this.labelError.TabIndex = 49;
            this.labelError.Text = "[labelError]";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 513);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGuestSpeaker);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonBookIn);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxConsultantAttending);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.lblConsultantAttending);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.textBoxTypeOfEvent);
            this.Controls.Add(this.textBoxStartDate);
            this.Controls.Add(this.textBoxEventName);
            this.Controls.Add(this.textBoxEventCode);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblTypeOfEvent);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.lblEventCode);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.picLogo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxTypeOfEvent;
        private System.Windows.Forms.TextBox textBoxStartDate;
        private System.Windows.Forms.TextBox textBoxEventName;
        private System.Windows.Forms.TextBox textBoxEventCode;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblTypeOfEvent;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventCode;
        private System.Windows.Forms.TextBox textBoxConsultantAttending;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Label lblConsultantAttending;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Button buttonBookIn;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxGuestSpeaker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelError;
    }
}