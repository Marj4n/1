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
            dataGridView1.DataSource = DbManager.ExecuteDataQuery("SELECT * FROM transaksi");
            chart1.DataSource = dataTable;
            chart1.Series["Series1"].XValueMember = "tgl_transaksi";
            chart1.Series["Series1"].YValueMembers = "total";
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "dd/MM/yyyy";
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void materialButtonFilter_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerAwal.Value;
            DateTime endDate = dateTimePickerAkhir.Value;

            string query = $"SELECT * FROM transaksi WHERE tgl_transaksi >= '{startDate.ToString("yyyy-MM-dd")}' AND tgl_transaksi <= '{endDate.ToString("yyyy-MM-dd")}'";

            // Filter data di grid
            dataGridView1.DataSource = DbManager.ExecuteDataQuery(query);

            // Filter data di chart
            chart1.DataSource = DbManager.ExecuteDataQuery(query);
            chart1.DataBind();
        }

        private void materialButtonGenerate_Click(object sender, EventArgs e)
        {
            // refresh chart dan data grid
            DataTable dataTable = DbManager.ExecuteDataQuery("SELECT tgl_transaksi, SUM(total_bayar) as total FROM transaksi GROUP BY tgl_transaksi");
            dataGridView1.DataSource = DbManager.ExecuteDataQuery("SELECT * FROM transaksi");
            chart1.DataSource = dataTable;
            chart1.Series["Series1"].XValueMember = "tgl_transaksi";
            chart1.Series["Series1"].YValueMembers = "total";
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "dd/MM/yyyy";
        }
    }
}
