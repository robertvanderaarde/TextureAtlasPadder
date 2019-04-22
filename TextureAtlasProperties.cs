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

        public string Serialize()
        {
            return "padding:" + padding + "|" +
                "rows:" + rows + "|" +
                "columns:" + columns + "|" +
                "imageSizeX:" + imageSizeX + "|" +
                "imageSizeY:" + imageSizeY;
        }

        public void Deserialize(string input)
        {
            string[] categories = input.Split('|');
            foreach (string s in categories)
            {
                string[] val = s.Split(':');
                switch (val[0])
                {
                    case "padding":
                        padding = int.Parse(val[1]);
                        break;
                    case "rows":
                        rows = int.Parse(val[1]);
                        break;
                    case "columns":
                        columns = int.Parse(val[1]);
                        break;
                    case "imageSizeX":
                        imageSizeX = int.Parse(val[1]);
                        break;
                    case "imageSizeY":
                        imageSizeY = int.Parse(val[1]);
                        break;
                }
            }
        }
    }
}
