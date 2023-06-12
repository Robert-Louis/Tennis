namespace Tennis.Application.Models
{
    public class Stats
    {
        public required Country WinningCountry { get; init; }

        public required double PlayerAverageIMC { get; init; }

        public required double PlayerHeightMedian { get; init; }
    }
}
