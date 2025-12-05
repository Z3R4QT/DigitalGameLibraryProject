using DigitalGameLibrary.Models;
using DigitalGameLibrary.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DigitalGameLibrary.Forms
{
    public partial class GameControl : UserControl
    {
        private GameRepository repo = new GameRepository();

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

            // Set year range
            numYear.Minimum = 2000;
            numYear.Maximum = 2025;
            numYear.Value = 2025;

            // Add sample games (hidden initially)
            // Sample games are seeded by the repository; no need to add here.

            // Setup Title ComboBox
            cmbTitle.DropDownStyle = ComboBoxStyle.DropDown; // editable
            LoadGameTitles();

            // No listbox in this control any more

            // Attach events
            cmbTitle.TextChanged += cmbTitle_TextChanged;
            cmbTitle.SelectedIndexChanged += cmbTitle_SelectedIndexChanged;

            // Designer handles button wiring for remaining buttons
        }

        // Sample games are seeded by the repository static constructor.

        // Load only visible games into ComboBox
        private void LoadGameTitles()
        {
            // Populate the title combo with all available game titles so the
            // dropdown shows items when the user presses the arrow.
            cmbTitle.Items.Clear();
            cmbTitle.Items.AddRange(repo.GetAllGames()
                                        .Select(g => g.Title)
                                        .ToArray());
        }

        // Auto-fill Genre, Platform, Year when selecting a game
        private void LoadGameDetails(Game game)
        {
            if (game == null) return;

            cmbTitle.Text = game.Title;
            cmbGenre.SelectedItem = game.Genre;
            cmbPlatform.SelectedItem = game.Platform;
            numYear.Value = game.ReleaseDate.Year;
        }

        // Searchable ComboBox logic
        private void cmbTitle_TextChanged(object sender, EventArgs e)
        {
            string typedText = cmbTitle.Text;
            if (string.IsNullOrWhiteSpace(typedText))
                return;

            int cursorPos = cmbTitle.SelectionStart;
            cmbTitle.TextChanged -= cmbTitle_TextChanged;

            // Find matching games
            var matches = repo.GetAllGames()
                              .Where(g => g.Title.IndexOf(typedText, StringComparison.OrdinalIgnoreCase) >= 0)
                              .ToArray();

            // Make first match visible in ComboBox
            if (matches.Length > 0)
                matches[0].VisibleInList = true;

            // Reload visible games
            LoadGameTitles();

            cmbTitle.Text = typedText;
            cmbTitle.SelectionStart = cursorPos;
            cmbTitle.SelectionLength = 0;
            cmbTitle.DroppedDown = matches.Length > 0;

            cmbTitle.TextChanged += cmbTitle_TextChanged;

            // Auto-fill first match details
            LoadGameDetails(matches.FirstOrDefault());
        }

        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGame = repo.GetAllGames()
                                   .FirstOrDefault(g => g.Title == cmbTitle.Text);
            LoadGameDetails(selectedGame);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbTitle.Text) || cmbGenre.SelectedIndex == -1 || cmbPlatform.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            // Add game and make it visible immediately
            Game game = new Game()
            {
                Title = cmbTitle.Text,
                Genre = cmbGenre.Text,
                Platform = cmbPlatform.Text,
                ReleaseDate = new DateTime((int)numYear.Value, 1, 1),
                VisibleInList = true
            };

            repo.AddGame(game);

            // Update UI
            LoadGameTitles();

            MessageBox.Show("Game added successfully!");

            // Clear inputs
            cmbTitle.Text = "";
            cmbGenre.SelectedIndex = -1;
            cmbPlatform.SelectedIndex = -1;
            numYear.Value = numYear.Maximum;

            LoadGameTitles();
        }

        // btnShowInGrid removed; no handler required.
    }
}
