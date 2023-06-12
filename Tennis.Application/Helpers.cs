using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tennis.Application.Models;

namespace Tennis.Application
{
    public static class Helpers
    {
        internal static string RessourcesFolder = "Ressources";

        internal static string PlayersJson = "TennisData.json";

        internal static string GetPlayerJsonPath()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string assemblyLocation = assembly.Location;
            string assemblyDirectory = Path.GetDirectoryName(assemblyLocation);
            string filePath = Path.Combine(assemblyDirectory, RessourcesFolder, PlayersJson); // Replace with your file name and extension

            return filePath;
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
