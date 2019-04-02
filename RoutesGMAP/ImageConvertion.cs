using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutesGMAP
{
    class ImageConvertion
    {
        public static Image RetriveImage(byte[] img)
        {
            using (MemoryStream ms = new MemoryStream(img))
            {
                return Image.FromStream(ms);
            }
        }
        public static byte[] ConvertToByteArray(Image img)
        {
            ImageConverter imgc = new ImageConverter();
            return (byte[])imgc.ConvertTo(img, Type.GetType("System.Byte[]"));
        }
    }
}
