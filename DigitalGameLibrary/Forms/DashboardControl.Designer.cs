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
            lstRecentGames = new MaterialSkin.Controls.MaterialLabel();
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
            lblTotalGames.Text = "materialLabel1";
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
            lblTotalUsers.Text = "materialLabel2";
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
            lblPopularGenre.Text = "materialLabel3";
            // 
            // lstRecentGames
            // 
            lstRecentGames.Depth = 0;
            lstRecentGames.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lstRecentGames.Location = new Point(19, 121);
            lstRecentGames.MouseState = MaterialSkin.MouseState.HOVER;
            lstRecentGames.Name = "lstRecentGames";
            lstRecentGames.Size = new Size(158, 98);
            lstRecentGames.TabIndex = 3;
            lstRecentGames.Text = "materialLabel4";
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(lstRecentGames);
            Controls.Add(lblPopularGenre);
            Controls.Add(lblTotalUsers);
            Controls.Add(lblTotalGames);
            Name = "DashboardControl";
            Size = new Size(702, 346);
            Load += DashboardControl_Load;
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTotalGames;
        private MaterialSkin.Controls.MaterialLabel lblTotalUsers;
        private MaterialSkin.Controls.MaterialLabel lblPopularGenre;
        private MaterialSkin.Controls.MaterialLabel lstRecentGames;
    }
}
