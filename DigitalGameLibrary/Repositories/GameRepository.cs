using DigitalGameLibrary.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace DigitalGameLibrary.Repositories
{
    public class GameRepository
    {
        private string filePath = "games.json";

        // Load all games
        public List<Game> GetAllGames()
        {
            if (!File.Exists(filePath))
                return new List<Game>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Game>>(json) ?? new List<Game>();
        }

        // Save the full game list
        public void SaveGames(List<Game> games)
        {
            string json = JsonSerializer.Serialize(games, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        // Add a new game
        public void AddGame(Game game)
        {
            var games = GetAllGames();
            games.Add(game);
            SaveGames(games);
        }

        // Update an existing game
        public void UpdateGame(Game updatedGame)
        {
            var games = GetAllGames();
            var index = games.FindIndex(g => g.Title == updatedGame.Title);
            if (index >= 0)
            {
                games[index] = updatedGame;
                SaveGames(games);
            }
        }

        // Remove a game
        public void RemoveGame(Game gameToRemove)
        {
            var games = GetAllGames();
            games.RemoveAll(g => g.Title == gameToRemove.Title);
            SaveGames(games);
        }
    }
}
