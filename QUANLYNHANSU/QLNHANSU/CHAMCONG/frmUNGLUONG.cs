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
    public partial class frmUNGLUONG : DevExpress.XtraEditors.XtraForm
    {
        public frmUNGLUONG()
        {
            InitializeComponent();
        }
        NHANVIEN _nhanvien;
        UNGLUONG _ungluong;
        bool _them;
        int _id;

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmUNGLUONG_Load(object sender, EventArgs e)
        {
         
            _them = false;
            _showHide(true);
            _ungluong = new UNGLUONG();
            _nhanvien = new NHANVIEN();
            loadData();
            loadNhanVien();
            
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
           
        }
        void loadData()
        {
            gcDanhSach.DataSource = _ungluong.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void loadNhanVien()
        {
            lkNhanVien.Properties.DataSource = _nhanvien.getListDTO();
            lkNhanVien.Properties.DisplayMember = "HOTEN";
            lkNhanVien.Properties.ValueMember = "MANV";
        }

      

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            txtNoiDung.Text = string.Empty;
            spSoTien.EditValue = 0;
            lkNhanVien.EditValue = 0;
            
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
                _ungluong.Delete(_id, 1);
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
                tb_UNGLUONG ul = new tb_UNGLUONG();
                ul.SOTIEN = double.Parse(spSoTien.EditValue.ToString());
                ul.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                ul.GHICHU = txtNoiDung.Text;
                ul.NGAY = DateTime.Now.Day;
                ul.THANG = DateTime.Now.Month;
                ul.NAM = DateTime.Now.Year;
                ul.CREATE_BY = 1;
                ul.CREATE_DATE = DateTime.Now;
                _ungluong.Add(ul);

            }
            else
            {
                var ul = _ungluong.getItem(_id);
                ul.SOTIEN = double.Parse(spSoTien.EditValue.ToString());
                ul.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                ul.GHICHU = txtNoiDung.Text;
                ul.NGAY = DateTime.Now.Day;
                ul.THANG = DateTime.Now.Month;
                ul.NAM = DateTime.Now.Year;
                ul.UPDATED_BY = 1;
                ul.UPDATED_DATE = DateTime.Now;
                _ungluong.Update(ul);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                // khi nhấp vào tên dân tộc, nó hiển thị lên 
                txtNoiDung.Text = gvDanhSach.GetFocusedRowCellValue("GHICHU").ToString();
                spSoTien.EditValue = gvDanhSach.GetFocusedRowCellValue("SOTIEN");
                lkNhanVien.EditValue = gvDanhSach.GetFocusedRowCellValue("MANV");
             
            }
        }
    }
}