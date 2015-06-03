namespace TextDetection
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.MM_proceed = new System.Windows.Forms.Button();
            this.MM_help = new System.Windows.Forms.Button();
            this.Mainmenu_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MM_proceed
            // 
            this.MM_proceed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MM_proceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MM_proceed.Location = new System.Drawing.Point(176, 108);
            this.MM_proceed.Name = "MM_proceed";
            this.MM_proceed.Size = new System.Drawing.Size(285, 84);
            this.MM_proceed.TabIndex = 0;
            this.MM_proceed.Text = "Proceed";
            this.MM_proceed.UseVisualStyleBackColor = false;
            this.MM_proceed.Click += new System.EventHandler(this.MM_proceed_Click);
            // 
            // MM_help
            // 
            this.MM_help.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MM_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MM_help.Location = new System.Drawing.Point(176, 234);
            this.MM_help.Name = "MM_help";
            this.MM_help.Size = new System.Drawing.Size(285, 83);
            this.MM_help.TabIndex = 2;
            this.MM_help.TabStop = false;
            this.MM_help.Text = "Help";
            this.MM_help.UseVisualStyleBackColor = false;
            this.MM_help.Click += new System.EventHandler(this.MM_help_Click);
            // 
            // Mainmenu_label
            // 
            this.Mainmenu_label.AutoSize = true;
            this.Mainmenu_label.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainmenu_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Mainmenu_label.Location = new System.Drawing.Point(130, 40);
            this.Mainmenu_label.Name = "Mainmenu_label";
            this.Mainmenu_label.Size = new System.Drawing.Size(375, 35);
            this.Mainmenu_label.TabIndex = 3;
            this.Mainmenu_label.Text = "Welcom to Text detector ";
            this.Mainmenu_label.Click += new System.EventHandler(this.Mainmenu_label_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 476);
            this.Controls.Add(this.Mainmenu_label);
            this.Controls.Add(this.MM_help);
            this.Controls.Add(this.MM_proceed);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MM_proceed;
        private System.Windows.Forms.Button MM_help;
        private System.Windows.Forms.Label Mainmenu_label;
    }
}