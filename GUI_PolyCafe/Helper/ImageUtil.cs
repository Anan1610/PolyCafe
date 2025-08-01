﻿using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace GUI_PolyCafe.Helper
{
    public class ImageUtil
    {
        public static byte[] ImageToByteArray(Image img)
        {
            if (img == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0) return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        public static string SaveImage(Image img, string folderPath)
        {
            if (img == null) return null;

            if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(folderPath, Guid.NewGuid().ToString() + ".jpg");
            img.Save(filePath, ImageFormat.Jpeg);

            return filePath;
        }

        public static void DeleteImage(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
            }
        }

        public static Image LoadImage(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                return Image.FromFile(imagePath);
            }
            return Properties.Resources.default_image;
        }
    }
}
