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
        int last_selected = -1;

        private void Form1_Load(object sender, EventArgs e)
        {
            images = new List<AtlasImage>();
            padder = new TexturePadder();
            properties = new TextureAtlasProperties();
            SetupForm();
        }

        void SetupForm()
        {
            list_images.View = View.List;
            list_images.MultiSelect = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            num_imgxsize.Controls[0].Visible = false;
            num_imgysize.Controls[0].Visible = false;
            num_padding.Controls[0].Visible = false;
            num_texid.Controls[0].Visible = false;
            num_xsize.Controls[0].Visible = false;
            num_ysize.Controls[0].Visible = false;
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.Multiselect = true;

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
                foreach (String s in openFileDialog1.FileNames)
                {
                    string path = s;
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
                    bool success = false;
                    while (!success)
                    {
                        try
                        {
                            list_images.Items[list_images.Items.Count - 1].Focused = true;
                            list_images.Items[list_images.Items.Count - 1].Selected = true;
                            list_images.Select();
                        }
                        catch (Exception e1)
                        {

                        }
                        finally
                        {
                            success = true;
                        }
                    }
                }
            }
        }

        private void SaveAtlas(string path)
        {
            string output = "";
            output += properties.Serialize() + "\n";
            for (int i = 0; i < images.Count; i++)
            {
                output += images[i].Serialize() + "\n";
            }
            output = output.Trim();

            System.IO.File.WriteAllText(path, output);
        }

        private void LoadAtlas(string path)
        {
            images.Clear();

            string input = System.IO.File.ReadAllText(path);
            string[] lines = input.Split('\n');
            properties.Deserialize(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                images.Add(new AtlasImage(lines[i]));
            }

            UpdateList();
            UpdateValues();
        }

        private void UpdateValues()
        {
            num_padding.Value = this.properties.padding;
            num_ysize.Value = this.properties.rows;
            num_xsize.Value = this.properties.columns;
            num_imgxsize.Value = this.properties.imageSizeX;
            num_imgysize.Value = this.properties.imageSizeY;
        }

        private void UpdateList()
        {
            int selected = (list_images.SelectedIndices.Count == 0) ? 0 : list_images.SelectedIndices[0];
            list_images.Items.Clear();

            for (int i = 0; i < images.Count; i++) {
                list_images.Items.Add("(" + images[i].GetID() + "): " + images[i].GetFileName() + "                                  ");
            }

            if (list_images.Items.Count > selected)
            {
                list_images.Items[selected].Focused = true;
                list_images.Items[selected].Selected = true;
            }
        }

        private void list_images_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_images.Select();
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
            if (idx >= 0 && idx < images.Count)
            {
                last_selected = idx;
                Bitmap bmp = images[idx].GetImage();
                Bitmap resized = new Bitmap(bmp, new Size(picbox_image.Width, picbox_image.Height));

                picbox_image.Image = resized;
                num_texid.Value = images[idx].GetID();
            }
        }

        private void num_texid_ValueChanged(object sender, EventArgs e)
        {
            if (list_images.SelectedIndices.Count == 0)
            {
                return;
            }
            int idx = list_images.SelectedIndices[0];
            if (idx >= images.Count && idx >= 0 || idx < 0)
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

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                int imgWidth = properties.imageSizeX * properties.rows + (properties.rows * 2 * properties.padding);
                int imgHeight = properties.imageSizeY * properties.columns + (properties.columns * 2 * properties.padding);
                Bitmap output = new Bitmap(imgWidth, imgHeight);

                for (int i = 0; i < images.Count; i++)
                {
                    Bitmap padded = padder.PadTexture(images[i].GetImage(), properties.padding);
                    padded = new Bitmap(padded, new Size(properties.imageSizeX, properties.imageSizeY));
                    int startX = images[i].GetID() % properties.columns;
                    int startY = images[i].GetID() / properties.rows;

                    startX *= (padded.Width);
                    startY *= (padded.Width);

                    for (int x = 0; x < padded.Width; x++)
                    {
                        for (int y = 0; y < padded.Height; y++)
                        {
                            output.SetPixel(startX + x, startY + y, padded.GetPixel(x, y));
                        }
                    }
                }

                output.Save(saveFileDialog1.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "TAP File|*.tap";
            saveFileDialog1.Title = "Save a Texture Atlas Padding File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                SaveAtlas(saveFileDialog1.FileName);
            }
        }

        private void loadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "TAP File|*.tap";
            openDialog.Title = "Open a Texture Atlas Padding File";
            openDialog.ShowDialog();

            if (openDialog.FileName != "")
            {
                LoadAtlas(openDialog.FileName);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to create a new Texture Atlas?", "New Atlas", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                images.Clear();
                picbox_image.Image = null;
                UpdateList();
            }
        }
    }
}
