using System.Numerics;
using Tennis.Application.Models;
using Tennis.Contracts.Responses;

namespace Tennis.Api.Mapping
{
    public static class ContractMapping
    {
        public static CountryResponse MapToResponse(this Country country)
        {
            return new CountryResponse()
            {
                Code = country.Code,
                Picture = country.Picture,
            };
        }

        public static PlayerDataResponse MapToResponse(this PlayerData playerData)
        {
            return new PlayerDataResponse() 
            {  
                Age = playerData.Age, 
                Height = playerData.Height, 
                Last =  playerData.Last, 
                Points = playerData.Points, 
                Rank = playerData.Rank, 
                Weight = playerData.Weight 
            };
        }

        public static PlayerResponse MapToResponse(this Player player)
        {
            return new PlayerResponse
            {
                Id = player.Id,
                Country = player.Country.MapToResponse(),
                Data = player.Data.MapToResponse(),
                Firstname = player.Firstname, 
                Lastname = player.Lastname, 
                Picture = player.Picture, 
                Sex = player.Sex, 
                Shortname = player.Shortname
            };
        }

        public static StatsResponse MapToResponse(this Stats stats)
        {
            return new StatsResponse() 
            {  
                PlayersHeightMedian = stats.PlayersHeightMedian, 
                PlayersAverageIMC = stats.PlayersAverageIMC, 
                WinningCountry = stats.WinningCountry.MapToResponse()
            };

        }
    }
}
