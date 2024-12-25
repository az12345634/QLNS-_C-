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
    public partial class frmBANGCONG : DevExpress.XtraEditors.XtraForm
    {
        public frmBANGCONG()
        {
            InitializeComponent();
        }
        KYCONG _kycong;
        bool _them;
        int _makycong;

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void frmBANGCONG_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            _kycong = new KYCONG();
            loadData();

            // hiển thị năm thánh hiện tại
            cboThang.Text = DateTime.Now.Year.ToString();
            cboNam.Text = DateTime.Now.Month.ToString();
        }
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            bntHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIN.Enabled = kt;
           cboNam.Enabled = !kt;
            cboThang.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _kycong.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            cboNam.Text = DateTime.Now.Year.ToString();
            cboThang.Text = DateTime.Now.Month.ToString();
            chkKhoa.Checked =false;
            chkTRANGTHAI.Checked =false;
        }

        private void bntSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            _showHide(false);
            _them = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _kycong.Delete(_makycong, 1);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _showHide(true);
            _them = false;
        }

        private void bntHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(true);
            _them = false;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void SaveData()
        {
            // lấy dữ liệu ở view vào db và tạo dữ liệu mới
            if (_them)
            {
                tb_KYCONG kc = new tb_KYCONG();
                kc.MAKYCONG = int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text); // đẻ ra cấu trúc mã kỳ công =202201
                kc.NAM = int.Parse(cboNam.Text);
                kc.THANG = int.Parse(cboThang.Text);
                kc.KHOA = chkKhoa.Checked;
                kc.TRANGTHAI = chkTRANGTHAI.Checked;
                kc.MACTY = 1;
                // lấy ra ngày tháng năm
                kc.NGAYCONGTRONGTHANG = HAMDUNGCHUNG_functions.demSoNgayLamViecTrongThang(int.Parse(cboThang.Text), int.Parse(cboNam.Text));
                kc.NGAYTINHCONG = DateTime.Now;
                kc.CREATED_BY = 1;
                kc.CREATED_DATE = DateTime.Now;
                _kycong.Add(kc);

            }
            else
            {
                var kc = _kycong.getItem(_makycong);
                //kc.MAKYCONG = int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text); // đẻ ra cấu trúc mã kỳ công =202201
                kc.NAM = int.Parse(cboNam.Text);
                kc.THANG = int.Parse(cboThang.Text);
               
                kc.KHOA = chkKhoa.Checked;
                kc.TRANGTHAI = chkTRANGTHAI.Checked;
                // lấy ra ngày tháng năm
                kc.NGAYCONGTRONGTHANG = HAMDUNGCHUNG_functions.demSoNgayLamViecTrongThang(int.Parse(cboThang.Text), int.Parse(cboNam.Text));
                kc.NGAYTINHCONG = DateTime.Now;
                kc.CREATED_BY = 1;
                kc.CREATED_DATE = DateTime.Now;
                
                _kycong.Update(kc);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _makycong = int.Parse(gvDanhSach.GetFocusedRowCellValue("MAKYCONG").ToString());
                // khi nhấp vào tênbang cong, nó hiển thị lên 
                cboNam.Text = gvDanhSach.GetFocusedRowCellValue("NAM").ToString();
                cboThang.Text = gvDanhSach.GetFocusedRowCellValue("THANG").ToString();
                chkKhoa.Checked=bool.Parse(gvDanhSach.GetFocusedRowCellValue("KHOA").ToString());
                chkTRANGTHAI.Checked=bool.Parse(gvDanhSach.GetFocusedRowCellValue("TRANGTHAI").ToString());
            }
        }

        private void btnXemBangCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // dùng để show bảng công chi tiết
            frmBangCongChiTiet frm = new frmBangCongChiTiet();
            frm._makycong = _makycong;
            frm._thang = int.Parse(cboThang.Text);
            frm._nam = int.Parse(cboNam.Text);
            frm._macty = 1;
            frm.ShowDialog();

        }
    }
}