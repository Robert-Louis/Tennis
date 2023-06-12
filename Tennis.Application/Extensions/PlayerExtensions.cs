using Tennis.Application.Models;

namespace Tennis.Application.Extensions
{
    public static class PlayerExtensions
    {
        internal static int IMC(this Player player)
        {
            //IMC = Poids / Taille x Taille

            var playerData = player.Data;

            return playerData.Weight / (playerData.Height * playerData.Height);
        }
    }
}
