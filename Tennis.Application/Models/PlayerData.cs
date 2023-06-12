namespace Tennis.Application.Models
{
    internal class Data
    {
        public required int Rank { get; init; }

        public required int Points { get; init; }

        public required int Weight { get; init; }

        public required int Height { get; init; }

        public required int Age { get; init; }

        public required IEnumerable<int> Last { get; init; } = Enumerable.Empty<int>();
    }
}
