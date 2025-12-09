namespace DigitalGameLibrary.Forms
{
    partial class OwnershipControl
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
            cmbUsers = new MaterialSkin.Controls.MaterialComboBox();
            lstOwnedGames = new ListBox();
            btnAddUser = new MaterialSkin.Controls.MaterialButton();
            btnRemove = new MaterialSkin.Controls.MaterialButton();
            txtNewUser = new MaterialSkin.Controls.MaterialTextBox2();
            lstGames = new ListBox();
            btnAddOwnership = new MaterialSkin.Controls.MaterialButton();
            btnRemoveOwnership = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // cmbUsers
            // 
            cmbUsers.AutoResize = false;
            cmbUsers.BackColor = Color.FromArgb(255, 255, 255);
            cmbUsers.Depth = 0;
            cmbUsers.DrawMode = DrawMode.OwnerDrawVariable;
            cmbUsers.DropDownHeight = 174;
            cmbUsers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsers.DropDownWidth = 121;
            cmbUsers.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbUsers.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbUsers.FormattingEnabled = true;
            cmbUsers.IntegralHeight = false;
            cmbUsers.ItemHeight = 43;
            cmbUsers.Location = new Point(19, 3);
            cmbUsers.MaxDropDownItems = 4;
            cmbUsers.MouseState = MaterialSkin.MouseState.OUT;
            cmbUsers.Name = "cmbUsers";
            cmbUsers.Size = new Size(331, 49);
            cmbUsers.StartIndex = 0;
            cmbUsers.TabIndex = 0;
            // 
            // lstOwnedGames
            // 
            lstOwnedGames.FormattingEnabled = true;
            lstOwnedGames.ItemHeight = 15;
            lstOwnedGames.Location = new Point(559, 3);
            lstOwnedGames.Name = "lstOwnedGames";
            lstOwnedGames.Size = new Size(178, 379);
            lstOwnedGames.TabIndex = 1;
            // 
            // btnAddUser
            // 
            btnAddUser.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddUser.Depth = 0;
            btnAddUser.HighEmphasis = true;
            btnAddUser.Icon = null;
            btnAddUser.Location = new Point(19, 204);
            btnAddUser.Margin = new Padding(4, 6, 4, 6);
            btnAddUser.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddUser.Name = "btnAddUser";
            btnAddUser.NoAccentTextColor = Color.Empty;
            btnAddUser.Size = new Size(90, 36);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "add user";
            btnAddUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddUser.UseAccentColor = false;
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.AutoSize = false;
            btnRemove.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRemove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRemove.Depth = 0;
            btnRemove.HighEmphasis = true;
            btnRemove.Icon = null;
            btnRemove.Location = new Point(19, 252);
            btnRemove.Margin = new Padding(4, 6, 4, 6);
            btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            btnRemove.Name = "btnRemove";
            btnRemove.NoAccentTextColor = Color.Empty;
            btnRemove.Size = new Size(106, 36);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove User";
            btnRemove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRemove.UseAccentColor = false;
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // txtNewUser
            // 
            txtNewUser.AnimateReadOnly = false;
            txtNewUser.BackgroundImageLayout = ImageLayout.None;
            txtNewUser.CharacterCasing = CharacterCasing.Normal;
            txtNewUser.Depth = 0;
            txtNewUser.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNewUser.HideSelection = true;
            txtNewUser.LeadingIcon = null;
            txtNewUser.Location = new Point(31, 124);
            txtNewUser.MaxLength = 32767;
            txtNewUser.MouseState = MaterialSkin.MouseState.OUT;
            txtNewUser.Name = "txtNewUser";
            txtNewUser.PasswordChar = '\0';
            txtNewUser.PrefixSuffixText = null;
            txtNewUser.ReadOnly = false;
            txtNewUser.RightToLeft = RightToLeft.No;
            txtNewUser.SelectedText = "";
            txtNewUser.SelectionLength = 0;
            txtNewUser.SelectionStart = 0;
            txtNewUser.ShortcutsEnabled = true;
            txtNewUser.Size = new Size(250, 48);
            txtNewUser.TabIndex = 4;
            txtNewUser.TabStop = false;
            txtNewUser.Text = "new user";
            txtNewUser.TextAlign = HorizontalAlignment.Left;
            txtNewUser.TrailingIcon = null;
            txtNewUser.UseSystemPasswordChar = false;
            // 
            // lstGames
            // 
            lstGames.FormattingEnabled = true;
            lstGames.ItemHeight = 15;
            lstGames.Location = new Point(373, 3);
            lstGames.Name = "lstGames";
            lstGames.Size = new Size(180, 379);
            lstGames.TabIndex = 5;
            // 
            // btnAddOwnership
            // 
            btnAddOwnership.AutoSize = false;
            btnAddOwnership.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddOwnership.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddOwnership.Depth = 0;
            btnAddOwnership.HighEmphasis = true;
            btnAddOwnership.Icon = null;
            btnAddOwnership.Location = new Point(159, 204);
            btnAddOwnership.Margin = new Padding(4, 6, 4, 6);
            btnAddOwnership.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddOwnership.Name = "btnAddOwnership";
            btnAddOwnership.NoAccentTextColor = Color.Empty;
            btnAddOwnership.Size = new Size(122, 36);
            btnAddOwnership.TabIndex = 6;
            btnAddOwnership.Text = "ADD ownership";
            btnAddOwnership.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddOwnership.UseAccentColor = false;
            btnAddOwnership.UseVisualStyleBackColor = true;
            // 
            // btnRemoveOwnership
            // 
            btnRemoveOwnership.AutoSize = false;
            btnRemoveOwnership.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRemoveOwnership.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRemoveOwnership.Depth = 0;
            btnRemoveOwnership.HighEmphasis = true;
            btnRemoveOwnership.Icon = null;
            btnRemoveOwnership.Location = new Point(159, 252);
            btnRemoveOwnership.Margin = new Padding(4, 6, 4, 6);
            btnRemoveOwnership.MouseState = MaterialSkin.MouseState.HOVER;
            btnRemoveOwnership.Name = "btnRemoveOwnership";
            btnRemoveOwnership.NoAccentTextColor = Color.Empty;
            btnRemoveOwnership.Size = new Size(160, 36);
            btnRemoveOwnership.TabIndex = 7;
            btnRemoveOwnership.Text = "Remove ownership";
            btnRemoveOwnership.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRemoveOwnership.UseAccentColor = false;
            btnRemoveOwnership.UseVisualStyleBackColor = true;
            // 
            // OwnershipControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRemoveOwnership);
            Controls.Add(btnAddOwnership);
            Controls.Add(lstGames);
            Controls.Add(txtNewUser);
            Controls.Add(btnRemove);
            Controls.Add(btnAddUser);
            Controls.Add(lstOwnedGames);
            Controls.Add(cmbUsers);
            Name = "OwnershipControl";
            Size = new Size(835, 386);
            Load += OwnershipControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cmbUsers;
        private ListBox lstOwnedGames;
        private MaterialSkin.Controls.MaterialButton btnAddUser;
        private MaterialSkin.Controls.MaterialButton btnRemove;
        private MaterialSkin.Controls.MaterialTextBox2 txtNewUser;
        private ListBox lstGames;
        private MaterialSkin.Controls.MaterialButton btnAddOwnership;
        private MaterialSkin.Controls.MaterialButton btnRemoveOwnership;
    }
}
