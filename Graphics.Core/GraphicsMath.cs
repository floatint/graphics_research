using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Graphics.Core
{
    public class GraphicsMath
    {
        public static Bitmap Convolution(Bitmap sourceImage, double[][] convolutionKernel, Point anchor)
        {
            var data = sourceImage.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            int size = data.Stride * sourceImage.Height;
            byte[] bitmap = new byte[size];
            byte[] newBitmap = new byte[size];
            // copy to managed memory
            System.Runtime.InteropServices.Marshal.Copy(data.Scan0, bitmap, 0, size);


            int pixelIndex = 0;
            int stride = data.Stride - sourceImage.Width * 3;
            // kernel bounds
            var l = anchor.X;
            var r = convolutionKernel[0].Length - l - 1;
            var t = anchor.Y;
            var b = convolutionKernel.Length - t - 1;

            for (int y = 0; y < sourceImage.Height; y++, pixelIndex += stride)
            {
                if (y - t < 0 || y + b >= sourceImage.Height)
                {
                    pixelIndex += sourceImage.Width * 3;
                    continue;
                }

                for (int x = 0; x < sourceImage.Width; x++, pixelIndex+=3)
                {
                    if (x - l < 0 || x + r >= sourceImage.Width)
                    {
                        continue;
                    }

                    // get processing rect
                    int ly = y - t;
                    int lx = x - l;
                    int ry = y + b;
                    int rx = x + r;
                    byte blue_value = 0;
                    byte green_value = 0;
                    byte red_value = 0;
                    BitmapWrapper wrap = new BitmapWrapper(bitmap, sourceImage.Width, sourceImage.Height, data.Stride);
                    BitmapWrapper wrapWrite = new BitmapWrapper(newBitmap, sourceImage.Width, sourceImage.Height, data.Stride);
                    // process rect
                    for (int i = 0; i < convolutionKernel.Length; i++)
                    {
                        for (int j = 0; j < convolutionKernel[0].Length; j++)
                        {
                            blue_value += (byte)(wrap.GetPixel(ly + i, lx + j).B * convolutionKernel[i][j]);
                            green_value += (byte)(wrap.GetPixel(ly + i, lx + j).G * convolutionKernel[i][j]);
                            red_value += (byte)(wrap.GetPixel(ly + i, lx + j).R * convolutionKernel[i][j]);
                        }
                    }

                    wrapWrite.SetPixel(y, x, Color.FromArgb(red_value, green_value, blue_value));

                }
            }
            System.IO.MemoryStream stream = new System.IO.MemoryStream(bitmap);
            var im = new Bitmap(sourceImage.Width, sourceImage.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb); ;
            System.Drawing.Imaging.BitmapData newImageData = im.LockBits(new System.Drawing.Rectangle(0, 0, im.Width, im.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, im.PixelFormat);
            IntPtr pNative = newImageData.Scan0;
            Marshal.Copy(newBitmap, 0, pNative, newImageData.Stride * im.Height);
            im.UnlockBits(newImageData);
            sourceImage.UnlockBits(data);
            return im;
        }
    }
}
