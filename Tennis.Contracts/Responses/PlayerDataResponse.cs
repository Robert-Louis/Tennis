using Newtonsoft.Json;

namespace Tennis.Contracts.Responses
{
    public class PlayerDataResponse
    {
        [JsonProperty("rank")]
        public required int Rank { get; init; }

        [JsonProperty("points")]
        public required int Points { get; init; }

        [JsonProperty("weight")]
        public required int Weight { get; init; }

        [JsonProperty("height")]
        public required int Height { get; init; }

        [JsonProperty("age")]
        public required int Age { get; init; }

        [JsonProperty("last")]
        public required IEnumerable<int> Last { get; init; } = Enumerable.Empty<int>();
    }
}
