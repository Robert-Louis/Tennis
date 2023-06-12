using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tennis.Application.Extensions;
using Tennis.Application.Models;

namespace Tennis.Application.Repository
{
    public class PlayersRepository : IPlayersRepository
    {
        string jsonFilePath = Helpers.GetPlayerJsonPath();

        private readonly IEnumerable<Player> _players;

        public PlayersRepository()
        {
            var json = File.ReadAllText(jsonFilePath);
            var players = JsonConvert.DeserializeObject<IEnumerable<Player>>(json);
            _players = players is not null ? players : Enumerable.Empty<Player>();
        }

        public Task<IEnumerable<Player>> GetAllAsync()
        {
            return Task.FromResult(_players);
        }

        public Task<Player?> GetAsync(int id)
        {
            var player = _players.SingleOrDefault(p => p.Id == id);
            return Task.FromResult(player);
        }

        public Task<Stats?> GetStatsAsync()
        {
            var test = _players.Select(p => p.Data.Last.Sum()).Sum();
            var countriesTotalScore = _players.GroupBy(p => p.Country)
                .Select(g => (g.Key, g
                    .Select(p => p.Data.Last.Sum())
                        .Sum())).OrderBy(o => o.Item2);

            var median = Helpers.GetMedianFromInts(_players.Select(p => p.Data.Height));
            var averageIMC = _players.Select(p => p.IMC()).Average();
            var WinningCountry = countriesTotalScore.FirstOrDefault().Key;

            var stats = new Stats() 
            { 
                PlayerHeightMedian = median, 
                PlayerAverageIMC = averageIMC, 
                WinningCountry = WinningCountry};
            throw new NotImplementedException();
        }
    }
}
