namespace DigitalGameLibrary.Forms
{
    partial class ManageControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvGames = new DataGridView();
            btnEdit = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnRefresh = new MaterialSkin.Controls.MaterialButton();
            txtSearch = new MaterialSkin.Controls.MaterialMaskedTextBox();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            SuspendLayout();
            // 
            // dgvGames
            // 
            dgvGames.AllowUserToAddRows = false;
            dgvGames.AllowUserToDeleteRows = false;
            dgvGames.AllowUserToResizeColumns = false;
            dgvGames.AllowUserToResizeRows = false;
            dgvGames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.Dock = DockStyle.Top;
            dgvGames.Location = new Point(0, 0);
            dgvGames.Name = "dgvGames";
            dgvGames.Size = new Size(695, 194);
            dgvGames.TabIndex = 0;

            // 
            // btnEdit
            // 
            btnEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEdit.Depth = 0;
            btnEdit.HighEmphasis = true;
            btnEdit.Icon = null;
            btnEdit.Location = new Point(13, 289);
            btnEdit.Margin = new Padding(4, 6, 4, 6);
            btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            btnEdit.Name = "btnEdit";
            btnEdit.NoAccentTextColor = Color.Empty;
            btnEdit.Size = new Size(64, 36);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEdit.UseAccentColor = false;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(99, 289);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(73, 36);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "delete";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRefresh.Depth = 0;
            btnRefresh.HighEmphasis = true;
            btnRefresh.Icon = null;
            btnRefresh.Location = new Point(191, 289);
            btnRefresh.Margin = new Padding(4, 6, 4, 6);
            btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.NoAccentTextColor = Color.Empty;
            btnRefresh.Size = new Size(84, 36);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "refresh";
            btnRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRefresh.UseAccentColor = false;
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.AllowPromptAsInput = true;
            txtSearch.AnimateReadOnly = false;
            txtSearch.AsciiOnly = false;
            txtSearch.BackgroundImageLayout = ImageLayout.None;
            txtSearch.BeepOnError = false;
            txtSearch.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtSearch.Depth = 0;
            txtSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearch.HidePromptOnLeave = false;
            txtSearch.HideSelection = true;
            txtSearch.InsertKeyMode = InsertKeyMode.Default;
            txtSearch.LeadingIcon = null;
            txtSearch.Location = new Point(13, 200);
            txtSearch.Mask = "";
            txtSearch.MaxLength = 32767;
            txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PrefixSuffixText = null;
            txtSearch.PromptChar = '_';
            txtSearch.ReadOnly = false;
            txtSearch.RejectInputOnFirstFailure = false;
            txtSearch.ResetOnPrompt = true;
            txtSearch.ResetOnSpace = true;
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.SelectedText = "";
            txtSearch.SelectionLength = 0;
            txtSearch.SelectionStart = 0;
            txtSearch.ShortcutsEnabled = true;
            txtSearch.Size = new Size(250, 48);
            txtSearch.SkipLiterals = true;
            txtSearch.TabIndex = 4;
            txtSearch.TabStop = false;
            txtSearch.TextAlign = HorizontalAlignment.Left;
            txtSearch.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtSearch.TrailingIcon = null;
            txtSearch.UseSystemPasswordChar = false;
            txtSearch.ValidatingType = null;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // ManageControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dgvGames);
            Name = "ManageControl";
            Size = new Size(695, 351);
            Load += ManageControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGames;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnRefresh;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtSearch;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
    }
}
