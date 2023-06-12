using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Contracts.Responses
{
    public class PlayersResponse
    {
        public required IEnumerable<PlayerResponse> Items { get; init; } = Enumerable.Empty<PlayerResponse>();
    }
}
