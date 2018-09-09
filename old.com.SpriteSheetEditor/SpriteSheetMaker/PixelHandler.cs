using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpriteSheetMaker
{

    static class PixelHandler
    {
        public const int COLOR_A = 0;
        public const int COLOR_H = 1;
        public const int COLOR_S = 2;
        public const int COLOR_V = 3;

        public const int COLOR_R = 1;
        public const int COLOR_G = 2;
        public const int COLOR_B = 3;

        public static UInt64 Color { get; private set; }

        /** -----------------------------------------------------------------------------------
         *      Encode 
         *          store Alpha, Hue, Saturation, Value into a single UInt64
         * ----------------------------------------------------------------------------------- */
        public static UInt64 Encode(float alpha, float hue, float saturation, float value)
        {
            UInt64 v = Convert.ToUInt64(value * 100);
            UInt64 s = Convert.ToUInt64(saturation * 100);
            UInt64 h = Convert.ToUInt64(hue);
            UInt64 a = Convert.ToUInt64(alpha * 100);

            return ((a << 48) | (h << 32) | (s << 16) | v);
        }

        /** -----------------------------------------------------------------------------------
         *      Decode 
         *          Convert UInt64 to float array containing :
         *          Alpha, Hue, Saturation, Value
         * ----------------------------------------------------------------------------------- */
        public static float[] Decode(UInt64 color)
        {
            float[] c = new float[4];
            // shifts and place value
            c[COLOR_A] = ((color >> 48) & 0xffff) / 100;
            c[COLOR_H] = ((color >> 32) & 0xffff); // 1 bit shift right
            c[COLOR_S] = ((color >> 16) & 0xffff) / 100;  // 2 bits shift right
            c[COLOR_V] = (color & 0xffff) / 100;  // 3 bit shift right
            return c;
        }

        /**
         * getValueFromUint64
         * 
         * extract color component from UInt64
         */
        public static float GetValueFromUint64(UInt64 value, int colorIndex)
        {
            // get the shifted value based on Color_N const
            int shift = colorIndex * 16;
            float r = (value >> shift) & 0xffff;
            // get decimal if its not a Hue value;
            r = (colorIndex == COLOR_H) ? r : r / 100;
            return r;
        }

        /** -----------------------------------------------------------------------------------
         *  ArgbToHsv(byte a, byte _r, byte _g, byte _b)
         *     Convert from ARGB pixel to HSV including A for alpha chanel
         * ----------------------------------------------------------------------------------- */
        public static UInt64 ArgbToAhsv(Color c) => ArgbToAhsv(c.A, c.R, c.G, c.B); // From Color Object


        public static UInt64 ArgbToAhsv(float a, float r, float g, float b)
        {
            float hue, min, max, delta;
            float[] pix = new float[4];

            //rgb value from [0;255] to [0.00;1.00]
            r /= 255; g /= 255; b /= 255;

            // we need MIN and MAX and DELTA
            // -----------------------------------------
            if (r < b)
            {
                max = (b > g) ? b : g;
                max = (max > r) ? max : r;
                min = (r < g) ? r : g;
                min = (min < b) ? min : b;
            }
            else
            {
                max = (r > g) ? r : g;
                max = (max > b) ? max : b;
                min = (r < b) ? r : b;
                min = (min < g) ? min : g;
            }

            delta = max - min;

            // HUE
            // -----------------------------------------
            // h = [0°,360°[ 
            // convert (r g b) to a degree in the visible spectrum

            // tint is 0 as initialized 
            // otherwise calculate hue
            if (max != min)
            {
                if (max == r)
                {
                    hue = ((g - b) / delta) % 6; // between yellow & magenta
                }
                else if (g == max)
                {
                    hue = ((b - r) / delta) + 2; // between cyan and yellow
                }
                else
                {
                    hue = ((r - g) / delta) + 4; // between mangenta and cyan
                }
                hue *= 60;  //converting to degrees
                if (hue < 0) hue += 360;
                pix[COLOR_H] = hue;
            }

            // SATURATION
            // -----------------------------------------
            // default value is 0 as initialized in hsv[1]
            // otherwise get the saturation value
            if (max != 0) pix[COLOR_S] = (delta / max) * 255;

            // VALUE 
            // -----------------------------------------
            // value is the max found from (r,g,b)
            pix[COLOR_V] = max * 255;

            // ALPHA 
            // -----------------------------------------
            // Pass Alpha value
            //result = source.RGB + (dest.RGB * (1 - source.A)) ???
            pix[COLOR_A] = a;

            // return a Uint64 encoded color
            return Encode(pix[COLOR_A], pix[COLOR_H], pix[COLOR_S], pix[COLOR_V]);
        }


        /** -----------------------------------------------------------------------------------
        *   AhsvToArgb(byte a, byte _r, byte _g, byte _b)
        *     Convert from AHSV pixel to ARGB
        * ----------------------------------------------------------------------------------- */
        public static float[] AhsvToArgb(UInt64 value) => AhsvToArgb(Decode(value)); // from UInt64
        public static float[] AhsvToArgb(float[] c) => AhsvToArgb(c[COLOR_A], c[COLOR_H], c[COLOR_S], c[COLOR_V]); // from float[]

        public static float[] AhsvToArgb(float a, float h, float s, float v)
        {
            // color to return 
            float[] argbColor = new float[4];

            // get the hue angle (between 0 and 5)
            int tint = (int)(h / 60) % 6;

            // retrieve R, G, B components
            float f, l, m, n;
            f = h / 60 - tint;
            l = v * (1 - s);
            m = v * (1 - f * s);
            n = v * (1 - (1 - f) * s);


            // return appropriates value based on the tint (ex tint 0 = [0, 60[ degrees)
            switch (tint)
            {
                case 0:
                    argbColor[COLOR_R] = v;     argbColor[COLOR_G] = n;     argbColor[COLOR_G] = l;
                    break;
                case 1:
                    argbColor[COLOR_R] = m;     argbColor[COLOR_G] = v;     argbColor[COLOR_G] = l;
                    break;
                case 2:
                    argbColor[COLOR_R] = l;     argbColor[COLOR_G] = v;     argbColor[COLOR_G] = n;
                    break;
                case 3:
                    argbColor[COLOR_R] = l;     argbColor[COLOR_G] = m;     argbColor[COLOR_G] = v;
                    break;
                case 4:
                    argbColor[COLOR_R] = n;     argbColor[COLOR_G] = l;     argbColor[COLOR_G] = v;
                    break;
                case 5:
                    argbColor[COLOR_R] = v;     argbColor[COLOR_G] = n;     argbColor[COLOR_G] = l;
                    break;
            }
            // direcly pass Alpha channel
            argbColor[COLOR_A] = a;

            return argbColor;
        }

    }
}
