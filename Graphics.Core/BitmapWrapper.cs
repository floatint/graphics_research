using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics.Core
{
    /// <summary>
    /// Image wrapper for fast access to pixels
    /// </summary>
    class BitmapWrapper
    {
        public BitmapWrapper(byte[] data, int width, int height, int stride)
        {
            _data = data;
            _stride = stride;
        }

        public Color GetPixel(int y, int x)
        {
            int index = y == 0 ? x * 3 : (y - 1) * _stride + x * 3;
            // r g b | b g r
            return Color.FromArgb(_data[index + 2], _data[index + 1], _data[index]);
        }

        public void SetPixel(int y, int x, Color c)
        {
            int index = y == 0 ? x * 3 : (y - 1) * _stride + x * 3;
            _data[index] = c.B;
            _data[index + 1] = c.G;
            _data[index + 2] = c.R;
        }

        private int _stride;
        private byte[] _data;
    }
}
