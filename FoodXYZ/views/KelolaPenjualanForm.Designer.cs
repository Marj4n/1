namespace FoodXYZ.views
{
    partial class KelolaPenjualanForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerAwal = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAkhir = new System.Windows.Forms.DateTimePicker();
            this.materialButtonFilter = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialButtonGenerate = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(351, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tanggal Akhir";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(81, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tanggal Awal";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(312, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 40);
            this.label2.TabIndex = 32;
            this.label2.Text = "Laporan Penjualan";
            // 
            // dateTimePickerAwal
            // 
            this.dateTimePickerAwal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerAwal.Location = new System.Drawing.Point(86, 113);
            this.dateTimePickerAwal.Name = "dateTimePickerAwal";
            this.dateTimePickerAwal.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerAwal.TabIndex = 37;
            // 
            // dateTimePickerAkhir
            // 
            this.dateTimePickerAkhir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerAkhir.Location = new System.Drawing.Point(356, 113);
            this.dateTimePickerAkhir.Name = "dateTimePickerAkhir";
            this.dateTimePickerAkhir.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerAkhir.TabIndex = 38;
            // 
            // materialButtonFilter
            // 
            this.materialButtonFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButtonFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonFilter.Depth = 0;
            this.materialButtonFilter.HighEmphasis = true;
            this.materialButtonFilter.Icon = null;
            this.materialButtonFilter.Location = new System.Drawing.Point(624, 103);
            this.materialButtonFilter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonFilter.Name = "materialButtonFilter";
            this.materialButtonFilter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonFilter.Size = new System.Drawing.Size(68, 36);
            this.materialButtonFilter.TabIndex = 39;
            this.materialButtonFilter.Text = "Filter";
            this.materialButtonFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonFilter.UseAccentColor = false;
            this.materialButtonFilter.UseVisualStyleBackColor = true;
            this.materialButtonFilter.Click += new System.EventHandler(this.materialButtonFilter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(763, 148);
            this.dataGridView1.TabIndex = 40;
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(86, 363);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(763, 216);
            this.chart1.TabIndex = 41;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // materialButtonGenerate
            // 
            this.materialButtonGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButtonGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonGenerate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonGenerate.Depth = 0;
            this.materialButtonGenerate.HighEmphasis = true;
            this.materialButtonGenerate.Icon = null;
            this.materialButtonGenerate.Location = new System.Drawing.Point(694, 419);
            this.materialButtonGenerate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonGenerate.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonGenerate.Name = "materialButtonGenerate";
            this.materialButtonGenerate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonGenerate.Size = new System.Drawing.Size(95, 36);
            this.materialButtonGenerate.TabIndex = 42;
            this.materialButtonGenerate.Text = "Generate";
            this.materialButtonGenerate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonGenerate.UseAccentColor = false;
            this.materialButtonGenerate.UseVisualStyleBackColor = true;
            this.materialButtonGenerate.Click += new System.EventHandler(this.materialButtonGenerate_Click);
            // 
            // KelolaPenjualanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 591);
            this.Controls.Add(this.materialButtonGenerate);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialButtonFilter);
            this.Controls.Add(this.dateTimePickerAkhir);
            this.Controls.Add(this.dateTimePickerAwal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "KelolaPenjualanForm";
            this.Text = "KelolaPenjualanForm";
            this.Load += new System.EventHandler(this.KelolaPenjualanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerAwal;
        private System.Windows.Forms.DateTimePicker dateTimePickerAkhir;
        private MaterialSkin.Controls.MaterialButton materialButtonFilter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MaterialSkin.Controls.MaterialButton materialButtonGenerate;
    }
}