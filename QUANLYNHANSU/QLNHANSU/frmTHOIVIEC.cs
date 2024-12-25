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
    public partial class frmTHOIVIEC : DevExpress.XtraEditors.XtraForm
    {
        public frmTHOIVIEC()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        THOIVIEC _thoiviec;
        NHANVIEN _nhanvien;

        private void frmTHOIVIEC_Load(object sender, EventArgs e)
        {
            _thoiviec = new THOIVIEC();
            _nhanvien = new NHANVIEN();
            _them = false;
            loadData();
            _showHide(true);
            loadNhanVien();
            splitContainer1.Panel1Collapsed = true;
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
            dtNGAYNOP.Enabled= !kt;
            DTNGAYNGHI.Enabled= !kt;

            slkNhanVien.Enabled = !kt;


        }

        private void _reset()
        {
            txtSoQD.Text = String.Empty;
            txtLyDo.Text = String.Empty;
            txtNoiDung.Text = String.Empty;
            dtNGAYNOP.Value = DateTime.Now;
            DTNGAYNGHI.Value = dtNGAYNOP.Value.AddDays(45);

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
            gcDanhSach.DataSource = _thoiviec.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;

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
                _thoiviec.Delete(_soQD, 1);
                loadData();
            }
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

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _showHide(true);
            _them = false;
            splitContainer1.Panel1Collapsed = true;
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _soQD = gvDanhSach.GetFocusedRowCellValue("SOQD").ToString();
                var tv = _thoiviec.getItem(_soQD);
                txtSoQD.Text = _soQD;
                //dtNgayBD.Value = hd.NGAYBD.Value;
                //dtNGAYKT.Value = hd.NGAYKT.Value;
                txtNoiDung.Text = tv.GHICHU;
                slkNhanVien.EditValue = tv.MANV;
                txtLyDo.Text = tv.LYDO;
                dtNGAYNOP.Value = tv.NGAYNOPDON.Value;
                DTNGAYNGHI.Value = tv.NGAYNGHI.Value;

                //_listHD = _hdld.getItemFull(_soHD);

            }
        }


        private void SaveData()
        {
            tb_THOIVIEC tv;
            if (_them)
            {
                // số hợp đồng có dạng 00001/2021/HDLD
                var maxSoQD = _thoiviec.MaxSoQuyetDinh();
                // biến int Substring(0,5)); bắt đầu từ 0 lấy 5 kí tự
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;
                tv = new tb_THOIVIEC();
                tv.SOQD = so.ToString("00000") + @"/2024/NVTV";
                tv.NGAYNOPDON = dtNGAYNOP.Value;
                tv.NGAYNGHI = DTNGAYNGHI.Value;
                tv.LYDO = txtLyDo.Text;
                tv.GHICHU = txtNoiDung.Text;
                tv.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                tv.CREATED_BY = 1;
          
                tv.CREATED_DATE = DateTime.Now;
                _thoiviec.Add(tv);
            }
            else
            {
                tv = _thoiviec.getItem(_soQD);

                tv.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                tv.LYDO = txtLyDo.Text;
                tv.GHICHU = txtNoiDung.Text;
                tv.NGAYNGHI = DTNGAYNGHI.Value;
                tv.NGAYNOPDON = dtNGAYNOP.Value;
                tv.UPDATE_BY = 1;
                tv.UPDATE_DATE = DateTime.Now;
                _thoiviec.Update(tv);
            }
            var nv = _nhanvien.getItem(tv.MANV.Value);
            nv.DATHOIVIEC = true;
            _thoiviec.Update(tv);
        }

        private void dtNGAYNOP_ValueChanged(object sender, EventArgs e)
        {
            DTNGAYNGHI.Value = dtNGAYNOP.Value.AddDays(45);
        }
    }
}