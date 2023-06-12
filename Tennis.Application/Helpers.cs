using System.Reflection;

namespace Tennis.Application
{
    public static class Helpers
    {
        internal static string RessourcesFolder = "Ressources";

        internal static string PlayersJson = "TennisData.json";

        internal static string GetPlayerJson()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var jsonPath = assembly.GetManifestResourceNames()
              .Single(str => str.EndsWith(PlayersJson));

            using Stream stream = assembly.GetManifestResourceStream(jsonPath);
            using StreamReader reader = new StreamReader(stream);

            return reader.ReadToEnd();
        }

        internal static double GetMedianFromInts(IEnumerable<int> ints) 
        {
            if (!ints.Any()) 
            {
                return 0;
            }
            var orderedList = ints.Order().ToArray();
            var count = orderedList.Count();

            if (count is 1)
            {
                return orderedList[0];
            }
            else if (count % 2 is 0)
            {
                var first = (count /2) -1;
                var second = (count / 2);
                return (orderedList[first] + orderedList[second]) /2;
            }
            else
            {
                var position = count / 2;
                return orderedList[position];
            }
        }
    }
}
