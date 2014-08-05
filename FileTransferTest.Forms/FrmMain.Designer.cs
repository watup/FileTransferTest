namespace FileTransferTest.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtFilesToSendLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendTheCrap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSendResponse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilesToSendLocation
            // 
            this.txtFilesToSendLocation.Location = new System.Drawing.Point(38, 35);
            this.txtFilesToSendLocation.Name = "txtFilesToSendLocation";
            this.txtFilesToSendLocation.Size = new System.Drawing.Size(593, 20);
            this.txtFilesToSendLocation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "get the files from here:";
            // 
            // btnSendTheCrap
            // 
            this.btnSendTheCrap.Location = new System.Drawing.Point(38, 75);
            this.btnSendTheCrap.Name = "btnSendTheCrap";
            this.btnSendTheCrap.Size = new System.Drawing.Size(488, 89);
            this.btnSendTheCrap.TabIndex = 2;
            this.btnSendTheCrap.Text = "LETS DO THIS THING RRAARGGGHH!!!!";
            this.btnSendTheCrap.UseVisualStyleBackColor = true;
            this.btnSendTheCrap.Click += new System.EventHandler(this.btnSendTheCrap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(531, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblSendResponse
            // 
            this.lblSendResponse.Location = new System.Drawing.Point(70, 181);
            this.lblSendResponse.Name = "lblSendResponse";
            this.lblSendResponse.Size = new System.Drawing.Size(413, 23);
            this.lblSendResponse.TabIndex = 4;
            this.lblSendResponse.Text = "I\'m so excited.";
            this.lblSendResponse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(675, 232);
            this.Controls.Add(this.lblSendResponse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSendTheCrap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilesToSendLocation);
            this.Name = "FrmMain";
            this.Text = "Hold on to your hat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilesToSendLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendTheCrap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSendResponse;
    }
}

