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
using MySqlX.XDevAPI.Relational;

namespace FoodXYZ.views
{
    public partial class TransaksiForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private string username;

        private string GenerateTransaksiId()
        {
            string tanggal = DateTime.Now.ToString("ddMMyyyy");
            string id = $"TR{tanggal}";
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
            string currentUser = DbManager.ExecuteQuery($"SELECT username FROM user_season");
            kasirUsername.Text = currentUser;
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
        }

        private void materialButtonPrint_Click(object sender, EventArgs e)
        {
            DataTable dataTable = DbManager.ExecuteDataQuery("SELECT * FROM struk");

            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data yang dapat di-print", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create PDF document
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            string fileName = "struk.pdf";

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", fileName);
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            // table struk : 
            // tanggal
            // kode_barang
            // nama_barang
            // harga_satuan
            // quantitas
            // subtotal
            // uang_kembalian
            // uang_bayar
            // kode_transaksi
            // kasir
            document.Add(new Paragraph("Tanggal : " + dataTable.Rows[0]["tanggal"].ToString()));
            document.Add(new Paragraph("Kasir : " + dataTable.Rows[0]["kasir"].ToString()));
            document.Add(new Paragraph("Kode Transaksi : " + dataTable.Rows[0]["kode_transaksi"].ToString()));
            document.Add(new Paragraph("Kode Barang : " + dataTable.Rows[0]["kode_barang"].ToString()));
            document.Add(new Paragraph(""));

            // Add table to document
            PdfPTable table = new PdfPTable(3);
            table.WidthPercentage = 100;
            table.AddCell(new PdfPCell(new Phrase("Nama Barang")));
            table.AddCell(new PdfPCell(new Phrase("Quantitas")));
            table.AddCell(new PdfPCell(new Phrase("Harga Satuan")));

            // Add table data
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                PdfPCell cellNamaBarang = new PdfPCell(new Phrase(dataTable.Rows[i]["nama_barang"].ToString()));
                PdfPCell cellQuantitas = new PdfPCell(new Phrase(dataTable.Rows[i]["quantitas"].ToString()));
                PdfPCell cellHargaSatuan = new PdfPCell(new Phrase(dataTable.Rows[i]["harga_satuan"].ToString()));
                cellNamaBarang.Border = 0;
                cellQuantitas.Border = 0;
                cellHargaSatuan.Border = 0;
                table.AddCell(cellNamaBarang);
                table.AddCell(cellQuantitas);
                table.AddCell(cellHargaSatuan);
            }

            document.Add(table);
            document.Add(new Paragraph("Subtotal : " + dataTable.Rows[0]["subtotal"].ToString()));
            document.Add(new Paragraph("Uang Bayar : " + dataTable.Rows[0]["uang_bayar"].ToString()));
            document.Add(new Paragraph("Uang Kembalian : " + dataTable.Rows[0]["uang_kembalian"].ToString()));

            document.Close();

            MessageBox.Show("Data berhasil di-print dan disimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void materialButtonSimpan_Click(object sender, EventArgs e)
        {
            // Check if there is any transaction to save
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada transaksi yang dapat disimpan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DbManager.ExecuteQuery("DELETE FROM struk");
            // Get current date and time
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Loop through all rows in the DataGridView and insert them into the database
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string transaksiKode = GenerateTransaksiId();
                decimal totalBayar = Convert.ToDecimal(row.Cells[5].Value);
                string userId = "1"; // TODO: Ganti dengan ID user yang sesuai
                string productName = materialComboBoxPilihMenu.Text;
                string selectQuery = $"SELECT id FROM barang WHERE nama_barang = '{productName}'";
                DataTable dataTable = DbManager.ExecuteDataQuery(selectQuery);
                string barangId = dataTable != null ? dataTable.Rows[0]["id"].ToString() : "";

                // Insert transaction data into the database
                if (totalBayar > 0)
                {
                    string currentUser = DbManager.ExecuteQuery($"SELECT username FROM user_season");
                    string insertQuery = $"INSERT INTO transaksi (no_transaksi, tgl_transaksi, total_bayar, id_user, id_barang) VALUES ('{transaksiKode}', '{currentDate}', {totalBayar}, {userId}, {barangId})";
                    DbManager.ExecuteQuery(insertQuery);
                    string querystruk = $"INSERT INTO struk (tanggal, kode_barang, nama_barang, harga_satuan, quantitas, subtotal, uang_kembalian, uang_bayar, kode_transaksi, kasir) VALUES ('{currentDate}', '{row.Cells[1].Value}', '{row.Cells[2].Value}', {Convert.ToInt32(row.Cells[3].Value)},{Convert.ToDecimal(row.Cells[4].Value)}, {totalBayar}, {Convert.ToDecimal(Kembaliann.Text)}, {materialMaskedTextBoxMasukkanUang.Text}, '{transaksiKode}', '{currentUser}')";

                    DbManager.ExecuteQuery(querystruk);
                }
                // clear that row
            }

            // Clear transaction data
            dataGridView1.Rows.Clear();
            TotalHarga.Text = "0";
            Kembaliann.Text = "0";
            materialMaskedTextBoxMasukkanUang.Text = "";

            MessageBox.Show("Transaksi berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
