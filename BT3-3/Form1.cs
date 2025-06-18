using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3_3
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemMoi themMoi = new ThemMoi();
            themMoi.Show();
        }

        public void CapNhatDataGridView()
        {
            string query = "SELECT * FROM SinhVien";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvSinhVien.DataSource = dt;
        }
        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ThemMoi themMoi = new ThemMoi();
            themMoi.Show();
        }
    }
}
