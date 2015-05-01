namespace TextDetection
{
    partial class Text_identifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Text_identifier));
            this.ButtonScan = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.btn_rotateAntiClock = new System.Windows.Forms.PictureBox();
            this.btn_rotateClock = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inputImagebox = new Emgu.CV.UI.ImageBox();
            this.cmp_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rotateAntiClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rotateClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImagebox)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonScan
            // 
            this.ButtonScan.Location = new System.Drawing.Point(251, 41);
            this.ButtonScan.Name = "ButtonScan";
            this.ButtonScan.Size = new System.Drawing.Size(75, 30);
            this.ButtonScan.TabIndex = 0;
            this.ButtonScan.Text = "Scan";
            this.ButtonScan.UseVisualStyleBackColor = true;
            this.ButtonScan.Click += new System.EventHandler(this.ButtonScan_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(218, 346);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(108, 23);
            this.buttonUpload.TabIndex = 1;
            this.buttonUpload.Text = "Upload Image";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OutputTextBox.Location = new System.Drawing.Point(17, 263);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(309, 77);
            this.OutputTextBox.TabIndex = 2;
            this.OutputTextBox.Text = "";
            // 
            // btn_rotateAntiClock
            // 
            this.btn_rotateAntiClock.ImageLocation = "C:\\Users\\HIFZA\\Documents\\Visual Studio 2013\\Projects\\TextDetection\\VP Project Fil" +
    "es\\RotateAnticlock.jpg";
            this.btn_rotateAntiClock.Location = new System.Drawing.Point(54, 41);
            this.btn_rotateAntiClock.Name = "btn_rotateAntiClock";
            this.btn_rotateAntiClock.Size = new System.Drawing.Size(31, 30);
            this.btn_rotateAntiClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_rotateAntiClock.TabIndex = 4;
            this.btn_rotateAntiClock.TabStop = false;
            this.btn_rotateAntiClock.Click += new System.EventHandler(this.btn_rotateAntiClock_Click);
            // 
            // btn_rotateClock
            // 
            this.btn_rotateClock.ImageLocation = "C:\\Users\\HIFZA\\Documents\\Visual Studio 2013\\Projects\\TextDetection\\VP Project Fil" +
    "es\\RotateClock.jpg";
            this.btn_rotateClock.Location = new System.Drawing.Point(17, 41);
            this.btn_rotateClock.Name = "btn_rotateClock";
            this.btn_rotateClock.Size = new System.Drawing.Size(31, 30);
            this.btn_rotateClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_rotateClock.TabIndex = 6;
            this.btn_rotateClock.TabStop = false;
            this.btn_rotateClock.Click += new System.EventHandler(this.btn_rotateClock_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.ImageLocation = "C:\\Users\\HIFZA\\Documents\\Visual Studio 2013\\Projects\\TextDetection\\VP Project Fil" +
    "es\\save.jpg";
            this.buttonSave.Location = new System.Drawing.Point(17, 346);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(31, 30);
            this.buttonSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonSave.TabIndex = 7;
            this.buttonSave.TabStop = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "F:\\VP Project Files\\download.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(277, 375);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // inputImagebox
            // 
            this.inputImagebox.Location = new System.Drawing.Point(17, 77);
            this.inputImagebox.Name = "inputImagebox";
            this.inputImagebox.Size = new System.Drawing.Size(309, 180);
            this.inputImagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inputImagebox.TabIndex = 2;
            this.inputImagebox.TabStop = false;
            // 
            // cmp_btn
            // 
            this.cmp_btn.Location = new System.Drawing.Point(343, 77);
            this.cmp_btn.Name = "cmp_btn";
            this.cmp_btn.Size = new System.Drawing.Size(75, 23);
            this.cmp_btn.TabIndex = 10;
            this.cmp_btn.Text = "Compare";
            this.cmp_btn.UseVisualStyleBackColor = true;
            this.cmp_btn.Click += new System.EventHandler(this.cmp_btn_Click);
            // 
            // Text_identifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(438, 438);
            this.Controls.Add(this.cmp_btn);
            this.Controls.Add(this.inputImagebox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.btn_rotateClock);
            this.Controls.Add(this.btn_rotateAntiClock);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.ButtonScan);
            this.Name = "Text_identifier";
            this.Text = "Text_Identifer ";
            this.Load += new System.EventHandler(this.Text_identifier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_rotateAntiClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rotateClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImagebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonScan;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.PictureBox btn_rotateAntiClock;
        private System.Windows.Forms.PictureBox btn_rotateClock;
        private System.Windows.Forms.PictureBox buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Emgu.CV.UI.ImageBox inputImagebox;
        private System.Windows.Forms.Button cmp_btn;
    }
}

