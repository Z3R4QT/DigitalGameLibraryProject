using DigitalGameLibrary.Models;
using DigitalGameLibrary.Repositories;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DigitalGameLibrary.Forms
{
    public partial class ManageControl : UserControl
    {
        private GameRepository repo = new GameRepository();
        private BindingList<Game> gamesBindingList;
        private BindingSource bindingSource = new BindingSource();

        private Game selectedGame; // currently selected game
        private HashSet<Game> gamesToDelete = new HashSet<Game>(); // track games marked for deletion
        private Dictionary<string, bool> sortDirections = new Dictionary<string, bool>(); // track sort direction per column

        public ManageControl()
        {
            InitializeComponent();
            this.Load += ManageControl_Load;
        }

        private void ManageControl_Load(object sender, EventArgs e)
        {
            // Configure DataGridView
            dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGames.ReadOnly = true;
            dgvGames.AllowUserToAddRows = false;
            dgvGames.AllowUserToDeleteRows = false;
            dgvGames.AutoGenerateColumns = true;

            // Load games from file
            var games = repo.GetAllGames() ?? new List<Game>();
            gamesBindingList = new BindingList<Game>(games);
            bindingSource.DataSource = gamesBindingList;
            dgvGames.DataSource = bindingSource;

            // Hide ReleaseDate column if exists
            if (dgvGames.Columns.Contains("ReleaseDate"))
                dgvGames.Columns["ReleaseDate"].Visible = false;

            // Set sort mode for columns and initialize sort directions
            foreach (DataGridViewColumn col in dgvGames.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Programmatic;
                sortDirections[col.DataPropertyName] = true; // default ascending
            }

            dgvGames.ClearSelection();

            // Wire buttons
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            btnRefresh.Click += BtnRefresh_Click;

            dgvGames.CellClick += DgvGames_CellClick;
            dgvGames.ColumnHeaderMouseClick += DgvGames_ColumnHeaderMouseClick;
        }

        // Handle header click to sort
        private void DgvGames_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dgvGames.Columns[e.ColumnIndex].DataPropertyName;
            SortByColumn(columnName);
        }

        private void DgvGames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedGame = dgvGames.Rows[e.RowIndex].DataBoundItem as Game;
            if (selectedGame != null)
            {
                txtTitle.Text = selectedGame.Title;
                txtGenre.Text = selectedGame.Genre;
                txtPlatform.Text = selectedGame.Platform;

                // Highlight deleted games visually
                dgvGames.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                    gamesToDelete.Contains(selectedGame) ? System.Drawing.Color.LightCoral : System.Drawing.Color.White;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (selectedGame == null)
            {
                MessageBox.Show("Please select a game to edit.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtGenre.Text) ||
                string.IsNullOrWhiteSpace(txtPlatform.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            selectedGame.Title = txtTitle.Text;
            selectedGame.Genre = txtGenre.Text;
            selectedGame.Platform = txtPlatform.Text;

            // Save changes to file
            repo.UpdateGame(selectedGame);
            bindingSource.ResetBindings(false);

            MessageBox.Show("Game updated successfully!");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (selectedGame == null)
            {
                MessageBox.Show("Please select a game to delete.");
                return;
            }

            if (!gamesToDelete.Contains(selectedGame))
            {
                gamesToDelete.Add(selectedGame);

                // Highlight row in red
                var rowIndex = dgvGames.Rows.Cast<DataGridViewRow>()
                    .First(r => r.DataBoundItem == selectedGame).Index;
                dgvGames.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;

                MessageBox.Show($"Game '{selectedGame.Title}' marked for deletion. Press Refresh to delete.");
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            foreach (var game in gamesToDelete)
            {
                repo.RemoveGame(game);
                gamesBindingList.Remove(game);
            }

            gamesToDelete.Clear();
            bindingSource.ResetBindings(false);
            dgvGames.ClearSelection();

            MessageBox.Show("Marked games deleted successfully!");
        }

        public void AddGameToGrid(Game game)
        {
            if (game == null) return;
            gamesBindingList.Add(game);
            repo.AddGame(game); // save to file
            bindingSource.ResetBindings(false);
        }

        // Generic sort method
        private void SortByColumn(string columnName)
        {
            if (!sortDirections.ContainsKey(columnName)) return;

            bool ascending = sortDirections[columnName];

            var sortedList = ascending
                ? gamesBindingList.OrderBy(g => g.GetType().GetProperty(columnName).GetValue(g)).ToList()
                : gamesBindingList.OrderByDescending(g => g.GetType().GetProperty(columnName).GetValue(g)).ToList();

            gamesBindingList = new BindingList<Game>(sortedList);
            bindingSource.DataSource = gamesBindingList;
            dgvGames.DataSource = bindingSource;

            sortDirections[columnName] = !ascending; // toggle for next click
        }
    }
}
