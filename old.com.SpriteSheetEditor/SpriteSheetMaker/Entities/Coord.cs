using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpriteSheetMaker.Entities
{
    public class Coord
    {
        public int X;
        public int Y;

        // default no dimension
        public Coord()
        {
            X = 0; Y = 0;
        }

        // with settings
        public Coord(int x, int y)
        {
            X = x; Y = y;
        }
    }

    public class Dimension
    {
        public int Width;
        public int Height;

        // default no dimension
        public Dimension()
        {
            Width = 0; Height = 0;
        }

        // with settings
        public Dimension(int width, int height)
        {
            Width = width; Height = height;
        }
    }

}
