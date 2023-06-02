using System.IO;

namespace ImagensRedesSociais.Event.Args
{
    public class ImageLoadedEventArgs
    {
        public Stream ImageStream { get; }

        public ImageLoadedEventArgs(Stream imageStream) {  ImageStream = imageStream; }
    }
}
