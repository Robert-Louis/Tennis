using Microsoft.AspNetCore.Mvc;
using Tennis.Api.Mapping;
using Tennis.Application.Repository;

namespace Tennis.Api.Controllers
{
    [ApiController]
    public class PlayersControllers : ControllerBase
    {
        private readonly IPlayersRepository _moviesRepository;

        public PlayersControllers(IPlayersRepository moviesRepository)
        {
            _moviesRepository = moviesRepository;
        }

        [HttpGet(ApiEndpoints.Players.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            var players = await _moviesRepository.GetAllAsync();

            var response = players.Select(player => player.MapToResponse());

            return Ok(response);
        }

        [HttpGet(ApiEndpoints.Players.Get)]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var player = await _moviesRepository.GetAsync(id);
            if (player == null)
            {
                return NotFound();
            }
            var response = player.MapToResponse();
            return Ok(response);
        }

        [HttpGet(ApiEndpoints.Players.GetStats)]
        public async Task<IActionResult> GetStats()
        {
            var stats = await _moviesRepository.GetStatsAsync();
            if (stats == null)
            {
                return NotFound();
            }
            var response = stats.MapToResponse();
            return Ok(response);
        }
    }
}
