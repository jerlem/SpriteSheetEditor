﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpriteSheetMaker
{
    public partial class TestLoadImage : Form
    {
        public static AhsvImage imageAnalyse;
        public static Bitmap imageBitmap;

        public TestLoadImage()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OpenFileTestLoadImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                // begin Benchmark
                Benchmark.Start();

                // load image into Picture Box
                picImage.Load(OpenFileTestLoadImage.FileName);
                labelImageWidth.Text = picImage.Image.Width.ToString();
                labelImageHeight.Text = picImage.Image.Height.ToString();
                labelImageMode.Text = picImage.Image.PixelFormat.ToString();
                // new AshvImage from bitmap object
                imageBitmap = new Bitmap(picImage.Image);
                imageAnalyse = new AhsvImage(imageBitmap);

                // end Benchmark
                Benchmark.End();
                labelBenchmark.Text = Benchmark.Span.ToString();

                // sample
                //string sample = imageAnalyse.ImageSample(PixelHandler.Color_V, 50, 50, 60, 60);
                //MessageBox.Show(sample);

            }
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            if (picImage.Image != null)
            {
                MouseEventArgs me = (MouseEventArgs)e;
                labelPixelValue.Text = imageAnalyse.GetPixel(me.X, me.Y).ToString();

                //AtlasMaker atlas = new AtlasMaker(imageAnalyse);
                //atlas.ImageLinesResult();
            }
        }
    }
}
