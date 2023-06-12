using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Contracts.Responses
{
    public class StatsResponse
    {
        [JsonProperty("winningCountry")]
        public required CountryResponse WinningCountry { get; init; }

        [JsonProperty("playerIMC")]
        public required double PlayersAverageIMC { get; init; }

        [JsonProperty("playerMedian")]
        public required double PlayersHeightMedian { get; init; }
    }
}
