using System;
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
    public partial class TestConversion : Form
    {
        public TestConversion()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            
            // get color from text fields
            Color ArgbColor = Color.FromArgb(int.Parse(textArgb_A.Text),
                                             int.Parse(textArgb_R.Text),
                                             int.Parse(textArgb_G.Text),
                                             int.Parse(textArgb_B.Text) );
            //Color ArgbColor = Color.FromKnownColor(KnownColor.Blue);
            // convert
            UInt64 colorToConvert = PixelHandler.ArgbToAhsv(ArgbColor);
            float[] converted = new float[4];
            converted = PixelHandler.Decode(colorToConvert);
            decimal hue = (decimal)converted[1]; // keeping real value
            // show converted data
            textAhsv_A.Text = converted[PixelHandler.COLOR_A].ToString();
            
            textAhsv_H.Text = (converted[PixelHandler.COLOR_H]).ToString() + "°";

            textAhsv_S.Text = converted[PixelHandler.COLOR_S].ToString()
                        + "   (" + (converted[PixelHandler.COLOR_S] / 255 * 100).ToString() + "% )";

            textAhsv_V.Text = converted[PixelHandler.COLOR_V].ToString()
                        + "   (" + (converted[PixelHandler.COLOR_V] / 255 * 100).ToString() + "% )";


        }

        private void TestConversion_Load(object sender, EventArgs e)
        {

        }
    }
}
