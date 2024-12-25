using DevExpress.XtraEditors;
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

namespace QLNHANSU
{
    public partial class DANGNHAP : DevExpress.XtraEditors.XtraForm
    {
        public static String Connection = @"Data Source=DESKTOP-D1CI67H;Initial Catalog=QLNHANVIEN;Integrated Security=true";
        public static String loaitk = "-1";
       
        public DANGNHAP()
        {
            InitializeComponent();
            lblError.Text = "";
        }

        private void DANGNHAP_Load(object sender, EventArgs e)
        {
            lblError.Text = ""; // Xóa lỗi khi load form
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
             try
    {
        string tk = txtTenTKhoan.Text.Trim(); // Loại bỏ khoảng trắng thừa
        string mk = txtMatKhau.Text.Trim();

        if (string.IsNullOrEmpty(tk) || string.IsNullOrEmpty(mk))
        {
            MessageBox.Show("Tên tài khoản hoặc mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenTKhoan.Focus();
            return;
        }

        // Truy vấn sử dụng tham số để tránh lỗi SQL Injection
        string sql = "SELECT Loai_TKhoan FROM [tb_tblTaiKhoan] WHERE Ten_TKhoan = @tk AND Mat_Khau = @mk";

        using (SqlConnection conn = new SqlConnection(Connection))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@tk", tk);
                cmd.Parameters.AddWithValue("@mk", mk);

                object kq = cmd.ExecuteScalar();

                if (kq == null || string.IsNullOrEmpty(kq.ToString()))
                {
                    // Trường hợp đăng nhập thất bại
                    MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tài khoản và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenTKhoan.SelectAll();
                    txtMatKhau.Clear();
                    txtTenTKhoan.Focus();
                }
                else
                {
                    loaitk = kq.ToString(); // Lưu loại tài khoản vào biến static loaitk

                    if (loaitk == "1") // Loại tài khoản User
                    {
                        MessageBox.Show("Chào mừng User!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (loaitk == "0") // Loại tài khoản Admin
                    {
                        MessageBox.Show("Chào mừng Admin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Loại tài khoản không xác định.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // Truyền LoaiTKhoan vào MainFrom
                    MainFrom main = new MainFrom(loaitk); // Truyền loại tài khoản cho form MainFrom
                    main.Show();
                    this.Hide(); // Ẩn form đăng nhập
                }
            }
        }
    }
    catch (Exception ex)
    {
        lblError.Text = "Có lỗi xảy ra: " + ex.Message;
    }
}

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
          "Bạn có chắc chắn muốn thoát không?",
          "Xác nhận thoát",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}