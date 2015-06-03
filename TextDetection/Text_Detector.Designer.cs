namespace TextDetection
{
    partial class Text_Detector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Text_Detector));
            this.btn_rotateClock = new System.Windows.Forms.PictureBox();
            this.btn_rotateAntiClock = new System.Windows.Forms.PictureBox();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.PictureBox();
            this.ButtonScan = new System.Windows.Forms.Button();
            this.inputImageBox = new System.Windows.Forms.PictureBox();
            this.Uploadbtn = new System.Windows.Forms.Button();
            this.Confidencebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Mainmenu_return = new System.Windows.Forms.PictureBox();
            this.blurBtn = new System.Windows.Forms.Button();
            this.sepiaBtn = new System.Windows.Forms.Button();
            this.Cropbtn = new System.Windows.Forms.Button();
            this.Sharp_btn = new System.Windows.Forms.Button();
            this.Defaultbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rotateClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rotateAntiClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mainmenu_return)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_rotateClock
            // 
            this.btn_rotateClock.ImageLocation = "C:\\Users\\HIFZA\\Documents\\Visual Studio 2013\\Projects\\TextDetection\\VP Project Fil" +
    "es\\RotateClock.jpg";
            this.btn_rotateClock.Location = new System.Drawing.Point(97, 12);
            this.btn_rotateClock.Name = "btn_rotateClock";
            this.btn_rotateClock.Size = new System.Drawing.Size(31, 30);
            this.btn_rotateClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_rotateClock.TabIndex = 7;
            this.btn_rotateClock.TabStop = false;
            this.btn_rotateClock.Click += new System.EventHandler(this.btn_rotateClock_Click);
            // 
            // btn_rotateAntiClock
            // 
            this.btn_rotateAntiClock.ImageLocation = "C:\\Users\\HIFZA\\Documents\\Visual Studio 2013\\Projects\\TextDetection\\VP Project Fil" +
    "es\\RotateAnticlock.jpg";
            this.btn_rotateAntiClock.Location = new System.Drawing.Point(152, 12);
            this.btn_rotateAntiClock.Name = "btn_rotateAntiClock";
            this.btn_rotateAntiClock.Size = new System.Drawing.Size(31, 30);
            this.btn_rotateAntiClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_rotateAntiClock.TabIndex = 8;
            this.btn_rotateAntiClock.TabStop = false;
            this.btn_rotateAntiClock.Click += new System.EventHandler(this.btn_rotateAntiClock_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OutputTextBox.Location = new System.Drawing.Point(37, 327);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(439, 76);
            this.OutputTextBox.TabIndex = 9;
            this.OutputTextBox.Text = "";
            // 
            // buttonSave
            // 
            this.buttonSave.ImageLocation = "C:\\Users\\HIFZA\\Documents\\Visual Studio 2013\\Projects\\TextDetection\\VP Project Fil" +
    "es\\save.jpg";
            this.buttonSave.Location = new System.Drawing.Point(46, 428);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(52, 41);
            this.buttonSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonSave.TabIndex = 11;
            this.buttonSave.TabStop = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ButtonScan
            // 
            this.ButtonScan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonScan.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ButtonScan.Location = new System.Drawing.Point(520, 423);
            this.ButtonScan.Name = "ButtonScan";
            this.ButtonScan.Size = new System.Drawing.Size(108, 35);
            this.ButtonScan.TabIndex = 12;
            this.ButtonScan.Text = "Scan";
            this.ButtonScan.UseVisualStyleBackColor = false;
            this.ButtonScan.Click += new System.EventHandler(this.ButtonScan_Click);
            // 
            // inputImageBox
            // 
            this.inputImageBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inputImageBox.Location = new System.Drawing.Point(37, 48);
            this.inputImageBox.Name = "inputImageBox";
            this.inputImageBox.Size = new System.Drawing.Size(439, 273);
            this.inputImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inputImageBox.TabIndex = 13;
            this.inputImageBox.TabStop = false;
            this.inputImageBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inputImageBox_MouseDown);
            this.inputImageBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.inputImageBox_MouseUp);
            // 
            // Uploadbtn
            // 
            this.Uploadbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Uploadbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uploadbtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Uploadbtn.Location = new System.Drawing.Point(370, 423);
            this.Uploadbtn.Name = "Uploadbtn";
            this.Uploadbtn.Size = new System.Drawing.Size(106, 35);
            this.Uploadbtn.TabIndex = 14;
            this.Uploadbtn.Text = "Upload";
            this.Uploadbtn.UseVisualStyleBackColor = false;
            this.Uploadbtn.Click += new System.EventHandler(this.Uploadbtn_Click);
            // 
            // Confidencebox
            // 
            this.Confidencebox.AccessibleName = "tu";
            this.Confidencebox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Confidencebox.Location = new System.Drawing.Point(531, 48);
            this.Confidencebox.Multiline = true;
            this.Confidencebox.Name = "Confidencebox";
            this.Confidencebox.Size = new System.Drawing.Size(97, 73);
            this.Confidencebox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(528, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Confidence";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mainmenu_return
            // 
            this.Mainmenu_return.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Mainmenu_return.ErrorImage")));
            this.Mainmenu_return.ImageLocation = "F:\\VP temp\\home.jpg";
            this.Mainmenu_return.InitialImage = ((System.Drawing.Image)(resources.GetObject("Mainmenu_return.InitialImage")));
            this.Mainmenu_return.Location = new System.Drawing.Point(12, 2);
            this.Mainmenu_return.Name = "Mainmenu_return";
            this.Mainmenu_return.Size = new System.Drawing.Size(65, 40);
            this.Mainmenu_return.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mainmenu_return.TabIndex = 17;
            this.Mainmenu_return.TabStop = false;
            this.Mainmenu_return.Click += new System.EventHandler(this.Mainmenu_return_Click);
            // 
            // blurBtn
            // 
            this.blurBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blurBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.blurBtn.Location = new System.Drawing.Point(531, 127);
            this.blurBtn.Name = "blurBtn";
            this.blurBtn.Size = new System.Drawing.Size(97, 35);
            this.blurBtn.TabIndex = 18;
            this.blurBtn.Text = "Blur";
            this.blurBtn.UseVisualStyleBackColor = true;
            this.blurBtn.Click += new System.EventHandler(this.blurBtn_Click);
            // 
            // sepiaBtn
            // 
            this.sepiaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sepiaBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.sepiaBtn.Location = new System.Drawing.Point(531, 168);
            this.sepiaBtn.Name = "sepiaBtn";
            this.sepiaBtn.Size = new System.Drawing.Size(97, 39);
            this.sepiaBtn.TabIndex = 19;
            this.sepiaBtn.Text = "Sepia";
            this.sepiaBtn.UseVisualStyleBackColor = true;
            this.sepiaBtn.Click += new System.EventHandler(this.sepiaBtn_Click);
            // 
            // Cropbtn
            // 
            this.Cropbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cropbtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Cropbtn.Location = new System.Drawing.Point(531, 213);
            this.Cropbtn.Name = "Cropbtn";
            this.Cropbtn.Size = new System.Drawing.Size(97, 39);
            this.Cropbtn.TabIndex = 20;
            this.Cropbtn.Text = "Crop";
            this.Cropbtn.UseVisualStyleBackColor = true;
            this.Cropbtn.Click += new System.EventHandler(this.Cropbtn_Click);
            // 
            // Sharp_btn
            // 
            this.Sharp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sharp_btn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Sharp_btn.Location = new System.Drawing.Point(531, 293);
            this.Sharp_btn.Name = "Sharp_btn";
            this.Sharp_btn.Size = new System.Drawing.Size(97, 37);
            this.Sharp_btn.TabIndex = 22;
            this.Sharp_btn.Text = "Sharp";
            this.Sharp_btn.UseVisualStyleBackColor = true;
            this.Sharp_btn.Click += new System.EventHandler(this.Sharp_btn_Click);
            // 
            // Defaultbtn
            // 
            this.Defaultbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Defaultbtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Defaultbtn.Location = new System.Drawing.Point(531, 347);
            this.Defaultbtn.Name = "Defaultbtn";
            this.Defaultbtn.Size = new System.Drawing.Size(97, 37);
            this.Defaultbtn.TabIndex = 23;
            this.Defaultbtn.Text = "Default";
            this.Defaultbtn.UseVisualStyleBackColor = true;
            this.Defaultbtn.Click += new System.EventHandler(this.Defaultbtn_Click);
            // 
            // Text_Detector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(866, 507);
            this.Controls.Add(this.Defaultbtn);
            this.Controls.Add(this.Sharp_btn);
            this.Controls.Add(this.Cropbtn);
            this.Controls.Add(this.sepiaBtn);
            this.Controls.Add(this.blurBtn);
            this.Controls.Add(this.Mainmenu_return);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Confidencebox);
            this.Controls.Add(this.Uploadbtn);
            this.Controls.Add(this.inputImageBox);
            this.Controls.Add(this.ButtonScan);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.btn_rotateAntiClock);
            this.Controls.Add(this.btn_rotateClock);
            this.Name = "Text_Detector";
            this.Text = "Text_Detector";
            ((System.ComponentModel.ISupportInitialize)(this.btn_rotateClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rotateAntiClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mainmenu_return)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_rotateClock;
        private System.Windows.Forms.PictureBox btn_rotateAntiClock;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.PictureBox buttonSave;
        private System.Windows.Forms.Button ButtonScan;
        private System.Windows.Forms.PictureBox inputImageBox;
        private System.Windows.Forms.Button Uploadbtn;
        private System.Windows.Forms.TextBox Confidencebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox Mainmenu_return;
        private System.Windows.Forms.Button blurBtn;
        private System.Windows.Forms.Button sepiaBtn;
        private System.Windows.Forms.Button Cropbtn;
        private System.Windows.Forms.Button Sharp_btn;
        private System.Windows.Forms.Button Defaultbtn;
    }
}