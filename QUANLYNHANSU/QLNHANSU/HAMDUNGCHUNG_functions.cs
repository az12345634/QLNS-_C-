using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace QLNHANSU
{
    public class HAMDUNGCHUNG_functions
    {
        // đếm số ngày làm việc trong tháng
        public static  int demSoNgayLamViecTrongThang(int thang, int nam)
        {
            int dem = 0;
            DateTime f= new DateTime(nam,thang,01);
            int x = f.Month + 1;
            while (f.Month < x)
            {
                dem = dem + 1;
                if(f.DayOfWeek == DayOfWeek.Sunday)// nếu là ngày chủ nhật
                {
                    dem = dem - 1;
                }
                f = f.AddDays(1);
            }
            return dem;
        }

        public static int laySoNgayCuaThang(int thang, int nam)
        {
            return DateTime.DaysInMonth(thang,nam);
        }

        public static string layThuTrongTuan(int nam, int thang,int ngay)
        {
            string thu = "";
            DateTime newData = new DateTime(nam,thang,ngay);
            switch (newData.DayOfWeek.ToString())
            {
                case "Monday":
                    thu = "Thứ hai";
                    break;
                case "Tuesday":
                    thu = "Thứ ba";
                    break;
                case "Wednesday":
                    thu = "Thứ tư";
                    break;
                case "Thursday":
                    thu = "Thứ năm";
                    break;
                case "Friday":
                    thu = "Thứ sau";
                    break;
                case "Saturday":
                    thu = "Thứ bảy";
                    break;
                case "Sunday":
                    thu = "Chủ nhật";
                    break;
            }
            return thu;
        }

        // khai báo 1 biến sql thủ công
        static SqlConnection con = new SqlConnection();
        // hàm tạo kết nối
        //public static void taoKetNoi()
        //{
        //    // cấu trúc chuỗi kết nối đến csdl SQL
        //    con.ConnectionString = @"Data Source=DESKTOP-D1CI67H;Initial Catalog=QLNHANVIEN;Integrated Security=true";
        //    try
        //    {
        //        if (con.State == ConnectionState.Open)
        //        {
        //            // Nếu kết nối đã mở, đóng nó trước khi thay đổi chuỗi kết nối
        //            con.Close();xxx
        //        }
        //        con.Open(); // mở kết nối tới csdl
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        public static void taoKetNoi()
        {
            // Tạo mới một đối tượng kết nối
            con = new SqlConnection(@"Data Source=DESKTOP-D1CI67H;Initial Catalog=QLNHANVIEN;Integrated Security=true");
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    // Nếu kết nối đã mở, đóng nó trước khi thay đổi chuỗi kết nối
                    con.Close();
                }
                // Mở kết nối tới csdl
                con.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // hàm đóng kết nối
        public static void dongKetNoi()
        {
            con.Close();
        }
        // Hàm cho dữ liệu vào db
        public static DataTable GetData(string query)
        {
            taoKetNoi();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.Fill(tb);
            dongKetNoi();
            return tb;
        }

        // Hàm lấy dữ liệu bảng data
        public static DataSet GetDataSet(string query)
        {
            taoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        // hàm insert/update dữ liệu
        public static void exeQuery (string qr)
        {
            taoKetNoi();
            SqlCommand cmd = new SqlCommand(qr,con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dongKetNoi();

        }

        // lấy một giá trị dữ liệu ra 
        public object executeScalar(string qr)
        {
            SqlCommand cmd = new SqlCommand(qr, con);
            taoKetNoi();
           
            object kq = cmd.ExecuteScalar();
         
            if (kq != null)
            {
                return kq.ToString();
            }
            else return "";

        }
    }
}
