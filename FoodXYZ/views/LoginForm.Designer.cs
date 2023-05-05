namespace FoodXYZ.views
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameMaskedTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.passwordMaskedTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.loginButton = new MaterialSkin.Controls.MaterialButton();
            this.resetButton = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoodXYZ.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(-1127, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usernameMaskedTextBox
            // 
            this.usernameMaskedTextBox.AllowPromptAsInput = true;
            this.usernameMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameMaskedTextBox.AnimateReadOnly = false;
            this.usernameMaskedTextBox.AsciiOnly = false;
            this.usernameMaskedTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usernameMaskedTextBox.BeepOnError = false;
            this.usernameMaskedTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.usernameMaskedTextBox.Depth = 0;
            this.usernameMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameMaskedTextBox.HidePromptOnLeave = false;
            this.usernameMaskedTextBox.HideSelection = true;
            this.usernameMaskedTextBox.Hint = "Enter Your Username...";
            this.usernameMaskedTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.usernameMaskedTextBox.LeadingIcon = null;
            this.usernameMaskedTextBox.Location = new System.Drawing.Point(385, 428);
            this.usernameMaskedTextBox.Mask = "";
            this.usernameMaskedTextBox.MaxLength = 32767;
            this.usernameMaskedTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameMaskedTextBox.Name = "usernameMaskedTextBox";
            this.usernameMaskedTextBox.PasswordChar = '\0';
            this.usernameMaskedTextBox.PrefixSuffixText = null;
            this.usernameMaskedTextBox.PromptChar = '_';
            this.usernameMaskedTextBox.ReadOnly = false;
            this.usernameMaskedTextBox.RejectInputOnFirstFailure = false;
            this.usernameMaskedTextBox.ResetOnPrompt = true;
            this.usernameMaskedTextBox.ResetOnSpace = true;
            this.usernameMaskedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameMaskedTextBox.SelectedText = "";
            this.usernameMaskedTextBox.SelectionLength = 0;
            this.usernameMaskedTextBox.SelectionStart = 0;
            this.usernameMaskedTextBox.ShortcutsEnabled = true;
            this.usernameMaskedTextBox.Size = new System.Drawing.Size(426, 48);
            this.usernameMaskedTextBox.SkipLiterals = true;
            this.usernameMaskedTextBox.TabIndex = 1;
            this.usernameMaskedTextBox.TabStop = false;
            this.usernameMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.usernameMaskedTextBox.TrailingIcon = null;
            this.usernameMaskedTextBox.UseSystemPasswordChar = false;
            this.usernameMaskedTextBox.ValidatingType = null;
            // 
            // passwordMaskedTextBox
            // 
            this.passwordMaskedTextBox.AllowPromptAsInput = true;
            this.passwordMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordMaskedTextBox.AnimateReadOnly = false;
            this.passwordMaskedTextBox.AsciiOnly = false;
            this.passwordMaskedTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordMaskedTextBox.BeepOnError = false;
            this.passwordMaskedTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.passwordMaskedTextBox.Depth = 0;
            this.passwordMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordMaskedTextBox.HidePromptOnLeave = false;
            this.passwordMaskedTextBox.HideSelection = true;
            this.passwordMaskedTextBox.Hint = "Enter Your Password...";
            this.passwordMaskedTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.passwordMaskedTextBox.LeadingIcon = null;
            this.passwordMaskedTextBox.Location = new System.Drawing.Point(385, 515);
            this.passwordMaskedTextBox.Mask = "";
            this.passwordMaskedTextBox.MaxLength = 32767;
            this.passwordMaskedTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordMaskedTextBox.Name = "passwordMaskedTextBox";
            this.passwordMaskedTextBox.PasswordChar = '*';
            this.passwordMaskedTextBox.PrefixSuffixText = null;
            this.passwordMaskedTextBox.PromptChar = '_';
            this.passwordMaskedTextBox.ReadOnly = false;
            this.passwordMaskedTextBox.RejectInputOnFirstFailure = false;
            this.passwordMaskedTextBox.ResetOnPrompt = true;
            this.passwordMaskedTextBox.ResetOnSpace = true;
            this.passwordMaskedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordMaskedTextBox.SelectedText = "";
            this.passwordMaskedTextBox.SelectionLength = 0;
            this.passwordMaskedTextBox.SelectionStart = 0;
            this.passwordMaskedTextBox.ShortcutsEnabled = true;
            this.passwordMaskedTextBox.Size = new System.Drawing.Size(426, 48);
            this.passwordMaskedTextBox.SkipLiterals = true;
            this.passwordMaskedTextBox.TabIndex = 2;
            this.passwordMaskedTextBox.TabStop = false;
            this.passwordMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.passwordMaskedTextBox.TrailingIcon = null;
            this.passwordMaskedTextBox.UseSystemPasswordChar = false;
            this.passwordMaskedTextBox.ValidatingType = null;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loginButton.Depth = 0;
            this.loginButton.HighEmphasis = true;
            this.loginButton.Icon = null;
            this.loginButton.Location = new System.Drawing.Point(385, 623);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loginButton.Size = new System.Drawing.Size(64, 36);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loginButton.UseAccentColor = false;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.resetButton.Depth = 0;
            this.resetButton.HighEmphasis = true;
            this.resetButton.Icon = null;
            this.resetButton.Location = new System.Drawing.Point(709, 623);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resetButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.resetButton.Name = "resetButton";
            this.resetButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.resetButton.Size = new System.Drawing.Size(65, 36);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.resetButton.UseAccentColor = false;
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::FoodXYZ.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(493, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Food XYZ";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordMaskedTextBox);
            this.Controls.Add(this.usernameMaskedTextBox);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(1250, 750);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodXYZ - Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox usernameMaskedTextBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox passwordMaskedTextBox;
        private MaterialSkin.Controls.MaterialButton loginButton;
        private MaterialSkin.Controls.MaterialButton resetButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}