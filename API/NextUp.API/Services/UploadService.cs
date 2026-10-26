using Microsoft.Extensions.Options;
using NextUp.API.Interfaces;
using NextUp.API.Models.Configuration;

namespace NextUp.API.Services
{
    public class UploadService : IUploadService
    {
        private readonly FileStorageSettings _storageSettings;

        public UploadService(IOptions<FileStorageSettings> storageOptions)
        {
            _storageSettings = storageOptions.Value;
        }

        public async Task DeleteImageAsync(string imageName)
        {
            throw new NotImplementedException();
        }

        public async Task<string> UploadImageAsync(IFormFile file)
        {
            if (file == null || file.Length == 0) return string.Empty;

            string targetFolder = _storageSettings.LocalImageDirectory;
            string uniqueName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string fullPhysicalPath = Path.Combine(targetFolder, uniqueName);

            using (var stream = new FileStream(fullPhysicalPath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return uniqueName;
        }
    }
}
