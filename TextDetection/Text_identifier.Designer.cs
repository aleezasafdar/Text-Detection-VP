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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Text_identifier));
            this.ButtonScan = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonCrop = new System.Windows.Forms.PictureBox();
            this.btn_rotateAntiClock = new System.Windows.Forms.PictureBox();
            this.inputImagebox = new System.Windows.Forms.PictureBox();
            this.btn_rotateClock = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonUndo = new System.Windows.Forms.Button();
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
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox1.Location = new System.Drawing.Point(17, 263);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(309, 77);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // buttonCrop
            // 
            this.buttonCrop.ImageLocation = "C:\\Users\\HIFZA\\Documents\\Visual Studio 2013\\Projects\\TextDetection\\VP Project Fil" +
    "es\\cropping.jpg";
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
    "es\\RotateAnticlock.jpg";
            this.btn_rotateAntiClock.Location = new System.Drawing.Point(162, 26);
            this.btn_rotateAntiClock.Name = "btn_rotateAntiClock";
            this.btn_rotateAntiClock.Size = new System.Drawing.Size(31, 30);
            this.btn_rotateAntiClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_rotateAntiClock.TabIndex = 4;
            this.btn_rotateAntiClock.TabStop = false;
            this.btn_rotateAntiClock.Click += new System.EventHandler(this.btn_rotateAntiClock_Click);
            // 
            // inputImagebox
            // 
            this.inputImagebox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inputImagebox.Location = new System.Drawing.Point(17, 62);
            this.inputImagebox.Name = "inputImagebox";
            this.inputImagebox.Size = new System.Drawing.Size(309, 195);
            this.inputImagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inputImagebox.TabIndex = 5;
            this.inputImagebox.TabStop = false;
            this.inputImagebox.Click += new System.EventHandler(this.inputImagebox_Click);
            this.inputImagebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inputImagebox_MouseDown);
            this.inputImagebox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.inputImagebox_MouseMove);
            this.inputImagebox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.inputImagebox_MouseUp);
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
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // buttonUndo
            // 
            this.buttonUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonUndo.Location = new System.Drawing.Point(55, 26);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(40, 30);
            this.buttonUndo.TabIndex = 8;
            this.buttonUndo.Text = "undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // Text_identifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(347, 381);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.btn_rotateClock);
            this.Controls.Add(this.inputImagebox);
            this.Controls.Add(this.btn_rotateAntiClock);
            this.Controls.Add(this.buttonCrop);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.ButtonScan);
            this.Name = "Text_identifier";
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
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonUndo;
    }
}

