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

        public List<Game> GetAllGames()
        {
            if (!File.Exists(filePath))
                return new List<Game>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Game>>(json) ?? new List<Game>();
        }

        public void SaveGames(List<Game> games)
        {
            string json = JsonSerializer.Serialize(games, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public void AddGame(Game game)
        {
            var games = GetAllGames();
            games.Add(game);
            SaveGames(games);
        }

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

        public void RemoveGame(Game gameToRemove)
        {
            var games = GetAllGames();
            games.RemoveAll(g => g.Title == gameToRemove.Title);
            SaveGames(games);
        }
    }
}
