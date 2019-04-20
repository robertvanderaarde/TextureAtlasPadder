using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextureAtlasPadder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TexturePadder padder = new TexturePadder();

            Bitmap bmp = new Bitmap("Dirt2.png");
            Bitmap bmp_new = padder.PadTexture(bmp, 20);

            bmp_new.Save("Dirt2_new.png");
        }
    }
}
