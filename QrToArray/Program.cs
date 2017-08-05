using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap bitmap;
            // ローカルファイルの場合
            bitmap = new Bitmap("C:\\Development\\CSharp\\QrToArray\\QrToArray\\qr.png");

            int width = bitmap.Width, height = bitmap.Height;
            bool[,] dotState = new bool[width, height];

            Console.Write("\n\n\n\n");
            for (int x = width - 1; x >= 0; --x)
            {
                Console.Write("        ");
                for (int y = height - 1; y >= 0; --y)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    if (Color.Black.R == pixel.R)
                    {
                        Console.Write("■");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.Write("\n");
            }
            Console.Read();
            Console.Read();
            Console.Read();
        }
    }
}
