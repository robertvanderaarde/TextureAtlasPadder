using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace TextureAtlasPadder
{
    public partial class TextureAtlasPadder : Form
    {
        public TextureAtlasPadder()
        {
            InitializeComponent();
        }

        TextureAtlasProperties properties;
        TexturePadder padder;
        List<AtlasImage> images;

        private void Form1_Load(object sender, EventArgs e)
        {
            images = new List<AtlasImage>();
            padder = new TexturePadder();
            properties = new TextureAtlasProperties();
            SetupForm();

            Bitmap bmp = new Bitmap("Dirt2.png");
            Bitmap bmp_new = padder.PadTexture(bmp, 20);

            bmp_new.Save("Dirt2_new.png");
        }

        void SetupForm()
        {
            list_images.View = View.List;
            list_images.MultiSelect = false;
            num_imgxsize.Controls[0].Visible = false;
            num_imgysize.Controls[0].Visible = false;
            num_padding.Controls[0].Visible = false;
            num_texid.Controls[0].Visible = false;
            num_xsize.Controls[0].Visible = false;
            num_ysize.Controls[0].Visible = false;
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            properties.padding = 10;
            properties.rows = 10;
            properties.columns = 10;
            properties.imageSizeX = 256;
            properties.imageSizeY = 256;
        }

        private void btn_addimage_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string path = openFileDialog1.FileName;
                string[] splitPath = path.Split('\\');
                string fileName = splitPath[splitPath.Length - 1];
                Bitmap bmp;
                try
                {
                    bmp = new Bitmap(path);
                }
                catch (Exception e1)
                {
                    Console.WriteLine("Could not open " + path + "!");
                    return;
                }

                images.Add(new AtlasImage(bmp, 0, fileName));
                UpdateList();
                list_images.Items[list_images.Items.Count - 1].Focused = true;
                list_images.Items[list_images.Items.Count - 1].Selected = true;
                num_texid.Select();
                num_texid.Select(0, num_texid.Value.ToString().Length);
            }
        }

        private void UpdateList()
        {
            list_images.Items.Clear();

            for (int i = 0; i < images.Count; i++) {
                list_images.Items.Add("(" + images[i].GetID() + "): " + images[i].GetFileName() + "                                  ");
            }
            Thread.Sleep(10);
        }

        private void list_images_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_images.SelectedIndices.Count == 0)
            {
                picbox_image.Image = null;
                num_texid.Value = 0;
                return;
            }

            int idx = list_images.SelectedIndices[0];
            if (idx >= images.Count)
            {
                return;
            }

            // Picture box
            Bitmap bmp = images[idx].GetImage();
            Bitmap resized = new Bitmap(bmp, new Size(picbox_image.Width, picbox_image.Height));

            picbox_image.Image = resized;
            num_texid.Value = images[idx].GetID();
        }

        private void num_texid_ValueChanged(object sender, EventArgs e)
        {
            if (list_images.SelectedIndices.Count == 0)
            {
                return;
            }
            int idx = list_images.SelectedIndices[0];
            if (idx >= images.Count)
            {
                return;
            }

            images[idx].SetID((int)num_texid.Value);
            UpdateList();
        }

        private void num_padding_ValueChanged(object sender, EventArgs e)
        {
            properties.padding = (int)num_padding.Value;
        }

        private void num_ysize_ValueChanged(object sender, EventArgs e)
        {
            properties.rows = (int)num_ysize.Value;
        }

        private void num_xsize_ValueChanged(object sender, EventArgs e)
        {
            properties.columns = (int)num_xsize.Value;
        }

        private void num_imgxsize_ValueChanged(object sender, EventArgs e)
        {
            properties.imageSizeX = (int)num_imgxsize.Value;
        }

        private void num_imgysize_ValueChanged(object sender, EventArgs e)
        {
            properties.imageSizeY = (int)num_imgysize.Value;
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            int imgWidth = properties.imageSizeX * properties.rows + (properties.rows * 2 * properties.padding);
            int imgHeight = properties.imageSizeY * properties.columns + (properties.columns * 2 * properties.padding);
            Bitmap output = new Bitmap(imgWidth, imgHeight);

            for (int i = 0; i < images.Count; i++)
            {
                Bitmap resized = new Bitmap(images[i].GetImage(), new Size(properties.imageSizeX, properties.imageSizeY));
                Bitmap padded = padder.PadTexture(resized, properties.padding);
                int startX = images[i].GetID() % properties.columns;
                int startY = images[i].GetID() / properties.rows;

                startX *= (padded.Width);
                startY *= (padded.Width);

                Console.WriteLine("Starting X for images[" + i + "]: " + startX);
                Console.WriteLine("Starting Y for images[" + i + "]: " + startY);
                for (int x = 0; x < padded.Width; x++)
                {
                    for (int y = 0; y < padded.Height; y++)
                    {
                        output.SetPixel(startX + x, startY + y, padded.GetPixel(x, y));
                    }
                }
            }

            output.Save("output.png");
        }
    }
}
