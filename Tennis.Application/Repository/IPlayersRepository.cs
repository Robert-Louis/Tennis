using Tennis.Application.Models;

namespace Tennis.Application.Repository
{
    public interface IPlayersRepository
    {
        Task<IEnumerable<Player>> GetAllAsync();

        Task<Player?> GetAsync(int id);

        Task<Stats?> GetStatsAsync();
    }
}
