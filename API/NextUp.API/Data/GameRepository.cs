using NextUp.API.Interfaces;
using NextUp.API.Models.Domain;

namespace NextUp.API.Data
{
    public class GameRepository : IGameRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public GameRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Game> AddAsync(Game game)
        {
            await _dbContext.Games.AddAsync(game);
            await _dbContext.SaveChangesAsync();

            return game;
        }
    }
}
