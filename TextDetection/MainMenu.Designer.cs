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
            this.MM_language = new System.Windows.Forms.Button();
            this.MM_help = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MM_proceed
            // 
            this.MM_proceed.Location = new System.Drawing.Point(98, 90);
            this.MM_proceed.Name = "MM_proceed";
            this.MM_proceed.Size = new System.Drawing.Size(147, 49);
            this.MM_proceed.TabIndex = 0;
            this.MM_proceed.Text = "Proceed";
            this.MM_proceed.UseVisualStyleBackColor = true;
            this.MM_proceed.Click += new System.EventHandler(this.MM_proceed_Click);
            // 
            // MM_language
            // 
            this.MM_language.Location = new System.Drawing.Point(98, 161);
            this.MM_language.Name = "MM_language";
            this.MM_language.Size = new System.Drawing.Size(147, 49);
            this.MM_language.TabIndex = 1;
            this.MM_language.Text = "Language";
            this.MM_language.UseVisualStyleBackColor = true;
            this.MM_language.Click += new System.EventHandler(this.MM_language_Click);
            // 
            // MM_help
            // 
            this.MM_help.Location = new System.Drawing.Point(98, 232);
            this.MM_help.Name = "MM_help";
            this.MM_help.Size = new System.Drawing.Size(147, 49);
            this.MM_help.TabIndex = 2;
            this.MM_help.Text = "Help";
            this.MM_help.UseVisualStyleBackColor = true;
            this.MM_help.Click += new System.EventHandler(this.MM_help_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcom to Tetx detector ";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(352, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MM_help);
            this.Controls.Add(this.MM_language);
            this.Controls.Add(this.MM_proceed);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MM_proceed;
        private System.Windows.Forms.Button MM_language;
        private System.Windows.Forms.Button MM_help;
        private System.Windows.Forms.Label label1;
    }
}