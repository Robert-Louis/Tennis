using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
