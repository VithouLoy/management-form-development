using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management.utils
{
    internal class ImageIOUtils
    {
        public static Image getImage(string id)
        {
            return Image.FromFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Images", id));
        }
    }
}
