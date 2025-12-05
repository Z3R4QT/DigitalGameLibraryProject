using System;
using System.ComponentModel;
using DigitalGameLibrary.Models;

namespace DigitalGameLibrary.Repositories
{
    public class GameRepository
    {
        // Shared BindingList for all controls
        private static BindingList<Game> games = new BindingList<Game>();

        public void AddGame(Game game)
        {
            games.Add(game);
        }

        public BindingList<Game> GetAllGames()
        {
            return games;
        }

        public void ClearGames()
        {
            games.Clear();
        }

        public bool RemoveGame(Game game)
        {
            return games.Remove(game);
        }
        // Static constructor seeds data once when the repository type is first used.
        static GameRepository()
        {
            // Seed sample games only if the list is empty (defensive)
            if (games.Count == 0)
            {
                games.Add(new Game { Title = "The Witcher 3", Genre = "RPG", Platform = "PC", ReleaseDate = new DateTime(2015, 1, 1), VisibleInList = false });
                games.Add(new Game { Title = "FIFA 21", Genre = "Sports", Platform = "PlayStation", ReleaseDate = new DateTime(2020, 1, 1), VisibleInList = false });
                games.Add(new Game { Title = "Halo Infinite", Genre = "Shooter", Platform = "Xbox", ReleaseDate = new DateTime(2021, 1, 1), VisibleInList = false });
                games.Add(new Game { Title = "Minecraft", Genre = "Adventure", Platform = "PC", ReleaseDate = new DateTime(2011, 11, 18), VisibleInList = false });
                games.Add(new Game { Title = "God of War", Genre = "Action", Platform = "PlayStation", ReleaseDate = new DateTime(2018, 4, 20), VisibleInList = false });
                games.Add(new Game { Title = "Animal Crossing: New Horizons", Genre = "Simulation", Platform = "Nintendo Switch", ReleaseDate = new DateTime(2020, 3, 20), VisibleInList = false });
                games.Add(new Game { Title = "Call of Duty: Modern Warfare", Genre = "Shooter", Platform = "Xbox", ReleaseDate = new DateTime(2019, 10, 25), VisibleInList = false });
                games.Add(new Game { Title = "The Legend of Zelda: Breath of the Wild", Genre = "Adventure", Platform = "Nintendo Switch", ReleaseDate = new DateTime(2017, 3, 3), VisibleInList = false });
                games.Add(new Game { Title = "Among Us", Genre = "Puzzle", Platform = "Mobile", ReleaseDate = new DateTime(2018, 6, 15), VisibleInList = false });
                games.Add(new Game { Title = "Cyberpunk 2077", Genre = "RPG", Platform = "PC", ReleaseDate = new DateTime(2020, 12, 10), VisibleInList = false });
            }
        }
    }
}
