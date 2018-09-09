using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpriteSheetMaker.Entities;

namespace SpriteSheetMaker
{
    class SpriteSheet
    {
        // Project name file and path
        public string Name { get; private set; }
        public string FileName { get; private set; }
        public string FilePath { get; private set; }
        public Dimension SpriteSheetDimension { get; private set; } = new Dimension(0, 0);

        // exports settings
        public int ExporTargetWith { get; private set; }
        public string NamePrefix { get; private set; }

        // sliced images list
        public List<SlicedImage> Slices { get; private set; } = new List<SlicedImage>();

        // selecting:
        private int SliceSelected;

        public AhsvImage BlockImage { get; private set; }
        public AhsvImage BackgroundImage { get; private set; }

        public SpriteSheet(string name, string fileName, string filePath, Dimension spriteSheetDimension, string namePrefix)
        {

            Name = name;
            FileName = fileName;
            FilePath = filePath;
            SpriteSheetDimension = spriteSheetDimension;
            NamePrefix = namePrefix;

            ExporTargetWith = SpriteSheetDimension.Width;
            SliceSelected = 0;
        }

        /**
         * CreateSlice
         * Add a new slice: with at least Coord and Dimension
         */
        public void CreateSlice(Coord position, Dimension dimension, string name = "", AhsvImage image = null)
        {
            // get default name or string passed
            string sliceName = (name.Length < 2) ? "new Slice" + Slices.Count() : name;
            // ahsvImage can be null;
            
            Slices.Add(new SlicedImage(sliceName, position, dimension, image));
        }

        /**
         *  Basic Operations On slices
         */
        public void DeleteSelectedSlice()                       => Slices.RemoveAt(SliceSelected);
        public void RenameSelectedSlice(string newName)         => Slices[SliceSelected].Name = newName;
        public void ResizeSelectedSlice(Dimension newDimension) => Slices[SliceSelected].Size = newDimension;
        public void MoveSelectedSlice(Coord newPosition)        => Slices[SliceSelected].Position = newPosition;
        public void DuplicateSelecedSlice()                     => Slices.Add(Slices[SliceSelected]);
        public void DeleteSliceList()                           => Slices.Clear(); 


        /**
         * GetSliceNameList
         * Return list of slices names
         */
        public string[] GetSliceNameList()
        {
            string[] list = new string[Slices.Count];
            for (int i = 0; i < Slices.Count; i++) { list[i] = Slices[i].Name; }
            return new string[0];
        }

        // new width for exporting
        public void SetExporTargetWith(int newWidth) => ExporTargetWith = newWidth;



    }
}
