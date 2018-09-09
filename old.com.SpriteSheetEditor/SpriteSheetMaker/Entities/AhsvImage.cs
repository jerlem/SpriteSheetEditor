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

    public class AhsvImage
    {
        public static int Bytes_per_pixel = 4;

        // Uint64 AHSV represantation 
        private UInt64[] Pixels;
        private readonly Bitmap ReferenceImage;

        // Image information
        public int Width { get; private set; }
        public int Height { get; private set; }

        /**
         * Constructor: It require image to works
         * keep copy of bitmap
         * initialize image settings and make a fast copy of 
         * image byte data
         */
        public AhsvImage(Bitmap bitmapImage)
        {
            ReferenceImage = bitmapImage;
            Width = bitmapImage.Width;
            Height = bitmapImage.Height;
            Pixels = new UInt64[Width * Height];
            CopyImageData(bitmapImage);
        }

        public AhsvImage()
        {
            ReferenceImage = null;
            Width = 0;
            Height = 0;
            Pixels = new UInt64[0 * 0];
        }

        // get pixel value
        public UInt64 GetPixel(int x, int y)
        {
            int pos = Width * y + x;
            if (pos > -1 && pos < Pixels.Length) return Pixels[pos];
            return 0;
        }
        // change pixel value
        public void SetPixel(int x, int y, UInt64 value)
        {
            int pos = Width * y + x;
            if (pos > -1 && pos < Pixels.Length) Pixels[pos] = value;
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
                // encode it 
                Pixels[pixPtr++] = PixelHandler.Encode(rawData[p++], // A
                                                       rawData[p++], // R
                                                       rawData[p++], // G
                                                       rawData[p++]);// B
            }
            // and lastly unlock image
            img.UnlockBits(lockModeImage);
        }

        public string ImageSample(int layer, int x1, int y1, int x2, int y2)
        {
            // shift pattern to apply 
            // see: PixelHandler.Color_A , PixelHandler.Color_S etc. 
            int compositeLayer = (layer != 0) ? PixelHandler.COLOR_V : layer;
            float v;
            string output = "";

            // region
            for (int y = y1; y < y2; y++)
            {
                for (int x = x1; x < x2; x++)
                {
                    // convert to value from layered pattern
                    v = PixelHandler.GetValueFromUint64(GetPixel(x, y), layer);
                    output += "; " + v;
                }
                output += "\n";
            }

            return output;
        }

        /**
         * GetReferenceImage
         * return the bitmap linked
         */
        public Bitmap GetReferenceImage() => ReferenceImage;
    }
}
