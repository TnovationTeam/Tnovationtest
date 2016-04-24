namespace TNovationProject
{
    partial class EventList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventList));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHeading = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonArchive = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listboxEvent = new System.Windows.Forms.ListBox();
            this.buttonPopulate = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.Navy;
            this.labelHeading.Location = new System.Drawing.Point(160, 30);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(378, 73);
            this.labelHeading.TabIndex = 23;
            this.labelHeading.Text = "T{Novation}";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(643, 227);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(88, 33);
            this.buttonUpdate.TabIndex = 29;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBack.Location = new System.Drawing.Point(643, 410);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(88, 31);
            this.buttonBack.TabIndex = 28;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonArchive
            // 
            this.buttonArchive.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArchive.Location = new System.Drawing.Point(643, 315);
            this.buttonArchive.Name = "buttonArchive";
            this.buttonArchive.Size = new System.Drawing.Size(88, 34);
            this.buttonArchive.TabIndex = 27;
            this.buttonArchive.Text = "Archive";
            this.buttonArchive.UseVisualStyleBackColor = false;
            this.buttonArchive.Click += new System.EventHandler(this.buttonArchive_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(643, 139);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 37);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listboxEvent
            // 
            this.listboxEvent.FormattingEnabled = true;
            this.listboxEvent.Location = new System.Drawing.Point(12, 160);
            this.listboxEvent.Name = "listboxEvent";
            this.listboxEvent.Size = new System.Drawing.Size(380, 212);
            this.listboxEvent.TabIndex = 30;
            this.listboxEvent.SelectedIndexChanged += new System.EventHandler(this.listBoxEvent_SelectedIndexChanged);
            // 
            // buttonPopulate
            // 
            this.buttonPopulate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonPopulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPopulate.Location = new System.Drawing.Point(12, 404);
            this.buttonPopulate.Name = "buttonPopulate";
            this.buttonPopulate.Size = new System.Drawing.Size(88, 37);
            this.buttonPopulate.TabIndex = 31;
            this.buttonPopulate.Text = "Populate";
            this.buttonPopulate.UseVisualStyleBackColor = false;
            this.buttonPopulate.Click += new System.EventHandler(this.buttonPopulate_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(210, 414);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(29, 13);
            this.labelError.TabIndex = 32;
            this.labelError.Text = "Error";
            // 
            // EventList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 464);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonPopulate);
            this.Controls.Add(this.listboxEvent);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonArchive);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EventList";
            this.Text = "EventList";
            this.Load += new System.EventHandler(this.EventList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHeading;
        //private System.Windows.Forms.BindingSource tNovationDataSetBindingSource;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonArchive;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listboxEvent;
        private System.Windows.Forms.Button buttonPopulate;
        private System.Windows.Forms.Label labelError;
    }
}