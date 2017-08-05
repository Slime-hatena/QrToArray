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
            const int marginPos = 1;

            Bitmap canvas = new Bitmap(width * marginPos, height * marginPos);
            Graphics g = Graphics.FromImage(canvas);
            Pen p = new Pen(Color.White, marginPos );

            for (int x = width - 1; x >= 0; --x)
            {

                for (int y = height - 1; y >= 0; --y)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    if((Color.Black.R == pixel.R))
                    {
                        g.DrawLine(p, x * marginPos, y * marginPos, x * marginPos, y * marginPos);
                    }
                }
            }

            p.Dispose();
            g.Dispose();
            //PictureBox1に表示する
            canvas.Save("../../save.png", System.Drawing.Imaging.ImageFormat.Png);

        }
    }
}
