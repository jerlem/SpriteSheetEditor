namespace SpriteSheetMaker
{
    partial class TestLoadImage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.OpenFileTestLoadImage = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelImageHeight = new System.Windows.Forms.Label();
            this.labelImageWidth = new System.Windows.Forms.Label();
            this.labelImageMode = new System.Windows.Forms.Label();
            this.labelBenchmark = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPixelValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenFileTestLoadImage
            // 
            this.OpenFileTestLoadImage.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Select File";
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(12, 40);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(472, 244);
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
            this.picImage.Click += new System.EventHandler(this.picImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "image Mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "image Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "image Height";
            // 
            // labelImageHeight
            // 
            this.labelImageHeight.AutoSize = true;
            this.labelImageHeight.Location = new System.Drawing.Point(566, 57);
            this.labelImageHeight.Name = "labelImageHeight";
            this.labelImageHeight.Size = new System.Drawing.Size(10, 13);
            this.labelImageHeight.TabIndex = 9;
            this.labelImageHeight.Text = "-";
            // 
            // labelImageWidth
            // 
            this.labelImageWidth.AutoSize = true;
            this.labelImageWidth.Location = new System.Drawing.Point(566, 40);
            this.labelImageWidth.Name = "labelImageWidth";
            this.labelImageWidth.Size = new System.Drawing.Size(10, 13);
            this.labelImageWidth.TabIndex = 8;
            this.labelImageWidth.Text = "-";
            // 
            // labelImageMode
            // 
            this.labelImageMode.AutoSize = true;
            this.labelImageMode.Location = new System.Drawing.Point(490, 110);
            this.labelImageMode.Name = "labelImageMode";
            this.labelImageMode.Size = new System.Drawing.Size(10, 13);
            this.labelImageMode.TabIndex = 7;
            this.labelImageMode.Text = "-";
            // 
            // labelBenchmark
            // 
            this.labelBenchmark.AutoSize = true;
            this.labelBenchmark.Location = new System.Drawing.Point(370, 9);
            this.labelBenchmark.Name = "labelBenchmark";
            this.labelBenchmark.Size = new System.Drawing.Size(47, 13);
            this.labelBenchmark.TabIndex = 11;
            this.labelBenchmark.Text = "time end";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "pixel Value";
            // 
            // labelPixelValue
            // 
            this.labelPixelValue.AutoSize = true;
            this.labelPixelValue.Location = new System.Drawing.Point(490, 170);
            this.labelPixelValue.Name = "labelPixelValue";
            this.labelPixelValue.Size = new System.Drawing.Size(10, 13);
            this.labelPixelValue.TabIndex = 13;
            this.labelPixelValue.Text = "-";
            // 
            // TestLoadImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 296);
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
            this.Controls.Add(this.button1);
            this.Name = "TestLoadImage";
            this.Text = "TestLoadImage";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog OpenFileTestLoadImage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelImageHeight;
        private System.Windows.Forms.Label labelImageWidth;
        private System.Windows.Forms.Label labelImageMode;
        private System.Windows.Forms.Label labelBenchmark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPixelValue;
    }
}

