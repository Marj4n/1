namespace FoodXYZ.views
{
    partial class BarangForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarangForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.materialButtonLogout = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.materialMaskedTextBoxCariBarang = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialButtonHapus = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonEdit = new MaterialSkin.Controls.MaterialButton();
            this.materialMaskedTextBoxHargaPersatuan = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.materialComboBoxSatuan = new MaterialSkin.Controls.MaterialComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.materialMaskedTextBoxNamaBarang = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.materialMaskedTextBoxJumlahBarang = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.materialMaskedTextBoxKodeBarang = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialButtonTambah = new MaterialSkin.Controls.MaterialButton();
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
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.materialButtonLogout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 647);
            this.panel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Barang";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kelola";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(55, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gudang";
            // 
            // materialButtonLogout
            // 
            this.materialButtonLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButtonLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonLogout.Depth = 0;
            this.materialButtonLogout.HighEmphasis = true;
            this.materialButtonLogout.Icon = null;
            this.materialButtonLogout.Location = new System.Drawing.Point(62, 505);
            this.materialButtonLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonLogout.Name = "materialButtonLogout";
            this.materialButtonLogout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonLogout.Size = new System.Drawing.Size(68, 36);
            this.materialButtonLogout.TabIndex = 4;
            this.materialButtonLogout.Text = "Logout";
            this.materialButtonLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonLogout.UseAccentColor = false;
            this.materialButtonLogout.UseVisualStyleBackColor = true;
            this.materialButtonLogout.Click += new System.EventHandler(this.materialButtonLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.Controls.Add(this.dataGridView1);
            this.panelChildForm.Controls.Add(this.label11);
            this.panelChildForm.Controls.Add(this.materialMaskedTextBoxCariBarang);
            this.panelChildForm.Controls.Add(this.materialButtonHapus);
            this.panelChildForm.Controls.Add(this.materialButtonEdit);
            this.panelChildForm.Controls.Add(this.materialMaskedTextBoxHargaPersatuan);
            this.panelChildForm.Controls.Add(this.label10);
            this.panelChildForm.Controls.Add(this.dateTimePicker1);
            this.panelChildForm.Controls.Add(this.label9);
            this.panelChildForm.Controls.Add(this.materialComboBoxSatuan);
            this.panelChildForm.Controls.Add(this.label8);
            this.panelChildForm.Controls.Add(this.materialMaskedTextBoxNamaBarang);
            this.panelChildForm.Controls.Add(this.label7);
            this.panelChildForm.Controls.Add(this.materialMaskedTextBoxJumlahBarang);
            this.panelChildForm.Controls.Add(this.label6);
            this.panelChildForm.Controls.Add(this.materialMaskedTextBoxKodeBarang);
            this.panelChildForm.Controls.Add(this.label2);
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.materialButtonTambah);
            this.panelChildForm.Location = new System.Drawing.Point(279, 97);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(975, 647);
            this.panelChildForm.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 494);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(900, 150);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(30, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 25);
            this.label11.TabIndex = 32;
            this.label11.Text = "Tabel Stock Barang";
            // 
            // materialMaskedTextBoxCariBarang
            // 
            this.materialMaskedTextBoxCariBarang.AllowPromptAsInput = true;
            this.materialMaskedTextBoxCariBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialMaskedTextBoxCariBarang.AnimateReadOnly = false;
            this.materialMaskedTextBoxCariBarang.AsciiOnly = false;
            this.materialMaskedTextBoxCariBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBoxCariBarang.BeepOnError = false;
            this.materialMaskedTextBoxCariBarang.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBoxCariBarang.Depth = 0;
            this.materialMaskedTextBoxCariBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBoxCariBarang.HidePromptOnLeave = false;
            this.materialMaskedTextBoxCariBarang.HideSelection = true;
            this.materialMaskedTextBoxCariBarang.Hint = "Cari Nama Barang";
            this.materialMaskedTextBoxCariBarang.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBoxCariBarang.LeadingIcon = global::FoodXYZ.Properties.Resources.magnifying_glass;
            this.materialMaskedTextBoxCariBarang.Location = new System.Drawing.Point(511, 408);
            this.materialMaskedTextBoxCariBarang.Mask = "";
            this.materialMaskedTextBoxCariBarang.MaxLength = 32767;
            this.materialMaskedTextBoxCariBarang.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBoxCariBarang.Name = "materialMaskedTextBoxCariBarang";
            this.materialMaskedTextBoxCariBarang.PasswordChar = '\0';
            this.materialMaskedTextBoxCariBarang.PrefixSuffixText = null;
            this.materialMaskedTextBoxCariBarang.PromptChar = '_';
            this.materialMaskedTextBoxCariBarang.ReadOnly = false;
            this.materialMaskedTextBoxCariBarang.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBoxCariBarang.ResetOnPrompt = true;
            this.materialMaskedTextBoxCariBarang.ResetOnSpace = true;
            this.materialMaskedTextBoxCariBarang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBoxCariBarang.SelectedText = "";
            this.materialMaskedTextBoxCariBarang.SelectionLength = 0;
            this.materialMaskedTextBoxCariBarang.SelectionStart = 0;
            this.materialMaskedTextBoxCariBarang.ShortcutsEnabled = true;
            this.materialMaskedTextBoxCariBarang.Size = new System.Drawing.Size(424, 48);
            this.materialMaskedTextBoxCariBarang.SkipLiterals = true;
            this.materialMaskedTextBoxCariBarang.TabIndex = 31;
            this.materialMaskedTextBoxCariBarang.TabStop = false;
            this.materialMaskedTextBoxCariBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBoxCariBarang.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBoxCariBarang.TrailingIcon = null;
            this.materialMaskedTextBoxCariBarang.UseSystemPasswordChar = false;
            this.materialMaskedTextBoxCariBarang.ValidatingType = null;
            this.materialMaskedTextBoxCariBarang.TextChanged += new System.EventHandler(this.materialMaskedTextBoxCariBarang_TextChanged);
            // 
            // materialButtonHapus
            // 
            this.materialButtonHapus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButtonHapus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonHapus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonHapus.Depth = 0;
            this.materialButtonHapus.HighEmphasis = true;
            this.materialButtonHapus.Icon = null;
            this.materialButtonHapus.Location = new System.Drawing.Point(317, 367);
            this.materialButtonHapus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonHapus.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonHapus.Name = "materialButtonHapus";
            this.materialButtonHapus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonHapus.Size = new System.Drawing.Size(69, 36);
            this.materialButtonHapus.TabIndex = 21;
            this.materialButtonHapus.Text = "Hapus";
            this.materialButtonHapus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonHapus.UseAccentColor = false;
            this.materialButtonHapus.UseVisualStyleBackColor = true;
            this.materialButtonHapus.Click += new System.EventHandler(this.materialButtonHapus_Click);
            // 
            // materialButtonEdit
            // 
            this.materialButtonEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButtonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonEdit.Depth = 0;
            this.materialButtonEdit.HighEmphasis = true;
            this.materialButtonEdit.Icon = null;
            this.materialButtonEdit.Location = new System.Drawing.Point(181, 367);
            this.materialButtonEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonEdit.Name = "materialButtonEdit";
            this.materialButtonEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonEdit.Size = new System.Drawing.Size(64, 36);
            this.materialButtonEdit.TabIndex = 20;
            this.materialButtonEdit.Text = "Edit";
            this.materialButtonEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonEdit.UseAccentColor = false;
            this.materialButtonEdit.UseVisualStyleBackColor = true;
            this.materialButtonEdit.Click += new System.EventHandler(this.materialButtonEdit_Click);
            // 
            // materialMaskedTextBoxHargaPersatuan
            // 
            this.materialMaskedTextBoxHargaPersatuan.AllowPromptAsInput = true;
            this.materialMaskedTextBoxHargaPersatuan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialMaskedTextBoxHargaPersatuan.AnimateReadOnly = false;
            this.materialMaskedTextBoxHargaPersatuan.AsciiOnly = false;
            this.materialMaskedTextBoxHargaPersatuan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBoxHargaPersatuan.BeepOnError = false;
            this.materialMaskedTextBoxHargaPersatuan.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBoxHargaPersatuan.Depth = 0;
            this.materialMaskedTextBoxHargaPersatuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBoxHargaPersatuan.HidePromptOnLeave = false;
            this.materialMaskedTextBoxHargaPersatuan.HideSelection = true;
            this.materialMaskedTextBoxHargaPersatuan.Hint = "Masukan Harga Persatuan...";
            this.materialMaskedTextBoxHargaPersatuan.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBoxHargaPersatuan.LeadingIcon = null;
            this.materialMaskedTextBoxHargaPersatuan.Location = new System.Drawing.Point(584, 301);
            this.materialMaskedTextBoxHargaPersatuan.Mask = "";
            this.materialMaskedTextBoxHargaPersatuan.MaxLength = 32767;
            this.materialMaskedTextBoxHargaPersatuan.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBoxHargaPersatuan.Name = "materialMaskedTextBoxHargaPersatuan";
            this.materialMaskedTextBoxHargaPersatuan.PasswordChar = '\0';
            this.materialMaskedTextBoxHargaPersatuan.PrefixSuffixText = null;
            this.materialMaskedTextBoxHargaPersatuan.PromptChar = '_';
            this.materialMaskedTextBoxHargaPersatuan.ReadOnly = false;
            this.materialMaskedTextBoxHargaPersatuan.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBoxHargaPersatuan.ResetOnPrompt = true;
            this.materialMaskedTextBoxHargaPersatuan.ResetOnSpace = true;
            this.materialMaskedTextBoxHargaPersatuan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBoxHargaPersatuan.SelectedText = "";
            this.materialMaskedTextBoxHargaPersatuan.SelectionLength = 0;
            this.materialMaskedTextBoxHargaPersatuan.SelectionStart = 0;
            this.materialMaskedTextBoxHargaPersatuan.ShortcutsEnabled = true;
            this.materialMaskedTextBoxHargaPersatuan.Size = new System.Drawing.Size(351, 48);
            this.materialMaskedTextBoxHargaPersatuan.SkipLiterals = true;
            this.materialMaskedTextBoxHargaPersatuan.TabIndex = 19;
            this.materialMaskedTextBoxHargaPersatuan.TabStop = false;
            this.materialMaskedTextBoxHargaPersatuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBoxHargaPersatuan.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBoxHargaPersatuan.TrailingIcon = null;
            this.materialMaskedTextBoxHargaPersatuan.UseSystemPasswordChar = false;
            this.materialMaskedTextBoxHargaPersatuan.ValidatingType = null;
            this.materialMaskedTextBoxHargaPersatuan.TextChanged += new System.EventHandler(this.materialMaskedTextBoxHargaPersatuan_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(579, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Harga Persatuan";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 312);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(351, 26);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(30, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Expired Date";
            // 
            // materialComboBoxSatuan
            // 
            this.materialComboBoxSatuan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxSatuan.AutoResize = false;
            this.materialComboBoxSatuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxSatuan.Depth = 0;
            this.materialComboBoxSatuan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxSatuan.DropDownHeight = 174;
            this.materialComboBoxSatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxSatuan.DropDownWidth = 121;
            this.materialComboBoxSatuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxSatuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxSatuan.FormattingEnabled = true;
            this.materialComboBoxSatuan.IntegralHeight = false;
            this.materialComboBoxSatuan.ItemHeight = 43;
            this.materialComboBoxSatuan.Location = new System.Drawing.Point(584, 191);
            this.materialComboBoxSatuan.MaxDropDownItems = 4;
            this.materialComboBoxSatuan.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxSatuan.Name = "materialComboBoxSatuan";
            this.materialComboBoxSatuan.Size = new System.Drawing.Size(351, 49);
            this.materialComboBoxSatuan.StartIndex = 0;
            this.materialComboBoxSatuan.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(579, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Satuan";
            // 
            // materialMaskedTextBoxNamaBarang
            // 
            this.materialMaskedTextBoxNamaBarang.AllowPromptAsInput = true;
            this.materialMaskedTextBoxNamaBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialMaskedTextBoxNamaBarang.AnimateReadOnly = false;
            this.materialMaskedTextBoxNamaBarang.AsciiOnly = false;
            this.materialMaskedTextBoxNamaBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBoxNamaBarang.BeepOnError = false;
            this.materialMaskedTextBoxNamaBarang.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBoxNamaBarang.Depth = 0;
            this.materialMaskedTextBoxNamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBoxNamaBarang.HidePromptOnLeave = false;
            this.materialMaskedTextBoxNamaBarang.HideSelection = true;
            this.materialMaskedTextBoxNamaBarang.Hint = "Masukan Nama Barang";
            this.materialMaskedTextBoxNamaBarang.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBoxNamaBarang.LeadingIcon = null;
            this.materialMaskedTextBoxNamaBarang.Location = new System.Drawing.Point(35, 192);
            this.materialMaskedTextBoxNamaBarang.Mask = "";
            this.materialMaskedTextBoxNamaBarang.MaxLength = 32767;
            this.materialMaskedTextBoxNamaBarang.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBoxNamaBarang.Name = "materialMaskedTextBoxNamaBarang";
            this.materialMaskedTextBoxNamaBarang.PasswordChar = '\0';
            this.materialMaskedTextBoxNamaBarang.PrefixSuffixText = null;
            this.materialMaskedTextBoxNamaBarang.PromptChar = '_';
            this.materialMaskedTextBoxNamaBarang.ReadOnly = false;
            this.materialMaskedTextBoxNamaBarang.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBoxNamaBarang.ResetOnPrompt = true;
            this.materialMaskedTextBoxNamaBarang.ResetOnSpace = true;
            this.materialMaskedTextBoxNamaBarang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBoxNamaBarang.SelectedText = "";
            this.materialMaskedTextBoxNamaBarang.SelectionLength = 0;
            this.materialMaskedTextBoxNamaBarang.SelectionStart = 0;
            this.materialMaskedTextBoxNamaBarang.ShortcutsEnabled = true;
            this.materialMaskedTextBoxNamaBarang.Size = new System.Drawing.Size(351, 48);
            this.materialMaskedTextBoxNamaBarang.SkipLiterals = true;
            this.materialMaskedTextBoxNamaBarang.TabIndex = 12;
            this.materialMaskedTextBoxNamaBarang.TabStop = false;
            this.materialMaskedTextBoxNamaBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBoxNamaBarang.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBoxNamaBarang.TrailingIcon = null;
            this.materialMaskedTextBoxNamaBarang.UseSystemPasswordChar = false;
            this.materialMaskedTextBoxNamaBarang.ValidatingType = null;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(30, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nama Barang";
            // 
            // materialMaskedTextBoxJumlahBarang
            // 
            this.materialMaskedTextBoxJumlahBarang.AllowPromptAsInput = true;
            this.materialMaskedTextBoxJumlahBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialMaskedTextBoxJumlahBarang.AnimateReadOnly = false;
            this.materialMaskedTextBoxJumlahBarang.AsciiOnly = false;
            this.materialMaskedTextBoxJumlahBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBoxJumlahBarang.BeepOnError = false;
            this.materialMaskedTextBoxJumlahBarang.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBoxJumlahBarang.Depth = 0;
            this.materialMaskedTextBoxJumlahBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBoxJumlahBarang.HidePromptOnLeave = false;
            this.materialMaskedTextBoxJumlahBarang.HideSelection = true;
            this.materialMaskedTextBoxJumlahBarang.Hint = "Masukan Jumlah Barang";
            this.materialMaskedTextBoxJumlahBarang.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBoxJumlahBarang.LeadingIcon = null;
            this.materialMaskedTextBoxJumlahBarang.Location = new System.Drawing.Point(584, 82);
            this.materialMaskedTextBoxJumlahBarang.Mask = "";
            this.materialMaskedTextBoxJumlahBarang.MaxLength = 32767;
            this.materialMaskedTextBoxJumlahBarang.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBoxJumlahBarang.Name = "materialMaskedTextBoxJumlahBarang";
            this.materialMaskedTextBoxJumlahBarang.PasswordChar = '\0';
            this.materialMaskedTextBoxJumlahBarang.PrefixSuffixText = null;
            this.materialMaskedTextBoxJumlahBarang.PromptChar = '_';
            this.materialMaskedTextBoxJumlahBarang.ReadOnly = false;
            this.materialMaskedTextBoxJumlahBarang.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBoxJumlahBarang.ResetOnPrompt = true;
            this.materialMaskedTextBoxJumlahBarang.ResetOnSpace = true;
            this.materialMaskedTextBoxJumlahBarang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBoxJumlahBarang.SelectedText = "";
            this.materialMaskedTextBoxJumlahBarang.SelectionLength = 0;
            this.materialMaskedTextBoxJumlahBarang.SelectionStart = 0;
            this.materialMaskedTextBoxJumlahBarang.ShortcutsEnabled = true;
            this.materialMaskedTextBoxJumlahBarang.Size = new System.Drawing.Size(351, 48);
            this.materialMaskedTextBoxJumlahBarang.SkipLiterals = true;
            this.materialMaskedTextBoxJumlahBarang.TabIndex = 10;
            this.materialMaskedTextBoxJumlahBarang.TabStop = false;
            this.materialMaskedTextBoxJumlahBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBoxJumlahBarang.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBoxJumlahBarang.TrailingIcon = null;
            this.materialMaskedTextBoxJumlahBarang.UseSystemPasswordChar = false;
            this.materialMaskedTextBoxJumlahBarang.ValidatingType = null;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(579, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Jumlah Barang";
            // 
            // materialMaskedTextBoxKodeBarang
            // 
            this.materialMaskedTextBoxKodeBarang.AllowPromptAsInput = true;
            this.materialMaskedTextBoxKodeBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialMaskedTextBoxKodeBarang.AnimateReadOnly = false;
            this.materialMaskedTextBoxKodeBarang.AsciiOnly = false;
            this.materialMaskedTextBoxKodeBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBoxKodeBarang.BeepOnError = false;
            this.materialMaskedTextBoxKodeBarang.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBoxKodeBarang.Depth = 0;
            this.materialMaskedTextBoxKodeBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBoxKodeBarang.HidePromptOnLeave = false;
            this.materialMaskedTextBoxKodeBarang.HideSelection = true;
            this.materialMaskedTextBoxKodeBarang.Hint = "Masukan Kode Barang";
            this.materialMaskedTextBoxKodeBarang.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBoxKodeBarang.LeadingIcon = null;
            this.materialMaskedTextBoxKodeBarang.Location = new System.Drawing.Point(35, 82);
            this.materialMaskedTextBoxKodeBarang.Mask = "";
            this.materialMaskedTextBoxKodeBarang.MaxLength = 32767;
            this.materialMaskedTextBoxKodeBarang.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBoxKodeBarang.Name = "materialMaskedTextBoxKodeBarang";
            this.materialMaskedTextBoxKodeBarang.PasswordChar = '\0';
            this.materialMaskedTextBoxKodeBarang.PrefixSuffixText = null;
            this.materialMaskedTextBoxKodeBarang.PromptChar = '_';
            this.materialMaskedTextBoxKodeBarang.ReadOnly = false;
            this.materialMaskedTextBoxKodeBarang.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBoxKodeBarang.ResetOnPrompt = true;
            this.materialMaskedTextBoxKodeBarang.ResetOnSpace = true;
            this.materialMaskedTextBoxKodeBarang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBoxKodeBarang.SelectedText = "";
            this.materialMaskedTextBoxKodeBarang.SelectionLength = 0;
            this.materialMaskedTextBoxKodeBarang.SelectionStart = 0;
            this.materialMaskedTextBoxKodeBarang.ShortcutsEnabled = true;
            this.materialMaskedTextBoxKodeBarang.Size = new System.Drawing.Size(351, 48);
            this.materialMaskedTextBoxKodeBarang.SkipLiterals = true;
            this.materialMaskedTextBoxKodeBarang.TabIndex = 8;
            this.materialMaskedTextBoxKodeBarang.TabStop = false;
            this.materialMaskedTextBoxKodeBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBoxKodeBarang.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBoxKodeBarang.TrailingIcon = null;
            this.materialMaskedTextBoxKodeBarang.UseSystemPasswordChar = false;
            this.materialMaskedTextBoxKodeBarang.ValidatingType = null;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(353, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kelola Barang";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kode Barang";
            // 
            // materialButtonTambah
            // 
            this.materialButtonTambah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButtonTambah.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonTambah.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonTambah.Depth = 0;
            this.materialButtonTambah.HighEmphasis = true;
            this.materialButtonTambah.Icon = null;
            this.materialButtonTambah.Location = new System.Drawing.Point(35, 367);
            this.materialButtonTambah.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonTambah.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonTambah.Name = "materialButtonTambah";
            this.materialButtonTambah.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonTambah.Size = new System.Drawing.Size(82, 36);
            this.materialButtonTambah.TabIndex = 2;
            this.materialButtonTambah.Text = "Tambah";
            this.materialButtonTambah.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonTambah.UseAccentColor = false;
            this.materialButtonTambah.UseVisualStyleBackColor = true;
            this.materialButtonTambah.Click += new System.EventHandler(this.materialButtonTambah_Click);
            // 
            // BarangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelChildForm);
            this.MinimumSize = new System.Drawing.Size(1250, 750);
            this.Name = "BarangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodXYZ - Gudang";
            this.Load += new System.EventHandler(this.BarangForm_Load);
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
        private MaterialSkin.Controls.MaterialButton materialButtonLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton materialButtonTambah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBoxHargaPersatuan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxSatuan;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBoxNamaBarang;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBoxJumlahBarang;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBoxKodeBarang;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton materialButtonHapus;
        private MaterialSkin.Controls.MaterialButton materialButtonEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBoxCariBarang;
    }
}