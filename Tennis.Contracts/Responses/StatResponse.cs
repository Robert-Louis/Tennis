using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Contracts.Responses
{
    public class StatResponse
    {
        [JsonProperty("winningCountry")]
        public required string WinningCountry { get; init; }

        [JsonProperty("playerIMC")]
        public required int PlayerIMC { get; init; }

        [JsonProperty("playerMedian")]
        public required int PlayerHeightMedian { get; init; }
    }
}
