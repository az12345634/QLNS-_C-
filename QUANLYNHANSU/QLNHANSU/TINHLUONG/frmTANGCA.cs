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

namespace QLNHANSU.TINHLUONG
{
    public partial class frmTANGCA : DevExpress.XtraEditors.XtraForm
    {
        public frmTANGCA()
        {
            InitializeComponent();
        }
        // biến toàn cục
        TANGCA _tangca;
        LoaiCa _loaiCa;
        NHANVIEN _nhanvien;
        bool _them;
        int _id;
        SYS_CONFIG _config;

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmTANGCA_Load(object sender, EventArgs e)
        {
            _config = new SYS_CONFIG();
            _them = false;
            _showHide(true);
            _loaiCa = new LoaiCa();
            _tangca = new TANGCA();
            _nhanvien = new NHANVIEN();
            loadData();
            loadNhanVien();
            loadloaica();
            // lấy ra phụ cấp
            //cboPhuCap.SelectedIndexChanged += CboPhuCap_SelectedIndexChanged;
        }

        //private void CboPhuCap_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var pc = _phucap.getItemPC(int.Parse(cboPhuCap.SelectedValue.ToString()));
        //    if (pc != null)
        //    {
        //        spSoTien.EditValue = pc.SOTIEN;
        //    }
        //}

        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            bntHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIN.Enabled = kt;
            txtNoiDung.Enabled = !kt;
            spSoGio.Enabled = !kt;
            lkNhanVien.Enabled = !kt;
            cboLoaica.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _tangca.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void loadNhanVien()
        {
            lkNhanVien.Properties.DataSource = _nhanvien.getListDTO();
            lkNhanVien.Properties.DisplayMember = "HOTEN";
            lkNhanVien.Properties.ValueMember = "MANV";
        }

        void loadloaica()
        {
            cboLoaica.DataSource = _loaiCa.getList();
            cboLoaica.DisplayMember = "TENLOAICA";
            cboLoaica.ValueMember = "IDLOAICA";
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            txtNoiDung.Text = string.Empty;
            spSoGio.EditValue = 0;
            lkNhanVien.EditValue = 0;
            cboLoaica.SelectedIndex = 0;
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
                _tangca.Delete(_id, 1);
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
            if (_them)
            {
                tb_TANGCA tc = new tb_TANGCA();
                tc.IDLOAICA  = int.Parse(cboLoaica.SelectedValue.ToString());
                tc.SOGIO = double.Parse(spSoGio.EditValue.ToString());
                tc.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                tc.GHICHU = txtNoiDung.Text;
                tc.NGAY = DateTime.Now.Day;
                tc.THANG = DateTime.Now.Month;
                tc.NAM = DateTime.Now.Year;
                var lc = _loaiCa.getItem(int.Parse(cboLoaica.SelectedValue.ToString()));
                var cg = _config.getItem("TANGCA");
                tc.SOTIEN = tc.SOGIO * lc.HESO * int.Parse(cg.VALUE);
                tc.CREATE_BY = 1;
                tc.CREATE_DATE = DateTime.Now;
                _tangca.Add(tc);

            }
            else
            {
                var tc = _tangca.getItem(_id);
                tc.IDLOAICA = int.Parse(cboLoaica.SelectedValue.ToString());
                tc.IDLOAICA = int.Parse(cboLoaica.SelectedValue.ToString());
                tc.SOGIO = double.Parse(spSoGio.EditValue.ToString());
                tc.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                tc.GHICHU = txtNoiDung.Text;
                tc.NGAY = DateTime.Now.Day;
                tc.THANG = DateTime.Now.Month;
                tc.NAM = DateTime.Now.Year;
                var lc = _loaiCa.getItem(int.Parse(cboLoaica.SelectedValue.ToString()));
                var cg = _config.getItem("TANGCA");
                tc.SOTIEN = tc.SOGIO * lc.HESO * int.Parse(cg.VALUE);
                tc.UPDATED_BY = 1;
                tc.UPDATED_DATE = DateTime.Now;
                _tangca.Update(tc);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                // khi nhấp vào tên dân tộc, nó hiển thị lên 
                txtNoiDung.Text = gvDanhSach.GetFocusedRowCellValue("GHICHU").ToString();
                spSoGio.EditValue = gvDanhSach.GetFocusedRowCellValue("SOGIO");
                lkNhanVien.EditValue = gvDanhSach.GetFocusedRowCellValue("MANV");
                cboLoaica.SelectedValue = gvDanhSach.GetFocusedRowCellValue("IDLOAICA");
            }
        }
    }
}