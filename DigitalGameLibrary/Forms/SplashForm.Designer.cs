namespace DigitalGameLibrary.Forms
{
    partial class SplashForm
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
            components = new System.ComponentModel.Container();
            ProgressBar1 = new Krypton.Toolkit.KryptonProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // ProgressBar1
            // 
            ProgressBar1.Dock = DockStyle.Bottom;
            ProgressBar1.Location = new Point(0, 132);
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(574, 50);
            ProgressBar1.StateCommon.Back.Color1 = Color.Green;
            ProgressBar1.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            ProgressBar1.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            ProgressBar1.TabIndex = 1;
            ProgressBar1.Text = "Loading.....";
            ProgressBar1.TextBackdropColor = Color.Empty;
            ProgressBar1.TextShadowColor = Color.Empty;
            ProgressBar1.Values.Text = "Loading.....";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 182);
            Controls.Add(ProgressBar1);
            Name = "SplashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading";
            Load += SplashForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonProgressBar ProgressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}