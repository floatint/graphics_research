using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Graphics.Core
{
    public class MatrixFileProvider
    {
        private static readonly UInt32 SIGNATURE = 0xDEAD;
        
        public static double[][] LoadFromFile(string file)
        {
            BinaryReader br = new BinaryReader(new FileStream(file, FileMode.Open));
            if (br.ReadUInt32() == SIGNATURE)
            {
                // get size
                int h = br.ReadInt32();
                int w = br.ReadInt32();
                double[][] res = new double[h][];
                for (int y = 0; y < h; y++)
                {
                    res[y] = new double[w];
                    for (int x = 0; x < w; x++)
                    {
                        res[y][x] = br.ReadDouble();
                    }
                }
                br.Close();
                return res;
            }
            else
            {
                throw new InvalidDataException("Invalid matrix file signature");
            }
        }

        public static void SaveToFile(string file, double[][] matrix)
        {
            BinaryWriter bw = new BinaryWriter(new FileStream(file, FileMode.Create));
            bw.Write(SIGNATURE);
            bw.Write(matrix.Length);
            bw.Write(matrix[0].Length);
            for (int y = 0; y < matrix.Length; y++)
            {
                for (int x = 0; x < matrix[0].Length; x++)
                {
                    bw.Write(matrix[y][x]);
                }
            }
            bw.Close();
        }
    }
}
