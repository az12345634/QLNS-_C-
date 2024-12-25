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

namespace QLNHANSU
{
    public partial class frmKYLUAT : DevExpress.XtraEditors.XtraForm
    {
        public frmKYLUAT()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        KHENTHUONG_KYLUAT _ktkl;
        NHANVIEN _nhanvien;

        private void frmKYLUAT_Load(object sender, EventArgs e)
        {
            _ktkl = new KHENTHUONG_KYLUAT();
            _nhanvien = new NHANVIEN();
            _them = false;
            loadData();
            _showHide(true);
            loadNhanVien();
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            _reset();
            splitContainer1.Panel1Collapsed = false;
        }

        private void bntSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = false;
            splitContainer1.Panel1Collapsed = false;
            gcDanhSach.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _ktkl.Delete(_soQD, 1);
                // nếu làm đăng nhập, có mã nhân viên thì sửa thành  _ktkl.Delete(_soQD,Mã nv);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _showHide(true);
            _them = false;
            splitContainer1.Panel1Collapsed = true;
        }

        private void bntHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(true);
            _them = false;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            bntHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIN.Enabled = kt;
            gcDanhSach.Enabled = kt;
            txtSoQD.Enabled = !kt;
            txtNoiDung.Enabled = !kt;
            txtLyDo.Enabled = !kt;
            //dtNgayBD.Enabled = !kt;
            //dtNGAYKT.Enabled = !kt;

            slkNhanVien.Enabled = !kt;


        }

        private void _reset()
        {
            txtSoQD.Text = String.Empty;
            //dtNgayBD.Value = DateTime.Now;
            //dtNgayBD.Value = dtNgayBD.Value.AddMonths(6);
            txtLyDo.Text = String.Empty;
            txtNoiDung.Text = String.Empty;


        }
        // lấy danh sách nhân viên
        void loadNhanVien()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MANV";
            slkNhanVien.Properties.DisplayMember = "HOTEN";
        }

        // load dữ liệu hiển thị lên màn hình
        private void loadData()
        {
            gcDanhSach.DataSource = _ktkl.getListFull(2);
            gvDanhSach.OptionsBehavior.Editable = false;

        }

        private void SaveData()
        {
            if (_them)
            {
                // số hợp đồng có dạng 00001/2021/HDLD
              
                var maxSoQD = _ktkl.MaxSoQuyetDinh(2); //  var maxSoQD = _ktkl.MaxSoQuyetDinh(2); là hiển thị loại 2
                // biến int Substring(0,5)); bắt đầu từ 0 lấy 5 kí tự
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;
                tb_KHENTHUONG_KYLLUAT kt = new tb_KHENTHUONG_KYLLUAT();
                kt.SOQUYETDINH = so.ToString("00000") + @"/2024/QDKT";
                //hd.NGAYBD = dtNgayBD.Value;
                //hd.NGAYKT = dtNGAYKT.Value;
                kt.LYDO = txtLyDo.Text;
                kt.NOIDUNG = txtNoiDung.Text;
                kt.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                kt.CREATE_BY = 1;
                kt.LOAI = 2; // mặc định lưu loại 2 là kỷ luật
                kt.NGAY = dtNGAYKY.Value;
                kt.CREATE_DATE = DateTime.Now;
                _ktkl.Add(kt);
            }
            else
            {
                var kt = _ktkl.getItem(_soQD);
                //hd.NGAYBD = dtNgayBD.Value;
                //hd.NGAYKT = dtNGAYKT.Value;

                kt.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                kt.LYDO = txtLyDo.Text;
                kt.NOIDUNG = txtNoiDung.Text;
                kt.NGAY = dtNGAYKY.Value;
                kt.UPDATED_BY = 1;
                kt.UPDATED_DATE = DateTime.Now;
                _ktkl.Update(kt);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _soQD = gvDanhSach.GetFocusedRowCellValue("SOQUYETDINH").ToString();
                var kt = _ktkl.getItem(_soQD);
                txtSoQD.Text = _soQD;
                //dtNgayBD.Value = hd.NGAYBD.Value;
                //dtNGAYKT.Value = hd.NGAYKT.Value;
                txtNoiDung.Text = kt.NOIDUNG;
                slkNhanVien.EditValue = kt.MANV;
                txtLyDo.Text = kt.LYDO;
                dtNGAYKY.Value = kt.NGAY.Value;

                //_listHD = _hdld.getItemFull(_soHD);

            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}