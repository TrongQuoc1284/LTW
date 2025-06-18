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
    public partial class ThemMoi : Form
    {
        private Form1 mainForm;
        public ThemMoi()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateStudentData())
            {
                string query = "INSERT INTO SinhVien (MaSV, TenSV, NgaySinh) VALUES (@masv, @tensv, @ngaysinh)";

                using (SqlConnection connection = new SqlConnection(mainForm.Text.ToString()))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@masv", txtMSSV.Text);
                            command.Parameters.AddWithValue("@tensv", txtTenSV.Text);
                            command.Parameters.AddWithValue("@khoa", cbbKhoa.Text.ToString());
                            command.Parameters.AddWithValue("@diemtb", txtDiemTB.Text.ToString());
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Sinh viên đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        mainForm.CapNhatDataGridView();
                        Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập chính xác thông tin sinh viên.");
            }
        }
        private bool ValidateStudentData()
        {
            return true;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbKhoa.Items.Clear();
            cbbKhoa.Items.Add("Công nghệ thông tin");
            cbbKhoa.Items.Add("Ngôn ngữ Anh");
            cbbKhoa.Items.Add("Quản trị kinh doanh");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
