using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Application.Models
{
    internal class Player
    {
        [JsonProperty("id")]
        public required int Id { get; init; }

        [JsonProperty("firstname")]
        public required string Firstname { get; init; }

        [JsonProperty("lastname")]
        public required string Lastname { get; init; }

        [JsonProperty("shortname")]
        public required string Shortname { get; init; }

        [JsonProperty("sex")]
        public required string Sex { get; init; }

        [JsonProperty("country")]
        public required CountryResponse Country { get; init; }

        [JsonProperty("picture")]
        public required string Picture { get; init; }

        [JsonProperty("data")]
        public required DataResponse Data { get; init; }
    }
}
