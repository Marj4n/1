namespace FoodXYZ.views
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialButtonLogout = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonKelolaLaporan = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialButtonKelolaUser = new MaterialSkin.Controls.MaterialButton();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialButtonFilter = new MaterialSkin.Controls.MaterialButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.materialButtonLogout);
            this.panel1.Controls.Add(this.materialButtonKelolaLaporan);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.materialButtonKelolaUser);
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 647);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // materialButtonLogout
            // 
            this.materialButtonLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonLogout.Depth = 0;
            this.materialButtonLogout.HighEmphasis = true;
            this.materialButtonLogout.Icon = null;
            this.materialButtonLogout.Location = new System.Drawing.Point(47, 456);
            this.materialButtonLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonLogout.Name = "materialButtonLogout";
            this.materialButtonLogout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonLogout.Size = new System.Drawing.Size(78, 36);
            this.materialButtonLogout.TabIndex = 4;
            this.materialButtonLogout.Text = "Logout";
            this.materialButtonLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonLogout.UseAccentColor = false;
            this.materialButtonLogout.UseVisualStyleBackColor = true;
            this.materialButtonLogout.Click += new System.EventHandler(this.materialButtonLogout_Click);
            // 
            // materialButtonKelolaLaporan
            // 
            this.materialButtonKelolaLaporan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonKelolaLaporan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonKelolaLaporan.Depth = 0;
            this.materialButtonKelolaLaporan.HighEmphasis = true;
            this.materialButtonKelolaLaporan.Icon = null;
            this.materialButtonKelolaLaporan.Location = new System.Drawing.Point(47, 357);
            this.materialButtonKelolaLaporan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonKelolaLaporan.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonKelolaLaporan.Name = "materialButtonKelolaLaporan";
            this.materialButtonKelolaLaporan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonKelolaLaporan.Size = new System.Drawing.Size(145, 36);
            this.materialButtonKelolaLaporan.TabIndex = 3;
            this.materialButtonKelolaLaporan.Text = "Kelola Laporan";
            this.materialButtonKelolaLaporan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonKelolaLaporan.UseAccentColor = false;
            this.materialButtonKelolaLaporan.UseVisualStyleBackColor = true;
            this.materialButtonKelolaLaporan.Click += new System.EventHandler(this.materialButtonKelolaLaporan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // materialButtonKelolaUser
            // 
            this.materialButtonKelolaUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonKelolaUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonKelolaUser.Depth = 0;
            this.materialButtonKelolaUser.HighEmphasis = true;
            this.materialButtonKelolaUser.Icon = null;
            this.materialButtonKelolaUser.Location = new System.Drawing.Point(47, 259);
            this.materialButtonKelolaUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonKelolaUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonKelolaUser.Name = "materialButtonKelolaUser";
            this.materialButtonKelolaUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonKelolaUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialButtonKelolaUser.Size = new System.Drawing.Size(115, 36);
            this.materialButtonKelolaUser.TabIndex = 1;
            this.materialButtonKelolaUser.Text = "Kelola User";
            this.materialButtonKelolaUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonKelolaUser.UseAccentColor = false;
            this.materialButtonKelolaUser.UseVisualStyleBackColor = true;
            this.materialButtonKelolaUser.Click += new System.EventHandler(this.materialButtonKelolaUser_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.Controls.Add(this.label2);
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.materialButtonFilter);
            this.panelChildForm.Controls.Add(this.dateTimePicker);
            this.panelChildForm.Controls.Add(this.dataGridView1);
            this.panelChildForm.Location = new System.Drawing.Point(277, 97);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(975, 647);
            this.panelChildForm.TabIndex = 5;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(400, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "Log Activity";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(123, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pilih Tanggall";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // materialButtonFilter
            // 
            this.materialButtonFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonFilter.Depth = 0;
            this.materialButtonFilter.HighEmphasis = true;
            this.materialButtonFilter.Icon = null;
            this.materialButtonFilter.Location = new System.Drawing.Point(742, 72);
            this.materialButtonFilter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonFilter.Name = "materialButtonFilter";
            this.materialButtonFilter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonFilter.Size = new System.Drawing.Size(68, 36);
            this.materialButtonFilter.TabIndex = 2;
            this.materialButtonFilter.Text = "Filter";
            this.materialButtonFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonFilter.UseAccentColor = false;
            this.materialButtonFilter.UseVisualStyleBackColor = true;
            this.materialButtonFilter.Click += new System.EventHandler(this.materialButtonFilter_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(128, 82);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(266, 26);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(128, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(712, 472);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 750);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1250, 750);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodXYZ - Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton materialButtonKelolaUser;
        private MaterialSkin.Controls.MaterialButton materialButtonLogout;
        private MaterialSkin.Controls.MaterialButton materialButtonKelolaLaporan;
        private System.Windows.Forms.Panel panelChildForm;
        private MaterialSkin.Controls.MaterialButton materialButtonFilter;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}