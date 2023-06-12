# Tennis API

Simple API to get a list of Tennis player or a specific player by they id. 

The current version provide three endpoint. 

- Players
Accessible by /api/players. Return a list of all players
- Player 
Accessible by /api/{id}. Fetch a player by they id. 
- Global Statistique 
Accessible by /api/Stats. Information about the winning country, Average IMC and the median height 

## Testing the API 

1. Download the project from the repo.
2. Open the solution in your favorite IDE. 
3. Launch the Tennis.Api project.
4. Use the swagger page that openned in your favorite web browser to explore the api. 

## Futur improvement 
 - decouple the data from the repository 
 - create a json with non viable data to create usefull unit test