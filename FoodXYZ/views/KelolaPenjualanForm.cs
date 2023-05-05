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
    public partial class KelolaPenjualanForm : Form
    {
        public KelolaPenjualanForm()
        {
            InitializeComponent();
        }

        private void KelolaPenjualanForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = DbManager.ExecuteDataQuery("SELECT tgl_transaksi, SUM(total_bayar) as total FROM transaksi GROUP BY tgl_transaksi");
            dataGridView1.DataSource = DbManager.ExecuteDataQuery("SELECT transaksi.tgl_transaksi, barang.nama_barang, transaksi.total_bayar, user.nama FROM transaksi JOIN barang ON transaksi.id_barang = barang.id JOIN user ON transaksi.id_user = user.id");
            chart1.DataSource = dataTable;
            chart1.Series["Series1"].Name = "Omset";
            chart1.Series["Omset"].XValueMember = "tgl_transaksi";
            chart1.Series["Omset"].YValueMembers = "total";
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "dd/MM/yyyy";
        }

        private void materialButtonFilter_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerAwal.Value;
            DateTime endDate = dateTimePickerAkhir.Value;

            string query = $"SELECT transaksi.tgl_transaksi, barang.nama_barang, transaksi.total_bayar, user.nama FROM transaksi JOIN barang ON transaksi.id_barang = barang.id JOIN user ON transaksi.id_user = user.id WHERE tgl_transaksi BETWEEN '{startDate.ToString("yyyy-MM-dd HH:mm:ss")}' AND '{endDate.ToString("yyyy-MM-dd HH:mm:ss")}'";

            dataGridView1.DataSource = DbManager.ExecuteDataQuery(query);

            DataTable dataTable = DbManager.ExecuteDataQuery($"SELECT tgl_transaksi, SUM(total_bayar) as total FROM transaksi WHERE tgl_transaksi BETWEEN '{startDate.ToString("yyyy-MM-dd HH:mm:ss")}' AND '{endDate.ToString("yyyy-MM-dd HH:mm:ss")}' GROUP BY tgl_transaksi");
            chart1.DataSource = dataTable;
            chart1.Series["Omset"].XValueMember = "tgl_transaksi";
            chart1.Series["Omset"].YValueMembers = "total";
        }

        private void materialButtonGenerate_Click(object sender, EventArgs e)
        {
            DataTable dataTable = DbManager.ExecuteDataQuery("SELECT tgl_transaksi, SUM(total_bayar) as total FROM transaksi GROUP BY tgl_transaksi");
            dataGridView1.DataSource = DbManager.ExecuteDataQuery("SELECT transaksi.tgl_transaksi, barang.nama_barang, transaksi.total_bayar, user.nama FROM transaksi JOIN barang ON transaksi.id_barang = barang.id JOIN user ON transaksi.id_user = user.id");
            chart1.DataSource = dataTable;
            chart1.Series["Omset"].XValueMember = "tgl_transaksi";
            chart1.Series["Omset"].YValueMembers = "total";
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "dd/MM/yyyy";
        }
    }
}
