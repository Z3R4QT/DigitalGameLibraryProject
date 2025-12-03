namespace DigitalGameLibrary.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnExit = new MaterialSkin.Controls.MaterialButton();
            btnDashboard = new MaterialSkin.Controls.MaterialButton();
            btnOwnerShip = new MaterialSkin.Controls.MaterialButton();
            bntUsers = new MaterialSkin.Controls.MaterialButton();
            btnAddGames = new MaterialSkin.Controls.MaterialButton();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnOwnerShip);
            panel1.Controls.Add(bntUsers);
            panel1.Controls.Add(btnAddGames);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 450);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.AutoSize = false;
            btnExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExit.Depth = 0;
            btnExit.Dock = DockStyle.Bottom;
            btnExit.HighEmphasis = true;
            btnExit.Icon = null;
            btnExit.Location = new Point(0, 414);
            btnExit.Margin = new Padding(4, 6, 4, 6);
            btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            btnExit.Name = "btnExit";
            btnExit.NoAccentTextColor = Color.Empty;
            btnExit.Size = new Size(187, 36);
            btnExit.TabIndex = 4;
            btnExit.Text = "EXIT";
            btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExit.UseAccentColor = false;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDashboard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDashboard.Depth = 0;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.HighEmphasis = true;
            btnDashboard.Icon = null;
            btnDashboard.Location = new Point(0, 108);
            btnDashboard.Margin = new Padding(4, 6, 4, 6);
            btnDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            btnDashboard.Name = "btnDashboard";
            btnDashboard.NoAccentTextColor = Color.Empty;
            btnDashboard.Size = new Size(187, 36);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "Dashboard";
            btnDashboard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDashboard.UseAccentColor = false;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnOwnerShip
            // 
            btnOwnerShip.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOwnerShip.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnOwnerShip.Depth = 0;
            btnOwnerShip.Dock = DockStyle.Top;
            btnOwnerShip.HighEmphasis = true;
            btnOwnerShip.Icon = null;
            btnOwnerShip.Location = new Point(0, 72);
            btnOwnerShip.Margin = new Padding(4, 6, 4, 6);
            btnOwnerShip.MouseState = MaterialSkin.MouseState.HOVER;
            btnOwnerShip.Name = "btnOwnerShip";
            btnOwnerShip.NoAccentTextColor = Color.Empty;
            btnOwnerShip.Size = new Size(187, 36);
            btnOwnerShip.TabIndex = 2;
            btnOwnerShip.Text = "Ownership";
            btnOwnerShip.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnOwnerShip.UseAccentColor = false;
            btnOwnerShip.UseVisualStyleBackColor = true;
            btnOwnerShip.Click += btnOwnerShip_Click;
            // 
            // bntUsers
            // 
            bntUsers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bntUsers.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            bntUsers.Depth = 0;
            bntUsers.Dock = DockStyle.Top;
            bntUsers.HighEmphasis = true;
            bntUsers.Icon = null;
            bntUsers.Location = new Point(0, 36);
            bntUsers.Margin = new Padding(4, 6, 4, 6);
            bntUsers.MouseState = MaterialSkin.MouseState.HOVER;
            bntUsers.Name = "bntUsers";
            bntUsers.NoAccentTextColor = Color.Empty;
            bntUsers.Size = new Size(187, 36);
            bntUsers.TabIndex = 1;
            bntUsers.Text = "Users";
            bntUsers.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            bntUsers.UseAccentColor = false;
            bntUsers.UseVisualStyleBackColor = true;
            bntUsers.Click += bntUsers_Click;
            // 
            // btnAddGames
            // 
            btnAddGames.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddGames.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddGames.Depth = 0;
            btnAddGames.Dock = DockStyle.Top;
            btnAddGames.HighEmphasis = true;
            btnAddGames.Icon = null;
            btnAddGames.Location = new Point(0, 0);
            btnAddGames.Margin = new Padding(4, 6, 4, 6);
            btnAddGames.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddGames.Name = "btnAddGames";
            btnAddGames.NoAccentTextColor = Color.Empty;
            btnAddGames.Size = new Size(187, 36);
            btnAddGames.TabIndex = 0;
            btnAddGames.Text = "ADD GAMES";
            btnAddGames.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddGames.UseAccentColor = false;
            btnAddGames.UseVisualStyleBackColor = true;
            btnAddGames.Click += btnAddGames_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(187, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(613, 51);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BackColor = Color.RoyalBlue;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(187, 450);
            panel3.Name = "panel3";
            panel3.Size = new Size(613, 0);
            panel3.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnDashboard;
        private MaterialSkin.Controls.MaterialButton btnOwnerShip;
        private MaterialSkin.Controls.MaterialButton bntUsers;
        private MaterialSkin.Controls.MaterialButton btnAddGames;
        private Panel panel2;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialButton btnExit;
    }
}