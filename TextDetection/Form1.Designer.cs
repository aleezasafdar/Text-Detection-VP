namespace TextDetection
{
    partial class Form1
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
            this.ButtonScan = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonCrop = new System.Windows.Forms.PictureBox();
            this.btn_rotateAntiClock = new System.Windows.Forms.PictureBox();
            this.inputImagebox = new System.Windows.Forms.PictureBox();
            this.btn_rotateClock = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rotateAntiClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImagebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rotateClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSave)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonScan
            // 
            this.ButtonScan.Location = new System.Drawing.Point(251, 26);
            this.ButtonScan.Name = "ButtonScan";
            this.ButtonScan.Size = new System.Drawing.Size(75, 30);
            this.ButtonScan.TabIndex = 0;
            this.ButtonScan.Text = "Scan";
            this.ButtonScan.UseVisualStyleBackColor = true;
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(218, 346);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(108, 23);
            this.buttonUpload.TabIndex = 1;
            this.buttonUpload.Text = "Upload Image";
            this.buttonUpload.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(17, 263);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(309, 77);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // buttonCrop
            // 
            this.buttonCrop.ImageLocation = "C:\\Users\\HIFZA\\Documents\\Visual Studio 2013\\Projects\\TextDetection\\VP Project Fil" +
    "es\\Cropping.jpg";
            this.buttonCrop.Location = new System.Drawing.Point(17, 26);
            this.buttonCrop.Name = "buttonCrop";
            this.buttonCrop.Size = new System.Drawing.Size(31, 30);
            this.buttonCrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonCrop.TabIndex = 3;
            this.buttonCrop.TabStop = false;
            // 
            // btn_rotateAntiClock
            // 
            this.btn_rotateAntiClock.ImageLocation = "C:\\Users\\HIFZA\\Documents\\Visual Studio 2013\\Projects\\TextDetection\\VP Project Fil" +
    "es\\RotateAntiClock.jpg";
            this.btn_rotateAntiClock.Location = new System.Drawing.Point(162, 26);
            this.btn_rotateAntiClock.Name = "btn_rotateAntiClock";
            this.btn_rotateAntiClock.Size = new System.Drawing.Size(31, 30);
            this.btn_rotateAntiClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_rotateAntiClock.TabIndex = 4;
            this.btn_rotateAntiClock.TabStop = false;
            // 
            // inputImagebox
            // 
            this.inputImagebox.Location = new System.Drawing.Point(17, 62);
            this.inputImagebox.Name = "inputImagebox";
            this.inputImagebox.Size = new System.Drawing.Size(309, 195);
            this.inputImagebox.TabIndex = 5;
            this.inputImagebox.TabStop = false;
            // 
            // btn_rotateClock
            // 
            this.btn_rotateClock.ImageLocation = "C:\\Users\\HIFZA\\Documents\\Visual Studio 2013\\Projects\\TextDetection\\VP Project Fil" +
    "es\\RotateClock.jpg";
            this.btn_rotateClock.Location = new System.Drawing.Point(125, 26);
            this.btn_rotateClock.Name = "btn_rotateClock";
            this.btn_rotateClock.Size = new System.Drawing.Size(31, 30);
            this.btn_rotateClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_rotateClock.TabIndex = 6;
            this.btn_rotateClock.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.ImageLocation = "C:\\Users\\HIFZA\\Documents\\Visual Studio 2013\\Projects\\TextDetection\\VP Project Fil" +
    "es\\saving.png";
            this.buttonSave.Location = new System.Drawing.Point(17, 346);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(31, 30);
            this.buttonSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonSave.TabIndex = 7;
            this.buttonSave.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 381);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.btn_rotateClock);
            this.Controls.Add(this.inputImagebox);
            this.Controls.Add(this.btn_rotateAntiClock);
            this.Controls.Add(this.buttonCrop);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.ButtonScan);
            this.Name = "Form1";
            this.Text = "Text Identifer ";
            ((System.ComponentModel.ISupportInitialize)(this.buttonCrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rotateAntiClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImagebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rotateClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonScan;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox buttonCrop;
        private System.Windows.Forms.PictureBox btn_rotateAntiClock;
        private System.Windows.Forms.PictureBox inputImagebox;
        private System.Windows.Forms.PictureBox btn_rotateClock;
        private System.Windows.Forms.PictureBox buttonSave;
    }
}

