namespace Tennis.Application.Models
{
    public class Stats
    {
        public required Country WinningCountry { get; init; }

        public required double PlayersAverageIMC { get; init; }

        public required double PlayersHeightMedian { get; init; }
    }
}
