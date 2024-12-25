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
    public partial class frmCongTy : DevExpress.XtraEditors.XtraForm
    {
        public frmCongTy()
        {
            InitializeComponent();
        }
        CONGTY _congty;
        bool _them;
        int _id;
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            bntHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIN.Enabled = kt;
            txtTen.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            txtEmail.Enabled = !kt;
            txtDienThoai.Enabled = !kt;
        }

        void loadData()
        {
            gcDanhSach.DataSource = _congty.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            // tự động lấy id
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MACTY").ToString());
            // khi nhấp vào tên dân tộc, nó hiển thị lên 
            txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENCTY").ToString();
            txtDiaChi.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
            txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
            txtDienThoai.Text = gvDanhSach.GetFocusedRowCellValue("DIENTHOAI").ToString();
           
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            txtTen.Text = string.Empty;
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
                _congty.Delete(_id);
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

        private void btnIN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void frmCongTy_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            _congty = new CONGTY();
            loadData();
        }
        void SaveData()
        {
            if (_them)
            {
                tb_CONGTY dt = new tb_CONGTY();
                dt.TENCTY = txtTen.Text;
                dt.DIACHI = txtDiaChi.Text;
                dt.EMAIL = txtEmail.Text;
                dt.DIENTHOAI = txtDienThoai.Text;
                _congty.Add(dt);

            }
            else
            {
                var dt = _congty.getItem(_id);
                dt.TENCTY = txtTen.Text;
                dt.DIACHI = txtDiaChi.Text;
                dt.EMAIL = txtEmail.Text;
                dt.DIENTHOAI = txtDienThoai.Text;
                _congty.update(dt);
            }
        }
    }
}