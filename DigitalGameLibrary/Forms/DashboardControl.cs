using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DigitalGameLibrary.Models;
using DigitalGameLibrary.Repositories;

namespace DigitalGameLibrary.Forms
{
    public partial class DashboardControl : UserControl
    {
        private GameRepository gameRepo = new GameRepository();
        private OwnershipRepository ownershipRepo = new OwnershipRepository();

        private List<Game> games = new List<Game>();
        private Dictionary<string, List<string>> ownership = new Dictionary<string, List<string>>();

        public DashboardControl()
        {
            InitializeComponent();
            this.Load += DashboardControl_Load;
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            LoadData();
            DisplayStats();
        }

        private void LoadData()
        {
            games = gameRepo.GetAllGames() ?? new List<Game>();
            ownership = ownershipRepo.LoadOwnership() ?? new Dictionary<string, List<string>>();
        }

        private void DisplayStats()
        {
            lblTotalGames.Text = $"TOTAL GAMES: {games.Count}";
            lblTotalUsers.Text = $"TOTAL USERS: {ownership.Keys.Count}";

            string popularGenre = games
                .GroupBy(g => g.Genre)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault()?.Key ?? "None";

            lblPopularGenre.Text = $"MOST POPULAR GENRE: {popularGenre}";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            DisplayStats();
        }
    }
}
