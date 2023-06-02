using ImageMagick;
using ImagensRedesSociais.Interfaces;
using System;

namespace ImagensRedesSociais.Services
{
    public class Image : IImage
    {
        public void Crop(MagickImage image, int x, int y, int width, int height)
        {
            throw new NotImplementedException();
        }

        public void Resize(MagickImage image, int width, int height)
        {
            throw new NotImplementedException();
        }
    }
}
