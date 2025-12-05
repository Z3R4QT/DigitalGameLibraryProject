using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DigitalGameLibrary.Models;

namespace DigitalGameLibrary.Forms
{
    public partial class DashboardControl : UserControl
    {
        // Assuming you have access to your lists of games and users
        public List<Game> games = new List<Game>();
        public List<User> users = new List<User>();

        public DashboardControl()
        {
            InitializeComponent();
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            LoadDashboard(); // Just call the method here
        }

        // This method should be outside of DashboardControl_Load
        private void LoadDashboard()
        {
            // Total games and users
            lblTotalGames.Text = games.Count.ToString();
            lblTotalUsers.Text = users.Count.ToString();

            // Most popular genre
            var mostPopularGenre = games
                .GroupBy(g => g.Genre)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault()?.Key ?? "None";

            lblPopularGenre.Text = mostPopularGenre;

            // Recent games (show top 5)
            var recentGames = games
                .OrderByDescending(g => g.ReleaseDate)
                .Take(5)
                .ToList();

            // Set the Label text with line breaks
            lstRecentGames.Text = string.Join(Environment.NewLine, recentGames.Select(g => g.Title));
        }
    }
}