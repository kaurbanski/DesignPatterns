using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ImageProxy : IImageInterface
    {
        private Image image;
        private int counter = 0;
        public string GetImage()
        {
            counter++;
            if (counter > 1)
            {
                if (image == null)
                {
                    image = new Image();
                }
                return image.GetImage();
            }
            return "Thumbnail of image";
        }
    }
}
