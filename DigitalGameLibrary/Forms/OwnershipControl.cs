using DigitalGameLibrary.Models;
using DigitalGameLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DigitalGameLibrary.Forms
{
    public partial class OwnershipControl : UserControl
    {
        private Dictionary<string, List<string>> ownership;
        private OwnershipRepository ownershipRepo = new OwnershipRepository();
        private GameRepository gameRepo = new GameRepository();
        private List<Game> allGames;

        public OwnershipControl()
        {
            InitializeComponent();
            this.Load += OwnershipControl_Load;
        }

        private void OwnershipControl_Load(object sender, EventArgs e)
        {
            // Load ownership and games from file
            ownership = ownershipRepo.LoadOwnership() ?? new Dictionary<string, List<string>>();
            allGames = gameRepo.GetAllGames() ?? new List<Game>();

            // Populate all games ListBox with total header
            RefreshAllGamesList();

            // Populate users ComboBox
            cmbUsers.Items.Clear();
            foreach (var user in ownership.Keys)
                cmbUsers.Items.Add(user);

            // Display user-owned games
            lstOwnedGames.DisplayMember = "Title";

            // Wire events
            btnAddUser.Click += BtnAddUser_Click;
            btnRemove.Click += BtnRemoveUser_Click;
            btnAddOwnership.Click += BtnAddOwnership_Click;
            btnRemoveOwnership.Click += BtnRemoveOwnership_Click;
            cmbUsers.SelectedIndexChanged += CmbUsers_SelectedIndexChanged;
        }

        private void RefreshAllGamesList()
        {
            lstGames.Items.Clear();
            lstGames.Items.Add($"TOTAL GAMES: {allGames.Count}");
            lstGames.Items.AddRange(allGames.ToArray());
            lstGames.DisplayMember = "Title";
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtNewUser.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Enter a username first!");
                return;
            }

            if (!ownership.ContainsKey(username))
            {
                ownership[username] = new List<string>();
                cmbUsers.Items.Add(username);
                ownershipRepo.SaveOwnership(ownership);
                txtNewUser.Clear();
                MessageBox.Show($"User '{username}' added.");
            }
            else
            {
                MessageBox.Show("This user already exists.");
            }
        }

        private void BtnRemoveUser_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedIndex == -1)
            {
                MessageBox.Show("Select a user to remove.");
                return;
            }

            string user = cmbUsers.SelectedItem.ToString();
            var confirm = MessageBox.Show($"Are you sure you want to remove user '{user}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            ownership.Remove(user);
            cmbUsers.Items.Remove(user);
            LoadUserGames(user); // refresh owned games list
            ownershipRepo.SaveOwnership(ownership);

            MessageBox.Show($"User '{user}' removed successfully.");
        }

        private void BtnAddOwnership_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedIndex == -1 || lstGames.SelectedItem == null)
            {
                MessageBox.Show("Select a user and a game first.");
                return;
            }

            string user = cmbUsers.SelectedItem.ToString();
            Game selectedGame = (Game)lstGames.SelectedItem;

            if (!ownership[user].Contains(selectedGame.Title))
            {
                ownership[user].Add(selectedGame.Title);
                LoadUserGames(user);
                ownershipRepo.SaveOwnership(ownership);
            }
            else
            {
                MessageBox.Show($"User '{user}' already owns '{selectedGame.Title}'.");
            }
        }

        private void BtnRemoveOwnership_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedIndex == -1 || lstOwnedGames.SelectedItem == null)
            {
                MessageBox.Show("Select a user and a game to remove.");
                return;
            }

            string user = cmbUsers.SelectedItem.ToString();
            Game selectedGame = (Game)lstOwnedGames.SelectedItem;

            ownership[user].Remove(selectedGame.Title);
            LoadUserGames(user);
            ownershipRepo.SaveOwnership(ownership);
        }

        private void CmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedIndex != -1)
                LoadUserGames(cmbUsers.SelectedItem.ToString());
        }

        private void LoadUserGames(string user)
        {
            lstOwnedGames.Items.Clear();

            if (ownership.ContainsKey(user))
            {
                // Add header showing total games owned
                lstOwnedGames.Items.Add($"TOTAL GAMES: {ownership[user].Count}");

                foreach (string title in ownership[user])
                {
                    Game game = allGames.FirstOrDefault(g => g.Title == title);
                    if (game != null)
                        lstOwnedGames.Items.Add(game);
                }
            }
            else
            {
                lstOwnedGames.Items.Add("TOTAL GAMES: 0");
            }
        }
    }
}
