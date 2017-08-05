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
            bitmap = new Bitmap("local.png");
            // Webの場合
            var wc = new System.Net.WebClient();
            var stream = wc.OpenRead("http://hogehoge/hoge.png");
            bitmap = new Bitmap(stream);
            wc.Dispose();
            stream.Close();
        }
    }
}
