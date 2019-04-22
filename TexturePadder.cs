using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextureAtlasPadder
{
    class TexturePadder
    {
        public Bitmap PadTextureDebug(Bitmap input, int paddingAmount)
        {
            Bitmap output = new Bitmap(input.Width + (paddingAmount * 2), input.Height + (paddingAmount * 2));
            for (int x = 0; x < input.Width; x++)
            {
                for (int y = 0; y < input.Height; y++)
                {
                    output.SetPixel(x + paddingAmount, y + paddingAmount, Color.Green);
                }
            }


            // Left
            for (int x = 0; x < paddingAmount; x++)
            {
                for (int y = 0; y < output.Height; y++)
                {
                    output.SetPixel(x, y, output.GetPixel(paddingAmount, y));
                }
            }

            // Right
            for (int x = input.Width + paddingAmount; x < output.Width; x++)
            {
                for (int y = 0; y < output.Height; y++)
                {
                    output.SetPixel(x, y, Color.Green);
                }
            }

            // Top
            for (int x = 0; x < output.Width; x++)
            {
                for (int y = 0; y < paddingAmount; y++)
                {
                    output.SetPixel(x, y, Color.Green);
                }
            }

            // Bottom
            for (int x = 0; x < output.Width; x++)
            {
                for (int y = input.Height + paddingAmount; y < output.Height; y++)
                {
                    output.SetPixel(x, y, Color.Green);
                }
            }

            return output;
        }
        public Bitmap PadTexture(Bitmap input, int paddingAmount)
        {
            Bitmap output = new Bitmap(input.Width + (paddingAmount * 2), input.Height + (paddingAmount * 2));
            for (int x = 0; x < input.Width; x++)
            {
                for (int y = 0; y < input.Height; y++)
                {
                    output.SetPixel(x + paddingAmount, y + paddingAmount, input.GetPixel(x, y));
                }
            }
            
            // Left
            for (int x = 0; x < paddingAmount; x++)
            {
                for (int y = 0; y < output.Height; y++)
                {
                    output.SetPixel(x, y, output.GetPixel(paddingAmount, y));
                }
            }

            // Right
            for (int x = input.Width + paddingAmount - 1; x < output.Width; x++)
            {
                for (int y = 0; y < output.Height; y++)
                {
                    output.SetPixel(x, y, output.GetPixel(input.Width + paddingAmount - 1, y));
                }
            }

            // Top
            for (int x = 0; x < output.Width; x++)
            {
                for (int y = 0; y < paddingAmount; y++)
                {
                    output.SetPixel(x, y, output.GetPixel(x, paddingAmount));
                }
            }

            // Bottom
            for (int x = 0; x < output.Width; x++)
            {
                for (int y = input.Height + paddingAmount;  y < output.Height; y++)
                {
                    output.SetPixel(x, y, output.GetPixel(x, input.Height + paddingAmount - 1));
                }
            }

            return output;
        }
        public Bitmap PadTextureResize(Bitmap input, Size size, int paddingAmount)
        {
            Bitmap originalResized = new Bitmap(input, size);
            Bitmap output = new Bitmap(size.Width + (paddingAmount * 2), size.Height + (paddingAmount * 2));
            for (int x = 0; x < originalResized.Width; x++)
            {
                for (int y = 0; y < originalResized.Height; y++)
                {
                    output.SetPixel(x + paddingAmount, y + paddingAmount, originalResized.GetPixel(x, y));
                }
            }

            // Left
            for (int x = 0; x <= paddingAmount; x++)
            {
                for (int y = 0; y < output.Height; y++)
                {
                    int yLevel = 0;
                    if (y >= paddingAmount && y - paddingAmount < output.Height - (2 * paddingAmount))
                    {
                        float ratio = Math.Min(1, (float)(y - paddingAmount) / (output.Height - (2 * paddingAmount)));
                        yLevel = (int)(ratio * input.Height);
                    }
                    output.SetPixel(x, y, input.GetPixel(0, yLevel));
                }
            }

            // Right
            for (int x = output.Width - paddingAmount - 1; x < output.Width; x++)
            {
                for (int y = 0; y < output.Height; y++)
                {
                    int yLevel = 0;
                    if (y >= paddingAmount && y - paddingAmount < output.Height - (2 * paddingAmount))
                    {
                        float ratio = Math.Min(1, (float)(y - paddingAmount) / (output.Height - (2 * paddingAmount)));
                        yLevel = (int)(ratio * input.Height);
                    }
                    output.SetPixel(x, y, input.GetPixel(input.Width - 1, yLevel));
                }
            }

            // Top
            for (int x = 0; x < output.Width; x++)
            {
                for (int y = 0; y <= paddingAmount; y++)
                {
                    int xLevel = 0;
                    if (x >= paddingAmount && x - paddingAmount < output.Width - (2 * paddingAmount))
                    {
                        float ratio = Math.Min(1, (float)(x - paddingAmount) / (output.Width - (2 * paddingAmount)));
                        xLevel = (int)(ratio * input.Width);
                    }
                    output.SetPixel(x, y, input.GetPixel(xLevel, 0));
                }
            }

            // Bottom
            for (int x = 0; x < output.Width; x++)
            {
                for (int y = output.Height - paddingAmount - 1; y < output.Height; y++)
                {
                    int xLevel = 0;
                    if (x >= paddingAmount && x - paddingAmount < output.Width - (2 * paddingAmount))
                    {
                        float ratio = Math.Min(1, (float)(x - paddingAmount) / (output.Width - (2 * paddingAmount)));
                        xLevel = (int)(ratio * input.Width);
                    }
                    output.SetPixel(x, y, input.GetPixel(xLevel, input.Height - 1));
                }
            }

            //// Right
            //for (int x = input.Width + paddingAmount - 1; x < output.Width; x++)
            //{
            //    for (int y = 0; y < output.Height; y++)
            //    {
            //        output.SetPixel(x, y, output.GetPixel(input.Width + paddingAmount - 1, y));
            //    }
            //}

            //// Top
            //for (int x = 0; x < output.Width; x++)
            //{
            //    for (int y = 0; y < paddingAmount; y++)
            //    {
            //        output.SetPixel(x, y, output.GetPixel(x, paddingAmount));
            //    }
            //}

            //// Bottom
            //for (int x = 0; x < output.Width; x++)
            //{
            //    for (int y = input.Height + paddingAmount; y < output.Height; y++)
            //    {
            //        output.SetPixel(x, y, output.GetPixel(x, input.Height + paddingAmount - 1));
            //    }
            //}


            return output;
        }
    }
}
