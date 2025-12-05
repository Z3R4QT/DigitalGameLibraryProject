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
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
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
            cmbUsers.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbUsers.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbUsers.FormattingEnabled = true;
            cmbUsers.IntegralHeight = false;
            cmbUsers.ItemHeight = 43;
            cmbUsers.Location = new Point(0, 0);
            cmbUsers.MaxDropDownItems = 4;
            cmbUsers.MouseState = MaterialSkin.MouseState.OUT;
            cmbUsers.Name = "cmbUsers";
            cmbUsers.Size = new Size(374, 49);
            cmbUsers.StartIndex = 0;
            cmbUsers.TabIndex = 0;
            // 
            // lstOwnedGames
            // 
            lstOwnedGames.FormattingEnabled = true;
            lstOwnedGames.ItemHeight = 15;
            lstOwnedGames.Location = new Point(380, 3);
            lstOwnedGames.Name = "lstOwnedGames";
            lstOwnedGames.Size = new Size(120, 94);
            lstOwnedGames.TabIndex = 1;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(18, 83);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(64, 36);
            materialButton1.TabIndex = 2;
            materialButton1.Text = "ADD";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(199, 83);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(158, 36);
            materialButton2.TabIndex = 3;
            materialButton2.Text = "Remove";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // OwnershipControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialButton2);
            Controls.Add(materialButton1);
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
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}
