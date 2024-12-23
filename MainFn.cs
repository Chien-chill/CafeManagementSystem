using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
namespace Phan_Mem_Quan_Ly
{
    internal class MainFn
    {
        public static byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                if (ImageFormat.Png.Equals(image.RawFormat))
                {
                    image.Save(ms, ImageFormat.Png);
                }
                else if (ImageFormat.Jpeg.Equals(image.RawFormat))
                {
                    using (var bitmap = new Bitmap(image))
                        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                return ms.ToArray();
            }
        }
        public static Image ByteArrayToImage(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
        public static bool CompareImages(Image img1, Image img2)
        {
            // Chuyển đổi ảnh thành byte array
            using (MemoryStream ms1 = new MemoryStream())
            using (MemoryStream ms2 = new MemoryStream())
            {
                img1.Save(ms1, img1.RawFormat);
                img2.Save(ms2, img2.RawFormat);

                byte[] bytes1 = ms1.ToArray();
                byte[] bytes2 = ms2.ToArray();

                return bytes1.SequenceEqual(bytes2);
            }
        }
        public static bool CompareString(string str1, string str2)
        {
            if (!str1.Equals("none") && str1.Equals(str2))
            {
                return true;
            }
            return false;
        }
        public static string FormatNumber(decimal value)
        {
            if (value >= 1_000_000_000)
                return (value / 1_000_000_000).ToString("0.#") + "B";
            else if (value >= 1_000_000)
                return (value / 1_000_000).ToString("0.#") + "M";
            else if (value >= 1_000)
                return (value / 1_000).ToString("0.#") + "K";
            else
                return value.ToString();
        }
    }
}
