namespace TextDetection
{
    partial class MM_help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MM_help));
            this.Help = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Help_menu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Help_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // Help
            // 
            this.Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Help.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Help.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Help.Location = new System.Drawing.Point(178, 62);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(114, 32);
            this.Help.TabIndex = 1;
            this.Help.Text = "Help";
            this.Help.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.Location = new System.Drawing.Point(29, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(391, 200);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Help_menu
            // 
            this.Help_menu.ImageLocation = "F:\\VP Project Files\\download.jpg";
            this.Help_menu.Location = new System.Drawing.Point(29, 286);
            this.Help_menu.Name = "Help_menu";
            this.Help_menu.Size = new System.Drawing.Size(67, 38);
            this.Help_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Help_menu.TabIndex = 3;
            this.Help_menu.TabStop = false;
            this.Help_menu.Click += new System.EventHandler(this.Help_menu_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Engravers MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Help";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MM_help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(474, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Help_menu);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Help);
            this.Name = "MM_help";
            this.Text = "MM_help";
            ((System.ComponentModel.ISupportInitialize)(this.Help_menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Help;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox Help_menu;
        private System.Windows.Forms.Label label1;

    }
}