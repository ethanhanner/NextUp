namespace NextUp.API.Interfaces
{
    public interface IUploadService
    {
        Task<string> UploadImageAsync(IFormFile file);
        Task DeleteImageAsync(string imageName);
    }
}
