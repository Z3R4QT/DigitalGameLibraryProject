using DigitalGameLibrary.Models;
using DigitalGameLibrary.Repositories;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace DigitalGameLibrary.Forms
{
    public partial class ManageControl : UserControl
    {
        private GameRepository repo = new GameRepository();
        private BindingSource bindingSource = new BindingSource();
        private const int MaxVisibleGames = 3;

        public ManageControl()
        {
            InitializeComponent();
            this.Load += ManageControl_Load;
        }

        private void ManageControl_Load(object sender, EventArgs e)
        {
            dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Allow inline editing in the grid
            dgvGames.ReadOnly = false;
            // Allow deleting rows from the grid (will remove from repository when using the Delete button)
            dgvGames.AllowUserToDeleteRows = true;
            dgvGames.AutoGenerateColumns = true;
            dgvGames.AllowUserToAddRows = false;

            // Bind shared list to BindingSource
            bindingSource.DataSource = repo.GetAllGames();
            dgvGames.DataSource = bindingSource;

            // Hide internal flag from the user-facing grid after binding
            dgvGames.DataBindingComplete -= DgvGames_DataBindingComplete;
            dgvGames.DataBindingComplete += DgvGames_DataBindingComplete;

            // Ensure grid shows only limited number of rows and updates when repo changes
            var list = repo.GetAllGames();
            // Guard against duplicate subscriptions if control is recreated
            list.ListChanged -= Games_ListChanged;
            list.ListChanged += Games_ListChanged;

            // Apply initial filter/limit
            ApplyFilter();
            // Wire up control events (designer didn't generate event hookups)
            btnDelete.Click += btnDelete_Click;
            btnEdit.Click += btnEdit_Click;
            btnRefresh.Click += btnRefresh_Click;
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void DgvGames_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (dgvGames.Columns.Contains("VisibleInList"))
                    dgvGames.Columns["VisibleInList"].Visible = false;
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGames.CurrentRow == null) return;

            var game = dgvGames.CurrentRow.DataBoundItem as Game;
            if (game != null)
            {
                // Mark as not visible anywhere (defensive) and remove via repository API
                game.VisibleInList = false;
                repo.RemoveGame(game);
                // Re-apply filter so the grid reflects the current search state
                ApplyFilter();
                MessageBox.Show("Game deleted!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvGames.CurrentRow == null) return;

            var game = dgvGames.CurrentRow.DataBoundItem as Game;
            if (game != null)
            {
                string newTitle = Microsoft.VisualBasic.Interaction.InputBox(
                    "Edit Game Title:", "Edit Game", game.Title);

                if (!string.IsNullOrWhiteSpace(newTitle))
                {
                    game.Title = newTitle;
                    // Re-apply filter so the grid reflects the current search state
                    ApplyFilter();
                    MessageBox.Show("Game updated!");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Use ApplyFilter to keep filtering logic in one place
            ApplyFilter();
            dgvGames.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ApplyFilter();
            dgvGames.Refresh();
        }

        private void ApplyFilter()
        {
            string query = txtSearch.Text?.Trim().ToLower();

            // Always keep the binding source bound to the repository's shared list so
            // edits and deletions affect the real data.
            bindingSource.DataSource = repo.GetAllGames();
            // Update visibility safely. Changing row visibility can cause
            // InvalidOperationException if the grid is processing other updates
            // or the current cell becomes invalid. Suspend layout and clear
            // the current cell during updates, and catch exceptions per-row.
            dgvGames.SuspendLayout();
            var previousCurrentCell = dgvGames.CurrentCell;
            try
            {
                dgvGames.ClearSelection();

                int shown = 0;
                foreach (DataGridViewRow row in dgvGames.Rows)
                {
                    var game = row.DataBoundItem as Game;
                    if (game == null)
                    {
                        try { row.Visible = false; } catch { }
                        continue;
                    }

                    bool matches = string.IsNullOrEmpty(query) || (!string.IsNullOrEmpty(game.Title) && game.Title.ToLower().Contains(query));
                    bool makeVisible = matches && shown < MaxVisibleGames;
                    try
                    {
                        row.Visible = makeVisible;
                    }
                    catch (InvalidOperationException)
                    {
                        // Ignore and continue; row visibility couldn't be changed right now.
                    }

                    if (makeVisible) shown++;
                }
            }
            finally
            {
                // Restore previous current cell if still valid
                try
                {
                    if (previousCurrentCell != null && previousCurrentCell.DataGridView != null)
                        dgvGames.CurrentCell = previousCurrentCell;
                }
                catch { }

                dgvGames.ResumeLayout();
            }

            bindingSource.ResetBindings(false);
        }

        private void Games_ListChanged(object? sender, ListChangedEventArgs e)
        {
            // Re-apply filter/limit on list changes (add/remove/edit)
            if (IsHandleCreated)
                BeginInvoke(new Action(ApplyFilter));
        }

    }
}
