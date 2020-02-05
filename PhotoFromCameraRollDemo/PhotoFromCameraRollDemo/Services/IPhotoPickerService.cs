using System.IO;
using System.Threading.Tasks;

namespace PhotoFromCameraRollDemo
{
  public interface IPhotoPickerService
  {
    Task<Stream> GetImageStreamAsync();
  }
}