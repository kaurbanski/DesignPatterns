using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Image : IImageInterface
    {
        public string GetImage()
        {
            return "Huge amounts of data";
        }
    }
}
