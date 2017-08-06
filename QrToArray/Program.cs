using System.Drawing;

namespace QrToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap bitmap;

            // QRコードのパス
            bitmap = new Bitmap("..\\..\\qr.png");
            // １ドットの大きさ
            const int marginPos = 100;
            // その隙間 (入力値の２倍開くはず)
            const int roundSize = 10;

            int width = bitmap.Width, height = bitmap.Height;

            Bitmap canvas = new Bitmap(width * marginPos, height * marginPos);
            Graphics g = Graphics.FromImage(canvas);

            for (int x = 0; x < width; ++x)
            {
                for (int y = 0; y < height; ++y)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    // ちょっとアレだけどRだけで判定しておく 状況次第では要変更
                    if((Color.Black.R == pixel.R))
                    {
                        g.FillEllipse(Brushes.White, x * marginPos + roundSize, y * marginPos + roundSize, marginPos - roundSize, marginPos - roundSize);
                    }
                }
            }
            g.Dispose();
            canvas.Save("../../save.png", System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
