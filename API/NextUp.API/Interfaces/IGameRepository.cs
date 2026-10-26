using NextUp.API.Models.Domain;

namespace NextUp.API.Interfaces
{
    public interface IGameRepository
    {
        Task<Game> AddAsync(Game game);
    }
}
