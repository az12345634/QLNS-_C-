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
    public partial class frmPHUCAP : DevExpress.XtraEditors.XtraForm
    {
        public frmPHUCAP()
        {
            InitializeComponent();
        }
        PHUCAP _phucap;
        NHANVIEN _nhanvien;
        bool _them;
        int _id;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPHUCAP_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            _phucap = new PHUCAP();
            _nhanvien= new NHANVIEN();
            loadData();
            loadNhanVien();
            loadPhuCap();
            // lấy ra phụ cấp
            cboPhuCap.SelectedIndexChanged += CboPhuCap_SelectedIndexChanged;



        }
        private void CboPhuCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pc = _phucap.getItemPC(int.Parse(cboPhuCap.SelectedValue.ToString()));
            if (pc != null)
            {
                spSoTien.EditValue = pc.SOTIEN;
            }
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
            txtNoiDung.Enabled = !kt;
            spSoTien.Enabled = !kt;
            lkNhanVien.Enabled = !kt;
            cboPhuCap.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _phucap.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void loadNhanVien()
        {
            lkNhanVien.Properties.DataSource = _nhanvien.getListDTO();
            lkNhanVien.Properties.DisplayMember = "HOTEN";
            lkNhanVien.Properties.ValueMember = "MANV";
        }

        void loadPhuCap()
        {
            cboPhuCap.DataSource = _phucap.getListPC();
            cboPhuCap.DisplayMember = "TENPC";
            cboPhuCap.ValueMember = "IDPC";
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            txtNoiDung.Text = string.Empty;
            spSoTien.EditValue = 0;
            lkNhanVien.EditValue = 0;
            cboPhuCap.SelectedIndex = 0;
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
                _phucap.Delete(_id, 1);
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

        void SaveData()
        {
            if (_them)
            {
                tb_NHANVIEN_PHUCAP pc = new tb_NHANVIEN_PHUCAP();
                pc.IDPC = int.Parse(cboPhuCap.SelectedValue.ToString());
                pc.SOTIEN = double.Parse(spSoTien.EditValue.ToString());
                pc.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                pc.NOIDUNG = txtNoiDung.Text;
                pc.NGAY = DateTime.Now;
                pc.CREATE_BY = 1 ;
                pc.CREATE_DATE = DateTime.Now;
                _phucap.Add(pc);

            }
            else
            {
                var pc = _phucap.getItem(_id);
                pc.IDPC = int.Parse(cboPhuCap.SelectedValue.ToString());
                pc.SOTIEN = double.Parse(spSoTien.EditValue.ToString());
                pc.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                pc.NOIDUNG = txtNoiDung.Text;
                pc.NGAY = DateTime.Now;
                pc.UPDATED_BY = 1;
                pc.UPDATED_DATE = DateTime.Now;
                _phucap.Update(pc);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                // khi nhấp vào tên dân tộc, nó hiển thị lên 
                txtNoiDung.Text = gvDanhSach.GetFocusedRowCellValue("NOIDUNG").ToString();
                spSoTien.EditValue = gvDanhSach.GetFocusedRowCellValue("SOTIEN");
                lkNhanVien.EditValue = gvDanhSach.GetFocusedRowCellValue("MANV");
                cboPhuCap.SelectedValue = gvDanhSach.GetFocusedRowCellValue("IDPC");
            }
        }

       
    }
}