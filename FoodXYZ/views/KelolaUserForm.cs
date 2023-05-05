using FoodXYZ.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodXYZ.views
{
    public partial class KelolaUserForm : Form
    {
        public KelolaUserForm()
        {
            InitializeComponent();
        }

        private string tipeUser = "";
        private string nama = "";
        private string telepon = "";
        private string alamat = "";
        private string username = "";
        private string password = "";

        private void KelolaUserForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DbManager.ExecuteDataQuery("SELECT * FROM user");
            List<String> tipeUser = new List<string> { "admin", "kasir", "gudang" };
            materialComboBoxTipeUser.DataSource = tipeUser;
        }

        private void materialButtonTambah_Click(object sender, EventArgs e)
        {
            tipeUser = materialComboBoxTipeUser.Text;
            nama = materialMaskedTextBoxNama.Text;
            telepon = materialMaskedTextBoxTelepon.Text;
            alamat = materialMaskedTextBoxAlamat.Text;
            username = materialMaskedTextBoxUsername.Text;
            password = materialMaskedTextBoxPassword.Text;
            if (tipeUser == "" || nama == "" || telepon == "" || alamat == "" || username == "" || password == "")
            {
                MessageBox.Show("Mohon isi semua data");
            }
            else
            {
                string query = "INSERT INTO user (tipe_user, nama, telepon, alamat, username, password) VALUES ('" + tipeUser + "', '" + nama + "', '" + telepon + "', '" + alamat + "', '" + username + "', '" + password + "')";
                DbManager.ExecuteQuery(query);
                dataGridView1.DataSource = DbManager.ExecuteDataQuery("SELECT * FROM user");
                MessageBox.Show("Data berhasil ditambahkan");
                materialComboBoxTipeUser.Text = "";
                materialMaskedTextBoxNama.Text = "";
                materialMaskedTextBoxTelepon.Text = "";
                materialMaskedTextBoxAlamat.Text = "";
                materialMaskedTextBoxUsername.Text = "";
                materialMaskedTextBoxPassword.Text = "";
            }
        }

        private void materialButtonEdit_Click(object sender, EventArgs e)
        {
            tipeUser = materialComboBoxTipeUser.Text;
            nama = materialMaskedTextBoxNama.Text;
            telepon = materialMaskedTextBoxTelepon.Text;
            alamat = materialMaskedTextBoxAlamat.Text;
            username = materialMaskedTextBoxUsername.Text;
            password = materialMaskedTextBoxPassword.Text;
            if (tipeUser == "" || nama == "" || telepon == "" || alamat == "" || username == "" || password == "")
            {
                MessageBox.Show("Mohon isi semua data");
            }
            else
            {
                string query = "UPDATE user SET tipe_user = '" + materialComboBoxTipeUser.Text + "', nama = '" + materialMaskedTextBoxNama.Text + "', telepon = '" + materialMaskedTextBoxTelepon.Text + "', alamat = '" + materialMaskedTextBoxAlamat.Text + "', username = '" + materialMaskedTextBoxUsername.Text + "', password = '" + materialMaskedTextBoxPassword.Text + "' WHERE id = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                DbManager.ExecuteQuery(query);
                dataGridView1.DataSource = DbManager.ExecuteDataQuery("SELECT * FROM user");
                MessageBox.Show("Data berhasil diubah");
            }
        }

        private void materialButtonDelete_Click(object sender, EventArgs e)
        {

            string query = "DELETE FROM user WHERE id = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            DbManager.ExecuteQuery(query);
            dataGridView1.DataSource = DbManager.ExecuteDataQuery("SELECT * FROM user");
            MessageBox.Show("Data berhasil dihapus");
        }

        private void materialMaskedTextBoxCariUser_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM user WHERE nama LIKE '%" + materialMaskedTextBoxCariUser.Text + "%'";
            dataGridView1.DataSource = DbManager.ExecuteDataQuery(query);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            materialComboBoxTipeUser.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            materialMaskedTextBoxNama.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            materialMaskedTextBoxAlamat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            materialMaskedTextBoxUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            materialMaskedTextBoxTelepon.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            materialMaskedTextBoxPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
