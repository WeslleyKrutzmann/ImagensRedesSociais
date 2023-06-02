using System.IO;
using System.Threading.Tasks;

namespace ImagensRedesSociais.Interfaces
{
    public interface IPhotoPickerService
    {
        Task<Stream> GetImageStreamAsync();
    }
}
