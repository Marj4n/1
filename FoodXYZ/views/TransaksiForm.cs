using FoodXYZ.db;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FoodXYZ.views
{
    public partial class TransaksiForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private string username;
        private int counterTransaksi = 1;

        private string GenerateTransaksiId()
        {
            string id = string.Format("TR{0:D3}", counterTransaksi);
            counterTransaksi++;
            return id;
        }
        public TransaksiForm(string username)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }

        private void materialButtonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void TransaksiForm_Load(object sender, EventArgs e)
        {
            kasirUsername.Text = username;
            DataTable dt = DbManager.ExecuteDataQuery("SELECT nama_barang, kode_barang FROM barang");
            List<string> menu = dt.AsEnumerable().Select(row => row.Field<string>("nama_barang")).ToList();
            materialComboBoxPilihMenu.DataSource = menu;

            // keranjang kosong
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].HeaderText = "ID Transaksi";
            dataGridView1.Columns[1].HeaderText = "Kode Barang";
            dataGridView1.Columns[2].HeaderText = "Nama Barang";
            dataGridView1.Columns[3].HeaderText = "Harga Satuan";
            dataGridView1.Columns[4].HeaderText = "Quantitas";
            dataGridView1.Columns[5].HeaderText = "Subtotal";

        }

        private void materialButtonTambah_Click(object sender, EventArgs e)
        {
            // Generate transaction ID
            string transaksiId = GenerateTransaksiId();

            // Get selected barang data
            string barangName = materialComboBoxPilihMenu.Text;
            DataTable barangData = DbManager.ExecuteDataQuery($"SELECT * FROM barang WHERE nama_barang = '{barangName}'");

            if (barangData.Rows.Count > 0)
            {
                // Get barang data
                int barangId = Convert.ToInt32(barangData.Rows[0]["id"]);
                decimal hargaSatuan = Convert.ToDecimal(barangData.Rows[0]["harga_satuan"]);
                int maxQuantitas = Convert.ToInt32(barangData.Rows[0]["jumlah_barang"]);

                // Get transaction data
                decimal jumlahBarang;
                if (!decimal.TryParse(materialMaskedTextBoxQuantitas.Text, out jumlahBarang))
                {
                    MessageBox.Show("Jumlah barang tidak valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal totalBayar = jumlahBarang * hargaSatuan;

                // Add new row to DataGridView
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = transaksiId;
                row.Cells[1].Value = barangData.Rows[0]["kode_barang"];
                row.Cells[2].Value = barangName;
                row.Cells[3].Value = hargaSatuan;
                row.Cells[4].Value = jumlahBarang;
                row.Cells[5].Value = totalBayar;
                dataGridView1.Rows.Add(row);

                // Update barang quantity in database
                int newQuantity = maxQuantitas - Convert.ToInt32(jumlahBarang);
                DbManager.ExecuteQuery($"UPDATE barang SET jumlah_barang = {newQuantity} WHERE id = {barangId}");

                // Clear input fields
                materialComboBoxPilihMenu.SelectedIndex = -1;
                materialMaskedTextBoxQuantitas.Clear();
                materialMaskedTextBoxTotal.Text = "Rp. 0";

                TotalHarga.Text = $"{dataGridView1.Rows.Cast<DataGridViewRow>().Sum(r => Convert.ToDecimal(r.Cells[5].Value))}";

            }
            else
            {
                MessageBox.Show("Barang tidak ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButtonReset_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            TotalHarga.Text = "0";
            Kembaliann.Text = "0";
        }

        private void materialButtonBayar_Click(object sender, EventArgs e)
        {
            decimal totalHarga = Convert.ToDecimal(TotalHarga.Text);
            decimal uangMasuk;

            if (!decimal.TryParse(materialMaskedTextBoxMasukkanUang.Text, out uangMasuk))
            {
                MessageBox.Show("Uang masuk tidak valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (uangMasuk < totalHarga)
            {
                MessageBox.Show("Uang tidak cukup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal kembalian = uangMasuk - totalHarga;
            Kembaliann.Text = $"{kembalian}";
            // Clear transaction data
            dataGridView1.Rows.Clear();
            TotalHarga.Text = "0";
            materialMaskedTextBoxMasukkanUang.Clear();
        }

        private void materialButtonPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada transaksi yang dapat di-print", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create PDF document
            Document document = new Document();
            string fileName = "struk.pdf";
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", fileName);
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();


            // Add table to document
            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
            table.WidthPercentage = 100;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                table.AddCell(new PdfPCell(new Phrase(dataGridView1.Columns[i].HeaderText)));
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        table.AddCell(new PdfPCell(new Phrase(dataGridView1.Rows[i].Cells[j].Value.ToString())));
                    }
                }
            }

            document.Add(table);
            document.Close();

            MessageBox.Show("Struk berhasil di-print dan disimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void materialButtonSimpan_Click(object sender, EventArgs e)
        {
            // Check if there are any transactions to be saved
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada transaksi untuk disimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Reset the DataGridView and input fields
            dataGridView1.Rows.Clear();
            materialComboBoxPilihMenu.SelectedIndex = -1;
            materialMaskedTextBoxQuantitas.Clear();
            materialMaskedTextBoxTotal.Text = "Rp. 0";
            TotalHarga.Text = "Rp. 0";
            Kembaliann.Text = "0";

            MessageBox.Show("Data transaksi berhasil disimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void materialComboBoxPilihMenu_TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT jumlah_barang, harga_satuan FROM barang WHERE nama_barang = '{materialComboBoxPilihMenu.Text}'";
            DataTable dt = DbManager.ExecuteDataQuery(query);

            if (dt.Rows.Count > 0)
            {
                int maxQuantitas = Convert.ToInt32(dt.Rows[0]["jumlah_barang"]);
                labelMaxQuantitas.Text = $"Max: {maxQuantitas}";

                decimal hargaSatuan;
                if (decimal.TryParse(dt.Rows[0]["harga_satuan"].ToString().Replace("Rp. ", ""), out hargaSatuan))
                {
                    materialMaskedTextBoxSatuan.Text = hargaSatuan.ToString();
                }
                else
                {
                    materialMaskedTextBoxSatuan.Text = "";
                }
            }
            else
            {
                labelMaxQuantitas.Text = "Max: 0";
                materialMaskedTextBoxSatuan.Text = "";
            }
        }

        private void materialMaskedTextBoxQuantitas_TextChanged(object sender, EventArgs e)
        {
            decimal satuan, quantitas, total;
            if (decimal.TryParse(materialMaskedTextBoxSatuan.Text, out satuan))
            {
                if (decimal.TryParse(materialMaskedTextBoxQuantitas.Text, out quantitas))
                {
                    total = satuan * quantitas;
                    string totalFormatted = string.Format("Rp. {0:N0}", total);
                    materialMaskedTextBoxTotal.Text = totalFormatted;
                }
            }
            else if (materialMaskedTextBoxSatuan.Text == "")
            {
                materialMaskedTextBoxTotal.Text = "Rp. 0";

            }

        }

    }
}
