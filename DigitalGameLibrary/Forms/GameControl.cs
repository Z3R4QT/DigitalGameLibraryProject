using System;
using System.Linq;
using System.Windows.Forms;
using DigitalGameLibrary.Models;
using DigitalGameLibrary.Repositories;

namespace DigitalGameLibrary.Forms
{
    public partial class GameControl : UserControl
    {
        private GameRepository repo = new GameRepository();

        // Event to notify ManageControl when a game is added
        public event EventHandler<Game> GameAdded;

        private bool isUpdatingCombo = false; // prevent recursion

        public GameControl()
        {
            InitializeComponent();
            this.Load += GameControl_Load;
        }

        private void GameControl_Load(object sender, EventArgs e)
        {
            // Populate Genre ComboBox
            cmbGenre.Items.Clear();
            cmbGenre.Items.AddRange(new string[]
            {
                "Action", "Adventure", "RPG", "Shooter", "Strategy",
                "Simulation", "Sports", "Puzzle", "Horror"
            });
            cmbGenre.SelectedIndex = -1;

            // Populate Platform ComboBox
            cmbPlatform.Items.Clear();
            cmbPlatform.Items.AddRange(new string[]
            {
                "PC", "PlayStation", "Xbox", "Nintendo Switch", "Mobile"
            });
            cmbPlatform.SelectedIndex = -1;

            // Make Title ComboBox editable but remove inline autocomplete
            cmbTitle.DropDownStyle = ComboBoxStyle.DropDown; // editable
            cmbTitle.AutoCompleteMode = AutoCompleteMode.None; // disable inline autocomplete
            cmbTitle.AutoCompleteSource = AutoCompleteSource.None;

            LoadGameTitles();

            // Wire events
            cmbTitle.SelectedIndexChanged += cmbTitle_SelectedIndexChanged;
            btnAdd.Click += btnAdd_Click;
        }

        // Load titles into ComboBox dropdown only
        private void LoadGameTitles()
        {
            var titles = repo.GetAllGames()
                             .Where(g => !string.IsNullOrWhiteSpace(g.Title))
                             .Select(g => g.Title)
                             .ToArray();

            isUpdatingCombo = true;
            cmbTitle.Items.Clear();
            cmbTitle.Items.AddRange(titles);
            isUpdatingCombo = false;
        }

        private void LoadGameDetails(Game game)
        {
            if (game == null) return;

            isUpdatingCombo = true;
            cmbTitle.Text = game.Title;
            cmbGenre.SelectedItem = game.Genre;
            cmbPlatform.SelectedItem = game.Platform;
            isUpdatingCombo = false;
        }

        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdatingCombo) return;

            var selectedGame = repo.GetAllGames()
                                   .FirstOrDefault(g => g.Title == cmbTitle.Text);
            LoadGameDetails(selectedGame);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbTitle.Text) ||
                cmbGenre.SelectedIndex == -1 ||
                cmbPlatform.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (repo.GetAllGames().Any(g => g.Title.Equals(cmbTitle.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("This game already exists.");
                return;
            }

            var game = new Game()
            {
                Title = cmbTitle.Text,
                Genre = cmbGenre.Text,
                Platform = cmbPlatform.Text
            };

            repo.AddGame(game);

            // Notify ManageControl
            GameAdded?.Invoke(this, game);

            LoadGameTitles();

            MessageBox.Show("Game added successfully!");

            // Clear inputs
            cmbTitle.Text = "";
            cmbGenre.SelectedIndex = -1;
            cmbPlatform.SelectedIndex = -1;
        }
    }
}
