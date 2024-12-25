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
    public partial class THONGKE : DevExpress.XtraEditors.XtraForm
    {
        public THONGKE()
        {
            InitializeComponent();
        }
        HAMDUNGCHUNG_functions truyxuat = new HAMDUNGCHUNG_functions();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void THONGKE_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-D1CI67H;Initial Catalog=QLNHANVIEN;Integrated Security=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql1 = "Select COUNT(*) from tb_NHANVIEN";
                string sql2 = "Select COUNT(*) from tb_HOPDONG";
                //string sql3 = "Select COUNT(*) from tblDuAn";
                string sql4 = "Select COUNT(*) from tb_tblTaiKhoan";

                int a = 0;
                int b = 0;
                //int c = 0;
                int d = 0;

                //sử dụng một đối tượng SqlCommand để thực thi một truy vấn SQL và lấy kết quả trả về từ truy vấn đó bằng cách sử dụng phương thức ExecuteScalar().

                using (SqlCommand command = new SqlCommand(sql1, connection))
                {
                    a = Convert.ToInt32(command.ExecuteScalar());
                    //Sử dụng phương thức Convert.ToInt32() để chuyển đổi kết quả trả về từ ExecuteScalar() thành một số nguyên. Kết quả này được gán cho biến b, mà có vẻ như là biến để đếm số lượng bản ghi.

                }
                using (SqlCommand command = new SqlCommand(sql4, connection))
                {
                    d = Convert.ToInt32(command.ExecuteScalar());

                }
                using (SqlCommand command = new SqlCommand(sql2, connection))
                {
                    b = Convert.ToInt32(command.ExecuteScalar());

                }


                // Tương tự cho các câu lệnh SQL khác

                // Hiển thị dữ liệu
                lblSoluongnv.Text += a;
                lblSoluonghopdong.Text += b;
                //lblSoluongduan.Text += c;
                lblSoluongtk.Text += d;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("bạn có chắc muốn thoát không", "thông báo");
            if (traloi == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}