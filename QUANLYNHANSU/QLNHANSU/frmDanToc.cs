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
    public partial class frmDanToc : DevExpress.XtraEditors.XtraForm
    {
        public string LoaiTKhoan { get; set; }
        public frmDanToc()
        {
          
            InitializeComponent();
        }
        DANTOC _dantoc;
        bool _them;
        int _id;
        public void _showHide(bool kt)
        {
            // Kiểm tra nếu LoaiTKhoan là "1" thì vô hiệu hóa tất cả các nút
            if (LoaiTKhoan == "1")
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
                bntHuy.Enabled = false;
                txtTen.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = !kt;
                bntHuy.Enabled = !kt;
                btnThem.Enabled = kt;
                btnSua.Enabled = kt;
                btnXoa.Enabled = kt;
                btnDong.Enabled = kt;
                txtTen.Enabled = !kt;
            }
        }




        void loadData()
        {
            gcDanhSach.DataSource = _dantoc.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void frmDanToc_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            _dantoc = new DANTOC();
            loadData();

            if (LoaiTKhoan == "0")
            {
                // Nếu LoaiTKhoan là 0, giữ nguyên các nút
                MessageBox.Show("LoaiTKhoan là 0");
            }
            else if (LoaiTKhoan == "1")
            {
                // Nếu LoaiTKhoan là 1, ẩn các nút Thêm, Sửa, Xóa
                _showHide(false);
                MessageBox.Show("LoaiTKhoan là 1");
            }
            else
            {
                // Thực hiện các thao tác khác nếu LoaiTKhoan khác "0" và "1"
                MessageBox.Show("LoaiTKhoan là " + LoaiTKhoan);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            txtTen.Text = string.Empty;

        }

        private void Sửa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                _dantoc.Delete(_id);
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

        void SaveData()
        {
            if (_them)
            {
                tb_DANTOC dt = new tb_DANTOC();
                dt.TENDT = txtTen.Text;
                _dantoc.Add(dt);

            }
            else
            {
                var dt = _dantoc.getItem(_id);
                dt.TENDT = txtTen.Text;
                _dantoc.update(dt);
            }
        }

        private void bntSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = false;
           
        }


        // hiển thị danh sách 
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            // tự động lấy id
            _id= int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
            // khi nhấp vào tên dân tộc, nó hiển thị lên 
            txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENDT").ToString();
        }
    }
}