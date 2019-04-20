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
                    if (x + paddingAmount < input.Width && y < input.Height + paddingAmount && y >= paddingAmount)
                    {
                        output.SetPixel(x, y, output.GetPixel(paddingAmount, y));
                    }
                    else
                    {
                        output.SetPixel(x, y, Color.Green);
                    }
                }
            }

            // Right
            for (int x = input.Width + paddingAmount; x < output.Width; x++)
            {
                for (int y = 0; y < output.Height; y++)
                {
                    if (y >= paddingAmount && y < input.Height + paddingAmount)
                    {
                        output.SetPixel(x, y, output.GetPixel(input.Width + paddingAmount - 1, y));
                    }
                    else
                    {
                        output.SetPixel(x, y, Color.Green);
                    }
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
                    output.SetPixel(x, y, output.GetPixel(x, paddingAmount));
                }
            }

            return output;
        }
    }
}
