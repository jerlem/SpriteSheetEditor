using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpriteSheetMaker.Entities;

namespace SpriteSheetMaker
{
    class SlicedImage
    {
        internal string Name;
        internal AhsvImage ImageContent { get; private set; }
        internal bool IsContainingImage { get; private set; }

        internal Coord Position;
        internal Dimension Size;

        public SlicedImage(string name, Coord position, Dimension dimension, AhsvImage imageContent= null)
        {
            // update iscontaining image
            IsContainingImage = (imageContent == null) ? false : true;
            // set fields
            Name = name;
            ImageContent = imageContent;
            Size = dimension;
            Position = position;
        }

        internal void Rename(string newName) => Name = newName;
        internal void MoveAt(Coord newPosition) => Position = newPosition;
        internal void Resize(Dimension newDimension) => Size = newDimension;

        internal void ReloadFile() { }
    }
}
