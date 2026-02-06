using AuthService2021265.Application.Interfaces;

namespace AuthService2021265.Application.Interfaces;

public interface ICloudinaryService
{
    Task<string> UploadImageAsync(IFileData imageFile, string file);
    Task<bool> DeleteImageAsync(string publicId);
    string GetDefaultAvatarUrl();
    string GetFullImageUrl(string imagePath);

}