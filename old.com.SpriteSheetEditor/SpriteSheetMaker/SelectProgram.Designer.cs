namespace SpriteSheetMaker
{
    partial class SelectProgram
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
            this.LaunchTestConversion = new System.Windows.Forms.Button();
            this.LaunchTestLoad = new System.Windows.Forms.Button();
            this.LaunchTestArgb = new System.Windows.Forms.Button();
            this.LaunchConversionArgb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LaunchTestConversion
            // 
            this.LaunchTestConversion.Location = new System.Drawing.Point(14, 35);
            this.LaunchTestConversion.Name = "LaunchTestConversion";
            this.LaunchTestConversion.Size = new System.Drawing.Size(235, 23);
            this.LaunchTestConversion.TabIndex = 0;
            this.LaunchTestConversion.Text = "Test Conversion AHSV";
            this.LaunchTestConversion.UseVisualStyleBackColor = true;
            this.LaunchTestConversion.Click += new System.EventHandler(this.LaunchTestConversion_click);
            // 
            // LaunchTestLoad
            // 
            this.LaunchTestLoad.Location = new System.Drawing.Point(16, 137);
            this.LaunchTestLoad.Name = "LaunchTestLoad";
            this.LaunchTestLoad.Size = new System.Drawing.Size(235, 23);
            this.LaunchTestLoad.TabIndex = 1;
            this.LaunchTestLoad.Text = "Test Loading Image";
            this.LaunchTestLoad.UseVisualStyleBackColor = true;
            this.LaunchTestLoad.Click += new System.EventHandler(this.LaunchTestLoad_Click);
            // 
            // LaunchTestArgb
            // 
            this.LaunchTestArgb.Location = new System.Drawing.Point(16, 166);
            this.LaunchTestArgb.Name = "LaunchTestArgb";
            this.LaunchTestArgb.Size = new System.Drawing.Size(235, 23);
            this.LaunchTestArgb.TabIndex = 2;
            this.LaunchTestArgb.Text = "Test Load Argb";
            this.LaunchTestArgb.UseVisualStyleBackColor = true;
            this.LaunchTestArgb.Click += new System.EventHandler(this.LaunchTestArgb_Click);
            // 
            // LaunchConversionArgb
            // 
            this.LaunchConversionArgb.Location = new System.Drawing.Point(16, 64);
            this.LaunchConversionArgb.Name = "LaunchConversionArgb";
            this.LaunchConversionArgb.Size = new System.Drawing.Size(235, 23);
            this.LaunchConversionArgb.TabIndex = 3;
            this.LaunchConversionArgb.Text = "Test Conversion ARGB";
            this.LaunchConversionArgb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Conversions Test Forms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loading Images Test Forms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Launch MDI";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sprite Sheet Maker MDI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 279);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LaunchConversionArgb);
            this.Controls.Add(this.LaunchTestArgb);
            this.Controls.Add(this.LaunchTestLoad);
            this.Controls.Add(this.LaunchTestConversion);
            this.Name = "SelectProgram";
            this.Text = "Select Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LaunchTestConversion;
        private System.Windows.Forms.Button LaunchTestLoad;
        private System.Windows.Forms.Button LaunchTestArgb;
        private System.Windows.Forms.Button LaunchConversionArgb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}