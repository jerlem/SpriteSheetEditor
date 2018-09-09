using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpriteSheetMaker.Entities
{
    class CompositeImage : AhsvImage
    {
        public string Name { get; private set; }
        public Bitmap BitmapImage { get; private set; }
    }
}
