namespace SpriteSheetMaker
{
    partial class TestLoadImageArgb
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
            this.button1 = new System.Windows.Forms.Button();
            this.OpenFileTestLoadImage = new System.Windows.Forms.OpenFileDialog();
            this.labelPixelValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBenchmark = new System.Windows.Forms.Label();
            this.labelImageHeight = new System.Windows.Forms.Label();
            this.labelImageWidth = new System.Windows.Forms.Label();
            this.labelImageMode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Load Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPixelValue
            // 
            this.labelPixelValue.AutoSize = true;
            this.labelPixelValue.Location = new System.Drawing.Point(490, 169);
            this.labelPixelValue.Name = "labelPixelValue";
            this.labelPixelValue.Size = new System.Drawing.Size(10, 13);
            this.labelPixelValue.TabIndex = 25;
            this.labelPixelValue.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "pixel Value";
            // 
            // labelBenchmark
            // 
            this.labelBenchmark.AutoSize = true;
            this.labelBenchmark.Location = new System.Drawing.Point(370, 8);
            this.labelBenchmark.Name = "labelBenchmark";
            this.labelBenchmark.Size = new System.Drawing.Size(47, 13);
            this.labelBenchmark.TabIndex = 23;
            this.labelBenchmark.Text = "time end";
            // 
            // labelImageHeight
            // 
            this.labelImageHeight.AutoSize = true;
            this.labelImageHeight.Location = new System.Drawing.Point(566, 56);
            this.labelImageHeight.Name = "labelImageHeight";
            this.labelImageHeight.Size = new System.Drawing.Size(10, 13);
            this.labelImageHeight.TabIndex = 22;
            this.labelImageHeight.Text = "-";
            // 
            // labelImageWidth
            // 
            this.labelImageWidth.AutoSize = true;
            this.labelImageWidth.Location = new System.Drawing.Point(566, 39);
            this.labelImageWidth.Name = "labelImageWidth";
            this.labelImageWidth.Size = new System.Drawing.Size(10, 13);
            this.labelImageWidth.TabIndex = 21;
            this.labelImageWidth.Text = "-";
            // 
            // labelImageMode
            // 
            this.labelImageMode.AutoSize = true;
            this.labelImageMode.Location = new System.Drawing.Point(490, 109);
            this.labelImageMode.Name = "labelImageMode";
            this.labelImageMode.Size = new System.Drawing.Size(10, 13);
            this.labelImageMode.TabIndex = 20;
            this.labelImageMode.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "image Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "image Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "image Mode";
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(12, 39);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(472, 244);
            this.picImage.TabIndex = 16;
            this.picImage.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Select File";
            // 
            // TestLoadImageArgb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 308);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPixelValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBenchmark);
            this.Controls.Add(this.labelImageHeight);
            this.Controls.Add(this.labelImageWidth);
            this.Controls.Add(this.labelImageMode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.textBox1);
            this.Name = "TestLoadImageArgb";
            this.Text = "TestLoadImage : Argb";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog OpenFileTestLoadImage;
        private System.Windows.Forms.Label labelPixelValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBenchmark;
        private System.Windows.Forms.Label labelImageHeight;
        private System.Windows.Forms.Label labelImageWidth;
        private System.Windows.Forms.Label labelImageMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.TextBox textBox1;
    }
}