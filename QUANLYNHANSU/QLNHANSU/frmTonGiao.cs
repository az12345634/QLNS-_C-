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
using DataLayer;
using BuninessLayer;

namespace QLNHANSU
{
    public partial class frmTonGiao : DevExpress.XtraEditors.XtraForm
    {
        public frmTonGiao()
        {
            InitializeComponent();
        }
        TONGIAO _tongiao;
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
        }
        void loadData()
        {
            gcDanhSach.DataSource = _tongiao.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void txtTen_EditValueChanged(object sender, EventArgs e)
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
                _tongiao.Delete(_id);
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

        private void frmTonGiao_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            _tongiao = new TONGIAO();
            loadData();
        }

        void SaveData()
        {
            if (_them)
            {
                tb_TONGIAO dt = new tb_TONGIAO();
                dt.TENTG = txtTen.Text;
                _tongiao.Add(dt);

            }
            else
            {
                var dt = _tongiao.getItem(_id);
                dt.TENTG = txtTen.Text;
                _tongiao.update(dt);
            }
        }

        // hiển thị danh sách 
      
        private void gvDanhSach_Click_1(object sender, EventArgs e)
        {
            // tự động lấy id
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
            // khi nhấp vào tên dân tộc, nó hiển thị lên 
            txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENTG").ToString();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}