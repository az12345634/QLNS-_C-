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
    public partial class frmBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public frmBoPhan()
        {
            InitializeComponent();
        }
        BOPHAN _bophan;
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
            gcDanhSach.DataSource = _bophan.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
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
                _bophan.Delete(_id);
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
        void SaveData()
        {
            if (_them)
            {
                tb_BOPHAN dt = new tb_BOPHAN();
                dt.TENBP = txtTen.Text;
                _bophan.Add(dt);

            }
            else
            {
                var dt = _bophan.getItem(_id);
                dt.TENBP = txtTen.Text;
                _bophan.update(dt);
            }
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

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            // tự động lấy id
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDBP").ToString());
            // khi nhấp vào tên dân tộc, nó hiển thị lên 
            txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENBP").ToString();
        }

        private void frmBoPhan_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            _bophan = new BOPHAN();
            loadData();
        }
    }
}