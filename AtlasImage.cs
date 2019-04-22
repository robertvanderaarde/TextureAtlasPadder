using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace TextureAtlasPadder
{
    class AtlasImage
    {
        Bitmap bmp;
        int textureID;
        string filename;

        public AtlasImage(Bitmap bmp, int textureID, string filename="Untitled")
        {
            this.bmp = bmp;
            this.textureID = textureID;
            this.filename = filename;
        }

        public AtlasImage(string input)
        {
            Deserialize(input);
        }

        public string Serialize()
        {
            string output = "textureID:" + textureID + "|" + "filename:" + filename + "|" + "bmp:";
            using (var ms = new MemoryStream())
            {
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                output += Convert.ToBase64String(ms.GetBuffer());
            }
            return output;
        }

        public void Deserialize(string input)
        {
            string[] categories = input.Split('|');
            foreach (string s in categories)
            {
                string[] val = s.Split(':');
                switch (val[0])
                {
                    case "textureID":
                        textureID = int.Parse(val[1]);
                        break;
                    case "filename":
                        filename = val[1];
                        break;
                    case "bmp":
                        byte[] bitmapBytes = Convert.FromBase64String(val[1]);
                        MemoryStream memoryStream = new MemoryStream(bitmapBytes);
                        Image img = Image.FromStream(memoryStream);
                        bmp = new Bitmap(img);
                        break;
                }
            }
        }

        public Bitmap GetImage()
        {
            return bmp;
        }

        public int GetID()
        {
            return textureID;
        }

        public void SetID(int val)
        {
            this.textureID = val;
        }

        public string GetFileName()
        {
            return filename;
        }

        public int GetHash()
        {
            return this.bmp.GetHashCode();
        }
    }
}
