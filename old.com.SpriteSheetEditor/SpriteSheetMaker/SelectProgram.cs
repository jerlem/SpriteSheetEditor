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
    public partial class SelectProgram : Form
    {
        public SelectProgram()
        {
            InitializeComponent();
        }

        private void LaunchTestConversion_click(object sender, EventArgs e)
        {
            Form windowTestonversion = new TestConversion();
            windowTestonversion.Show(); 
        }

        private void LaunchTestLoad_Click(object sender, EventArgs e)
        {
            Form windowTestLoad = new TestLoadImage();
            windowTestLoad.Show();
        }

        private void LaunchTestArgb_Click(object sender, EventArgs e)
        {
            Form winwdowTestArgb = new TestLoadImageArgb();
            winwdowTestArgb.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form spriteSheetMaker = new SpriteSheetMakerMDI();
            spriteSheetMaker.Show();
        }
    }
}
