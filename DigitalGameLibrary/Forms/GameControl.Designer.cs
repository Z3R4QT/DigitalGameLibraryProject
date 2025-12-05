namespace DigitalGameLibrary.Forms
{
    partial class GameControl
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
            kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            kryptonContextMenu2 = new Krypton.Toolkit.KryptonContextMenu();
            kryptonContextMenu3 = new Krypton.Toolkit.KryptonContextMenu();
            cmbGenre = new MaterialSkin.Controls.MaterialComboBox();
            cmbPlatform = new MaterialSkin.Controls.MaterialComboBox();
            numYear = new Krypton.Toolkit.KryptonNumericUpDown();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            cmbTitle = new ComboBox();
            SuspendLayout();
            // 
            // cmbGenre
            // 
            cmbGenre.AutoResize = false;
            cmbGenre.BackColor = Color.FromArgb(255, 255, 255);
            cmbGenre.Depth = 0;
            cmbGenre.DrawMode = DrawMode.OwnerDrawVariable;
            cmbGenre.DropDownHeight = 174;
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenre.DropDownWidth = 121;
            cmbGenre.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbGenre.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbGenre.FormattingEnabled = true;
            cmbGenre.IntegralHeight = false;
            cmbGenre.ItemHeight = 43;
            cmbGenre.Location = new Point(323, 98);
            cmbGenre.MaxDropDownItems = 4;
            cmbGenre.MouseState = MaterialSkin.MouseState.OUT;
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(191, 49);
            cmbGenre.StartIndex = 0;
            cmbGenre.TabIndex = 1;
            // 
            // cmbPlatform
            // 
            cmbPlatform.AutoResize = false;
            cmbPlatform.BackColor = Color.FromArgb(255, 255, 255);
            cmbPlatform.Depth = 0;
            cmbPlatform.DrawMode = DrawMode.OwnerDrawVariable;
            cmbPlatform.DropDownHeight = 174;
            cmbPlatform.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlatform.DropDownWidth = 121;
            cmbPlatform.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbPlatform.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbPlatform.FormattingEnabled = true;
            cmbPlatform.IntegralHeight = false;
            cmbPlatform.ItemHeight = 43;
            cmbPlatform.Location = new Point(520, 98);
            cmbPlatform.MaxDropDownItems = 4;
            cmbPlatform.MouseState = MaterialSkin.MouseState.OUT;
            cmbPlatform.Name = "cmbPlatform";
            cmbPlatform.Size = new Size(200, 49);
            cmbPlatform.StartIndex = 0;
            cmbPlatform.TabIndex = 2;
            // 
            // numYear
            // 
            numYear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numYear.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            numYear.Location = new Point(323, 166);
            numYear.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(144, 22);
            numYear.TabIndex = 3;
            numYear.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(323, 213);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(64, 36);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ADD";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbTitle
            // 
            cmbTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTitle.FormattingEnabled = true;
            cmbTitle.Location = new Point(33, 98);
            cmbTitle.Name = "cmbTitle";
            cmbTitle.Size = new Size(259, 38);
            cmbTitle.Sorted = true;
            cmbTitle.TabIndex = 5;
            // 
            // GameControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(cmbTitle);
            Controls.Add(btnAdd);
            Controls.Add(numYear);
            Controls.Add(cmbPlatform);
            Controls.Add(cmbGenre);
            Name = "GameControl";
            Size = new Size(758, 464);
            Load += GameControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu2;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu3;
        private MaterialSkin.Controls.MaterialComboBox cmbGenre;
        private MaterialSkin.Controls.MaterialComboBox cmbPlatform;
        private Krypton.Toolkit.KryptonNumericUpDown numYear;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private ComboBox cmbTitle;
    }
}
