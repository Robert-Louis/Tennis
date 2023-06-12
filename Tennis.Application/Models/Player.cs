using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Application.Models
{
    public class Player
    {
        public required int Id { get; init; }

        public required string Firstname { get; init; }

        public required string Lastname { get; init; }

        public required string Shortname { get; init; }

        public required string Sex { get; init; }

        public required Country Country { get; init; }

        public required string Picture { get; init; }

        public required PlayerData Data { get; init; }
    }
}
