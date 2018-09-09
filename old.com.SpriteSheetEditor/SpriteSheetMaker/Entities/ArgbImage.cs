using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SpriteSheetMaker
{
    public class ArgbImage
    {
        public static int Bytes_per_pixel = 4;

        private Color[] Pixels; 
        public int Width { get; private set; }
        public int Height { get; private set; }


        public ArgbImage(Bitmap bitmapImage)
        {
            Width = bitmapImage.Width;
            Height = bitmapImage.Height;
            Pixels = new Color[Width * Height];
            CopyImageData(bitmapImage);
        }

        // get
        public Color GetPixel(int x, int y) => Pixels[x + Width * y];
        

        public String Sample(int x1, int y1, int x2, int y2)
        {
            string output = "";
            for (int y = y1; y < y2; y++)
            {
                for (int x = x1; x < x2; x++)
                {
                    // convert to value from layered pattern
                    Color c = GetPixel(x, y);
                    output += c.A + " " + c.R + " " + c.G + " " + c.B;
                    output += "; ";
                }
                output += "\n";
            }

            return output;
        }
        /**
         *  CopyImageData
         *  Image copy directly from memory, to encoded UINT64
         */
        internal unsafe void CopyImageData(Bitmap img)
        {
            // byte array to store image data
            byte[] rawData = new byte[img.Width * Bytes_per_pixel * img.Height];
            // locking image (fast access)
            BitmapData lockModeImage = img.LockBits(new Rectangle(0, 0, Width, Height),
                                                                   ImageLockMode.ReadOnly,
                                                                   PixelFormat.Format32bppArgb);
            // Byte Pointer (unsafe) then Marshal.Copy
            IntPtr ptr = lockModeImage.Scan0;
            Marshal.Copy(ptr, rawData, 0, rawData.Length);
            int pixPtr = 0; // pixel pointer 

            // For all pixel in Image byte data
            for (int p = 0; p < rawData.Length; p += Bytes_per_pixel)
            {
               Pixels[pixPtr++] = Color.FromArgb(rawData[p++], // A
                                                 rawData[p++], // R
                                                 rawData[p++], // G
                                                 rawData[p++]);// B
                                    

            }
            // and lastly unlock image
            img.UnlockBits(lockModeImage);
        }

    }
}
