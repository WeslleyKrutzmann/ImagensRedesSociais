using ImageMagick;

namespace ImagensRedesSociais.Interfaces
{
    public interface IImage
    {
        void Resize(MagickImage image, int width, int height);
        void Crop(MagickImage image, int x, int y, int width, int height);
    }
}
