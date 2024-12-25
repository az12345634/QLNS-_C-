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
    public partial class frmTaikhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTaikhoan()
        {
            InitializeComponent();
        }
        TAIKHOAN _taikhoan;
        bool _them;
        string _id;
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            bntHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            txtTaikhoan.Enabled = !kt;
            txtMatkhau.Enabled = !kt;
            txtVaitro.Enabled = !kt;
     
        }

        void loadData()
        {
            gcDanhSach.DataSource = _taikhoan.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmTaikhoan_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            _taikhoan = new TAIKHOAN();
            loadData();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            txtTaikhoan.Text = string.Empty;
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
                _taikhoan.Delete(_id);
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
                tb_tblTaiKhoan dt = new tb_tblTaiKhoan();
                dt.Ten_TKhoan = txtTaikhoan.Text;
                dt.Mat_Khau = txtMatkhau.Text;
                dt.Loai_TKhoan = int.Parse(txtVaitro.Text);
                _taikhoan.Add(dt);

            }
            else
            {
                var dt = _taikhoan.getItem(_id);
                dt.Ten_TKhoan = txtTaikhoan.Text;
                dt.Mat_Khau = txtMatkhau.Text;
                dt.Loai_TKhoan = int.Parse(txtVaitro.Text);
                _taikhoan.update(dt);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = gvDanhSach.GetFocusedRowCellValue("Ten_TKhoan").ToString();
            // khi nhấp vào tên dân tộc, nó hiển thị lên 
            txtMatkhau.Text = gvDanhSach.GetFocusedRowCellValue("Mat_Khau").ToString();
            txtTaikhoan.Text = gvDanhSach.GetFocusedRowCellValue("Ten_TKhoan").ToString();
            txtVaitro.Text = gvDanhSach.GetFocusedRowCellValue("Loai_TKhoan").ToString();

        }

    }
}