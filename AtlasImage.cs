using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
