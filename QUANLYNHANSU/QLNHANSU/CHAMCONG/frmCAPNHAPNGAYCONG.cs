using BuninessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANSU.CHAMCONG
{
    public partial class frmCAPNHAPNGAYCONG : DevExpress.XtraEditors.XtraForm
    {
        public frmCAPNHAPNGAYCONG()
        {
            InitializeComponent();
        }

        // Các biến toàn cục
        public int _manv;
        public string _hoten;
        public int _makycong;
        public string _ngay;
        public int _cNgay;// Ngày của calada trong frm cập nhật ngày công
        KYCONGCHITIET _kcct;
        BANGCONG_NHANVIEN_CT _bcct_nv;

        // hàm dùng load lại trang
        frmBangCongChiTiet frmBCCT = (frmBangCongChiTiet) Application.OpenForms["frmBangCongChiTiet"];

        private void frmCAPNHAPNGAYCONG_Load(object sender, EventArgs e)
        {
            _kcct = new KYCONGCHITIET();
            _bcct_nv = new BANGCONG_NHANVIEN_CT();
            // truyền tham số hiển thị trên form
            llblID.Text = _manv.ToString();
            lblHoTen.Text = _hoten.ToString();
            string nam = _makycong.ToString().Substring(0,4);//lấy từ kí tự 0-4 của mã kỳ công để lấy ra năm
            string thang = _makycong.ToString().Substring(4);
            string ngay = _ngay.Substring(1);
            DateTime _d = DateTime.Parse(nam + "-" + thang + "-" + ngay);
            cldNgayCong.SetDate(_d);

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {// lấy giá trị trên radio grop
            
            string _valueChamcong = rdgChamCong.Properties.Items[rdgChamCong.SelectedIndex].Value.ToString();
            string _valueNgaynghi = rdgNgayNghi.Properties.Items[rdgNgayNghi.SelectedIndex].Value.ToString();
            string fielName = "D" + _cNgay.ToString();
            var kcct = _kcct.getItem(_makycong, _manv);
            // kiểm tra xem ngày nào công nhân nào nghỉ như nào rùi mới cập nhật db
            //double? tongngaycong = kcct.TONGNGAYCONG;
            //double? tongngayphep = kcct.NGAYPHEP;
            //double? tongngaykhongphep = kcct.NGHIKHONGPHEP;
            //double? tongngayle = kcct.CONGNGAYLE;

            // ràng buộc chỉ đc cập nhật kỳ công trong tháng đó
            // kiểu định dang kỳ công 2022  x 100 +1 =202201 
            if (cldNgayCong.SelectionRange.Start.Year*100 + cldNgayCong.SelectionRange.Start.Month != +_makycong)//Mã kỳ công
            {
                MessageBox.Show("Thực hiên chấm công không đúng kỳ công. Vui lòng kiểm tra lại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // cập nhật  kì công chi tiết sau đó mới cập nhật bảng công nhân viên chi tiết
            HAMDUNGCHUNG_functions.exeQuery("UPDATE tb_KYCONGCHITIET SET " + fielName + " = '" + _valueChamcong + "'WHERE MAKYCONG="+_makycong+ " AND MANV= "+_manv);
            
            tb_BANGCONG_NHANVIEN_CT bcctnv = _bcct_nv.getItem(_makycong, _manv, cldNgayCong.SelectionStart.Day);
            // tính ngày chấm công
            
            if(cldNgayCong.SelectionStart.DayOfWeek==DayOfWeek.Sunday)
            {
                if (_valueNgaynghi == "NN")
                {
                    bcctnv.CONGCHUNHAT = 1;
                    bcctnv.NGAYCONG = 0;

                }
                else
                {
                    bcctnv.CONGCHUNHAT = 0.5;
                    bcctnv.NGAYCONG = 0;

                }
                
            }else
            {
                bcctnv.KYHIEU = _valueChamcong;
                switch (_valueChamcong)
                {
                    case "P":

                        if (_valueNgaynghi == "NN")
                        {
                            bcctnv.NGAYPHEP = 1;
                            bcctnv.NGAYCONG = 0;

                        }
                        else
                        {
                            bcctnv.NGAYPHEP = 0.5;
                            bcctnv.NGAYCONG = 0.5;

                        }
                        break;
                    case "CT":
                        if (_valueNgaynghi == "NN")
                        {
                            bcctnv.NGAYCONG = 1;

                        }
                        else // xác nhận công tác 1 buổi
                        {
                            bcctnv.NGAYCONG = 0.5;
                            bcctnv.NGAYPHEP = 0.5;
                        }
                        break;
                    case "V": // mặc định ko phép
                        if (_valueNgaynghi == "NN")
                        {
                            bcctnv.NGAYPHEP = 0;
                            bcctnv.NGAYCONG = 0;

                        }
                        else
                        {
                            bcctnv.NGAYPHEP = 0;
                            bcctnv.NGAYCONG = 0.5;
                        }
                        break;


                    case "VR": // có phép
                        if (_valueNgaynghi == "NN")
                        {
                            bcctnv.NGAYPHEP = 0;
                            bcctnv.NGAYCONG = 0;
                        }
                        else
                        {
                            bcctnv.NGAYPHEP = 0.5;
                            bcctnv.NGAYCONG = 0.5;
                        }
                        break;

                    default:
                        break;
                }
            }


           
            // update
            _bcct_nv.Update(bcctnv);
            // tính lại tổng các ngày ....
            double tongngayphep = _bcct_nv.tongngayphep(_makycong, _manv); // lấy ra ngày phép
            double tongngaycong = _bcct_nv.tongngaycong(_makycong, _manv);
            double tongngayle = _bcct_nv.tongngayle(_makycong, _manv);
            double tongngaycongchunhat = _bcct_nv.tongngaycongchunhat(_makycong, _manv);
            kcct.NGAYPHEP = tongngayphep;
            kcct.TONGNGAYCONG= tongngaycong;
            kcct.CONGNGAYLE = tongngayle;
            kcct.CONGCHUNHAT = tongngaycongchunhat;
            _kcct.Update(kcct);

            // load lại trg
            frmBCCT.loadBangCong();

            //MessageBox.Show(_valueChamcong + "--" + _valueNgaynghi );
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // bắt sự kiện khi ấn vào lịch thì nó di chuyển ở ngày trong bảng công
        private void cldNgayCong_DateSelected(object sender, DateRangeEventArgs e)
        {
            _cNgay=cldNgayCong.SelectionRange.Start.Day;
        }
    }
}