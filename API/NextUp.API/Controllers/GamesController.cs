using Microsoft.AspNetCore.Mvc;
using NextUp.API.Data;
using NextUp.API.Interfaces;
using NextUp.API.Models.Domain;
using NextUp.API.Models.DTO;

namespace NextUp.API.Controllers
{
    public class GamesController : BaseApiController
    {
        private readonly IGameRepository _gameRepository;
        private readonly IUploadService _uploadService;

        public GamesController(IGameRepository gameRepository, IUploadService uploadService)
        {
            _gameRepository = gameRepository;
            _uploadService = uploadService;
        }

        [HttpPost]
        public async Task<IActionResult> AddGame([FromForm] AddGameRequestDto request)
        {
            var game = new Game
            {
                Name = request.Name,
                CoverImage = request.CoverImageFile != null ? await _uploadService.UploadImageAsync(request.CoverImageFile) : string.Empty,
                EstimatedLengthInHours = request.EstimatedLengthInHours,
                MetacriticScore = request.MetacriticScore,
                Purchased = request.Purchased
            };

            await _gameRepository.AddAsync(game);

            var response = new AddGameResponseDto
            {
                Id = game.Id,
                Name = game.Name,
                CoverImage = game.CoverImage,
                EstimatedLengthInHours = game.EstimatedLengthInHours,
                MetacriticScore = game.MetacriticScore,
                Purchased = game.Purchased
            };

            return Ok(response);
        }
    }
}
