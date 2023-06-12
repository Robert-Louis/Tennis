using Newtonsoft.Json;

namespace Tennis.Contracts.Responses
{
    public class CountryResponse
    {
        [JsonProperty("picture")]
        public required string Picture { get; init; }

        [JsonProperty("code")]
        public required string Code { get; init; }
    }
}
