namespace DigitalGameLibrary.Forms
{
    partial class DashboardControl
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
            lblTotalGames = new MaterialSkin.Controls.MaterialLabel();
            lblTotalUsers = new MaterialSkin.Controls.MaterialLabel();
            lblPopularGenre = new MaterialSkin.Controls.MaterialLabel();
            btnRefresh = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // lblTotalGames
            // 
            lblTotalGames.Depth = 0;
            lblTotalGames.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTotalGames.Location = new Point(19, 10);
            lblTotalGames.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotalGames.Name = "lblTotalGames";
            lblTotalGames.Size = new Size(158, 98);
            lblTotalGames.TabIndex = 0;
            lblTotalGames.Text = "TOTAL GAMES:";
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.Depth = 0;
            lblTotalUsers.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTotalUsers.Location = new Point(217, 10);
            lblTotalUsers.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(158, 98);
            lblTotalUsers.TabIndex = 1;
            lblTotalUsers.Text = "TOTAL USERS:";
            // 
            // lblPopularGenre
            // 
            lblPopularGenre.Depth = 0;
            lblPopularGenre.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPopularGenre.Location = new Point(420, 10);
            lblPopularGenre.MouseState = MaterialSkin.MouseState.HOVER;
            lblPopularGenre.Name = "lblPopularGenre";
            lblPopularGenre.Size = new Size(158, 98);
            lblPopularGenre.TabIndex = 2;
            lblPopularGenre.Text = "Popular Genre:";
            // 
            // btnRefresh
            // 
            btnRefresh.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRefresh.Depth = 0;
            btnRefresh.HighEmphasis = true;
            btnRefresh.Icon = null;
            btnRefresh.Location = new Point(19, 221);
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
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(btnRefresh);
            Controls.Add(lblPopularGenre);
            Controls.Add(lblTotalUsers);
            Controls.Add(lblTotalGames);
            Name = "DashboardControl";
            Size = new Size(702, 346);
            Load += DashboardControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTotalGames;
        private MaterialSkin.Controls.MaterialLabel lblTotalUsers;
        private MaterialSkin.Controls.MaterialLabel lblPopularGenre;
        private MaterialSkin.Controls.MaterialButton btnRefresh;
    }
}
