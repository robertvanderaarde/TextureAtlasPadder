using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextureAtlasPadder
{
    class TextureAtlasProperties
    {
        public int padding;
        public int rows;
        public int columns;
        public int imageSizeX;
        public int imageSizeY;

        public string ToString()
        {
            return "Properties: \n\tPadding: " + padding + "\n\tRows: " + rows + "\n\tColumns: " + columns + "\n\tImage Size X: " + imageSizeX + "\n\tImage Size Y: " + imageSizeY;
        }
    }
}
