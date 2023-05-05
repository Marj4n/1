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

namespace FoodXYZ.views
{
    public partial class AdminForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private string username;
        public AdminForm(string username)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            this.username = username;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DbManager.ExecuteDataQuery("SELECT l.*, u.username FROM log l JOIN user u ON l.id_user = u.id");
            dataGridView1.Columns["id_user"].Visible = false;
            dataGridView1.Columns["username"].HeaderText = "Username";
            dataGridView1.Columns["username"].DataPropertyName = "username";
        }

        private void materialButtonLogout_Click(object sender, EventArgs e)
        {
            string log = $"INSERT INTO log (waktu, aktivitas, id_user) VALUES (NOW(), 'logout', (SELECT id FROM user WHERE username = '{username}'))";
            DbManager.ExecuteQuery(log);
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void materialButtonFilter_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker.Value.ToString("yyyy-MM-dd");
            dataGridView1.DataSource = DbManager.ExecuteDataQuery($"SELECT * FROM log WHERE waktu LIKE '{date}%'");
        }

        private Form activeForm = null;

        private void openChildPanel(Form childForm)
        {
            if (activeForm != null) { activeForm.Close(); }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void materialButtonKelolaUser_Click(object sender, EventArgs e)
        {
            openChildPanel(new KelolaUserForm());
        }

        private void materialButtonKelolaLaporan_Click(object sender, EventArgs e)
        {
            openChildPanel(new KelolaPenjualanForm());
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
