namespace DigitalGameLibrary.Forms
{
    partial class LoginForm
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
            txtUsername = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            btnSignUp = new MaterialSkin.Controls.MaterialButton();
            btnSignIn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.AllowPromptAsInput = true;
            txtUsername.AnimateReadOnly = false;
            txtUsername.AsciiOnly = false;
            txtUsername.BackgroundImageLayout = ImageLayout.None;
            txtUsername.BeepOnError = false;
            txtUsername.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtUsername.Depth = 0;
            txtUsername.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsername.HidePromptOnLeave = false;
            txtUsername.HideSelection = true;
            txtUsername.InsertKeyMode = InsertKeyMode.Default;
            txtUsername.LeadingIcon = null;
            txtUsername.Location = new Point(12, 12);
            txtUsername.Mask = "";
            txtUsername.MaxLength = 32767;
            txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PrefixSuffixText = null;
            txtUsername.PromptChar = '_';
            txtUsername.ReadOnly = false;
            txtUsername.RejectInputOnFirstFailure = false;
            txtUsername.ResetOnPrompt = true;
            txtUsername.ResetOnSpace = true;
            txtUsername.RightToLeft = RightToLeft.No;
            txtUsername.SelectedText = "";
            txtUsername.SelectionLength = 0;
            txtUsername.SelectionStart = 0;
            txtUsername.ShortcutsEnabled = true;
            txtUsername.Size = new Size(250, 48);
            txtUsername.SkipLiterals = true;
            txtUsername.TabIndex = 0;
            txtUsername.TabStop = false;
            txtUsername.TextAlign = HorizontalAlignment.Left;
            txtUsername.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtUsername.TrailingIcon = null;
            txtUsername.UseSystemPasswordChar = false;
            txtUsername.ValidatingType = null;
            // 
            // txtPassword
            // 
            txtPassword.AllowPromptAsInput = true;
            txtPassword.AnimateReadOnly = false;
            txtPassword.AsciiOnly = false;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.BeepOnError = false;
            txtPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.HidePromptOnLeave = false;
            txtPassword.HideSelection = true;
            txtPassword.InsertKeyMode = InsertKeyMode.Default;
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(12, 66);
            txtPassword.Mask = "";
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.PrefixSuffixText = null;
            txtPassword.PromptChar = '_';
            txtPassword.ReadOnly = false;
            txtPassword.RejectInputOnFirstFailure = false;
            txtPassword.ResetOnPrompt = true;
            txtPassword.ResetOnSpace = true;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(250, 48);
            txtPassword.SkipLiterals = true;
            txtPassword.TabIndex = 1;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.ValidatingType = null;
            // 
            // btnSignUp
            // 
            btnSignUp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSignUp.BackColor = Color.LightSkyBlue;
            btnSignUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSignUp.Depth = 0;
            btnSignUp.HighEmphasis = true;
            btnSignUp.Icon = null;
            btnSignUp.Location = new Point(12, 123);
            btnSignUp.Margin = new Padding(4, 6, 4, 6);
            btnSignUp.MouseState = MaterialSkin.MouseState.HOVER;
            btnSignUp.Name = "btnSignUp";
            btnSignUp.NoAccentTextColor = Color.Empty;
            btnSignUp.Size = new Size(77, 36);
            btnSignUp.TabIndex = 4;
            btnSignUp.Text = "Sign Up";
            btnSignUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSignUp.UseAccentColor = false;
            btnSignUp.UseVisualStyleBackColor = false;
            // 
            // btnSignIn
            // 
            btnSignIn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSignIn.BackColor = Color.LightSkyBlue;
            btnSignIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSignIn.Depth = 0;
            btnSignIn.HighEmphasis = true;
            btnSignIn.Icon = null;
            btnSignIn.Location = new Point(185, 123);
            btnSignIn.Margin = new Padding(4, 6, 4, 6);
            btnSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            btnSignIn.Name = "btnSignIn";
            btnSignIn.NoAccentTextColor = Color.Empty;
            btnSignIn.Size = new Size(77, 36);
            btnSignIn.TabIndex = 5;
            btnSignIn.Text = "Sign In";
            btnSignIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSignIn.UseAccentColor = false;
            btnSignIn.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(279, 190);
            Controls.Add(btnSignIn);
            Controls.Add(btnSignUp);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox txtUsername;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPassword;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialButton btnSignUp;
        private MaterialSkin.Controls.MaterialButton btnSignIn;
    }
}