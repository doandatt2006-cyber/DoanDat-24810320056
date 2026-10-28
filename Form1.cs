using System;
using System.Data.SqlClient; // 1. Thêm thư viện kết nối SQL Server
using System.Windows.Forms;

namespace DoanDat_24810320056
{
    public partial class Form1 : Form
    {
        // 2. Thêm chuỗi kết nối CSDL tới server localhost
        private string connectionString = @"Data Source=localhost;Initial Catalog=QL_NguoiDung;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool loi = false;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Vui lòng nhập tên đăng nhập");
                loi = true;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Vui lòng nhập mật khẩu");
                loi = true;
            }

            if (loi)
            {
                return;
            }

            // 3. Kiểm tra thông tin tài khoản trong Cơ sở dữ liệu
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}