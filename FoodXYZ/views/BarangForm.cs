using FoodXYZ.db;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FoodXYZ.views
{
    public partial class BarangForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private string username;
        public BarangForm(string username)
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

        private void BarangForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DbManager.ExecuteDataQuery("SELECT * FROM barang");
            List<String> satuan = new List<string> { "botol", "pis", "kresek", "ember" };
            materialComboBoxSatuan.DataSource = satuan;
        }

        private void materialButtonTambah_Click(object sender, EventArgs e)
        {
            string kodeBarang = materialMaskedTextBoxKodeBarang.Text;
            string jumlahBarang = materialMaskedTextBoxJumlahBarang.Text;
            string namaBarang = materialMaskedTextBoxNamaBarang.Text;
            string satuan = materialComboBoxSatuan.Text;
            string hargaPerSatuan = materialMaskedTextBoxHargaPersatuan.Text;
            string expiredDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            //DateTime expiredDateTime = DateTime.Parse(expiredDate);

            // Menambahkan data baru ke dalam tabel barang
            string query = "INSERT INTO barang (kode_barang, nama_barang, satuan, expired_date, jumlah_barang, harga_satuan) VALUES ('" + kodeBarang + "', '" + namaBarang + "', '" + satuan + "', '" + expiredDate + "', '" + jumlahBarang + "', '" + hargaPerSatuan + "')";
            DbManager.ExecuteQuery(query);

            // Menampilkan pesan berhasil
            MessageBox.Show("Data barang berhasil ditambahkan");

            // Mengupdate tampilan dataGridView1 dengan data terbaru dari tabel barang
            dataGridView1.DataSource = DbManager.ExecuteDataQuery("SELECT * FROM barang");
        }

        private void materialButtonEdit_Click(object sender, EventArgs e)
        {
            string kodeBarang = materialMaskedTextBoxKodeBarang.Text;
            string jumlahBarang = materialMaskedTextBoxJumlahBarang.Text;
            string namaBarang = materialMaskedTextBoxNamaBarang.Text;
            string satuan = materialComboBoxSatuan.Text;
            string expiredDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string hargaPerSatuan = materialMaskedTextBoxHargaPersatuan.Text;

            // Mengupdate data barang yang sudah ada pada tabel barang
            string query = "UPDATE barang SET nama_barang='" + namaBarang + "', satuan='" + satuan + "', expired_date='" + expiredDate + "', jumlah_barang='" + jumlahBarang + "', harga_satuan='" + hargaPerSatuan + "' WHERE kode_barang='" + kodeBarang + "'";
            DbManager.ExecuteQuery(query);

            // Menampilkan pesan berhasil
            MessageBox.Show("Data barang berhasil diupdate");

            // Mengupdate tampilan dataGridView1 dengan data terbaru dari tabel barang
            dataGridView1.DataSource = DbManager.ExecuteDataQuery("SELECT * FROM barang");

        }

        private void materialButtonHapus_Click(object sender, EventArgs e)
        {
            string kodeBarang = materialMaskedTextBoxKodeBarang.Text;

            // Menghapus data barang dari tabel barang
            string query = "DELETE FROM barang WHERE kode_barang='" + kodeBarang + "'";
            DbManager.ExecuteQuery(query);

            // Menampilkan pesan berhasil
            MessageBox.Show("Data barang berhasil dihapus");

            // Mengupdate tampilan dataGridView1 dengan data terbaru dari tabel barang
            dataGridView1.DataSource = DbManager.ExecuteDataQuery("SELECT * FROM barang");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //kode_barang, nama_barang, expired_date, jumlah_barang, satuan, harga_satuan
            materialMaskedTextBoxKodeBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            materialMaskedTextBoxNamaBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            materialMaskedTextBoxJumlahBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            materialComboBoxSatuan.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            materialMaskedTextBoxHargaPersatuan.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void materialMaskedTextBoxHargaPersatuan_TextChanged(object sender, EventArgs e)
        {
            //string input = materialMaskedTextBoxHargaPersatuan.Text;

            //// Check if the input is not empty and is numeric
            //if (!string.IsNullOrEmpty(input) && decimal.TryParse(input, out decimal hargaPerSatuan))
            //{
            //    string hargaPerSatuanRp = hargaPerSatuan.ToString("#,##0");
            //    materialMaskedTextBoxHargaPersatuan.Text = "Rp " + hargaPerSatuanRp;
            //}
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialMaskedTextBoxCariBarang_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM barang WHERE nama_barang LIKE '%" + materialMaskedTextBoxCariBarang.Text + "%'";
            dataGridView1.DataSource = DbManager.ExecuteDataQuery(query);
        }
    }
}
