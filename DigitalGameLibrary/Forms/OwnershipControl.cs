using DigitalGameLibrary.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigitalGameLibrary.Forms
{
    public partial class OwnershipControl : UserControl
    {
        // Make ownership a class-level variable so all methods can access it
        private Dictionary<string, List<Game>> ownership = new Dictionary<string, List<Game>>();

        // Add this field to the OwnershipControl class to fix CS0103
        private ListBox lstAllGames;

        public OwnershipControl()
        {
            InitializeComponent();
            // If lstAllGames is not already created by the designer, uncomment the following:
            // lstAllGames = new ListBox();
        }

        private void OwnershipControl_Load(object sender, EventArgs e)
        {
            // Optionally populate cmbUsers and lstAllGames here
            // Example:
            // cmbUsers.Items.Add("User1");
            // lstAllGames.Items.Add(new Game { Title = "Game1", Genre = "Action", Platform = "PC", Year = 2025 });
        }

        private void btnAddOwnership_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedIndex == -1 || lstAllGames.SelectedItem == null)
                return;

            string user = cmbUsers.SelectedItem.ToString();
            Game game = (Game)lstAllGames.SelectedItem;

            if (!ownership.ContainsKey(user))
                ownership[user] = new List<Game>();

            ownership[user].Add(game);
            LoadUserGames(user);
        }

        private void LoadUserGames(string user)
        {
            lstOwnedGames.Items.Clear();
            if (ownership.ContainsKey(user))
                lstOwnedGames.Items.AddRange(ownership[user].ToArray());
        }
    }
}
