namespace TextDetection
{
    partial class Form_Language
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Language));
            this.label1 = new System.Windows.Forms.Label();
            this.LS_OptionGroup = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.LS_English = new System.Windows.Forms.RadioButton();
            this.Language_menu = new System.Windows.Forms.PictureBox();
            this.LS_OptionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Language_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a language you want to detect from an image";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LS_OptionGroup
            // 
            this.LS_OptionGroup.Controls.Add(this.radioButton4);
            this.LS_OptionGroup.Controls.Add(this.radioButton3);
            this.LS_OptionGroup.Controls.Add(this.radioButton2);
            this.LS_OptionGroup.Controls.Add(this.LS_English);
            this.LS_OptionGroup.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LS_OptionGroup.Location = new System.Drawing.Point(22, 65);
            this.LS_OptionGroup.Name = "LS_OptionGroup";
            this.LS_OptionGroup.Size = new System.Drawing.Size(274, 195);
            this.LS_OptionGroup.TabIndex = 1;
            this.LS_OptionGroup.TabStop = false;
            this.LS_OptionGroup.Text = "Langauge Options";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(34, 158);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(72, 20);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Italian";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(34, 113);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(81, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Russian";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(34, 71);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Arabic";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // LS_English
            // 
            this.LS_English.AutoSize = true;
            this.LS_English.Checked = true;
            this.LS_English.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LS_English.Location = new System.Drawing.Point(34, 30);
            this.LS_English.Name = "LS_English";
            this.LS_English.Size = new System.Drawing.Size(79, 20);
            this.LS_English.TabIndex = 0;
            this.LS_English.TabStop = true;
            this.LS_English.Text = "English";
            this.LS_English.UseVisualStyleBackColor = true;
            // 
            // Language_menu
            // 
            this.Language_menu.Image = ((System.Drawing.Image)(resources.GetObject("Language_menu.Image")));
            this.Language_menu.ImageLocation = "F:\\VP Project Files\\download.jpg";
            this.Language_menu.Location = new System.Drawing.Point(22, 282);
            this.Language_menu.Name = "Language_menu";
            this.Language_menu.Size = new System.Drawing.Size(77, 38);
            this.Language_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Language_menu.TabIndex = 2;
            this.Language_menu.TabStop = false;
            this.Language_menu.Click += new System.EventHandler(this.Language_menu_Click);
            // 
            // Form_Language
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(321, 346);
            this.Controls.Add(this.Language_menu);
            this.Controls.Add(this.LS_OptionGroup);
            this.Controls.Add(this.label1);
            this.Name = "Form_Language";
            this.Text = "Language Selection";
            this.LS_OptionGroup.ResumeLayout(false);
            this.LS_OptionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Language_menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox LS_OptionGroup;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton LS_English;
        private System.Windows.Forms.PictureBox Language_menu;
    }
}