using DataLayer;
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
using DevExpress.Data.Linq.Helpers;
using QLNHANSU.Reports;
using DevExpress.XtraReports.UI;
using BuninessLayer.DTO;

namespace QLNHANSU
{
    public partial class frmHOPDONGLD : Form
    {
        public frmHOPDONGLD()
        {
            InitializeComponent();
        }
        // các biến
        HOPDONGLAODONG _hdld;
        bool _them;
        string _soHD;
        string _MaxSoHD;
        NHANVIEN _nhanvien;
        List<HOPDONG_DTO> _listHD;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void frmHOPDONGLD_Load(object sender, EventArgs e)
        {
            _hdld = new HOPDONGLAODONG();
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
            txtSoHD.Enabled = !kt;
            dtNgayBD.Enabled = !kt;
            dtNGAYKT.Enabled = !kt;
            dtNGAYKY.Enabled = !kt;
            spHSL.Enabled = !kt;
            spLANKY.Enabled = !kt;
            slkNhanVien.Enabled = !kt;


        }

        private void _reset()
        {
            txtSoHD.Text = String.Empty;
            dtNgayBD.Value = DateTime.Now;
            dtNgayBD.Value = dtNgayBD.Value.AddMonths(6);
            dtNGAYKY.Value = DateTime.Now;
            spLANKY.Text = "1";
            spHSL.Text = "1";
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
            gcDanhSach.DataSource = _hdld.getListFull();
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
                _hdld.Delete(_soHD,1);
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

        private void btnIN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _listHD = _hdld.getItemFull(_soHD);
            rptHOPDONGLAODONG rpt = new rptHOPDONGLAODONG(_listHD);
            rpt.ShowPreviewDialog();
        }
        // truyền dữ liệu vào
        void SaveData()
        {
            if (_them)
            {
                // số hợp đồng có dạng 00001/2021/HDLD
                var maxSoHD = _hdld.MaxSoHopDong();
                // biến int Substring(0,5)); bắt đầu từ 0 lấy 5 kí tự
                int so =int.Parse(maxSoHD.Substring(0,5)) +1;
                tb_HOPDONG hd = new tb_HOPDONG();
                hd.SOHD = so.ToString("00000") + @"/2024/HĐLĐ";
                hd.NGAYBD = dtNgayBD.Value;
                hd.NGAYKT = dtNGAYKT.Value;
                hd.NGAYKY = dtNGAYKY.Value;
                hd.THOIHAN = cboThoiHan.Text;
                hd.HESOLUONG = double.Parse(spHSL.EditValue.ToString());
                hd.LUONGCOBAN = int.Parse(spLuongCB.EditValue.ToString());
                hd.LANKY=int.Parse (spLANKY.EditValue.ToString());
                hd.MANV= int.Parse (slkNhanVien.EditValue.ToString());
                hd.NOIDUNG = txtNoiDung.RtfText;
                hd.MACTY = 1;
                hd.CREATED_BY = 1;
                hd.CREATED_DATE = DateTime.Now;
                _hdld.Add(hd);
            }
            else
            {
                var hd = _hdld.getItem(_soHD);
                hd.NGAYBD = dtNgayBD.Value;
                hd.NGAYKT = dtNGAYKT.Value;
                hd.NGAYKY = dtNGAYKY.Value;
                hd.THOIHAN = cboThoiHan.Text;
                hd.HESOLUONG = double.Parse(spHSL.EditValue.ToString());
                hd.LUONGCOBAN = int.Parse(spLuongCB.EditValue.ToString());
                hd.LANKY = int.Parse(spLANKY.EditValue.ToString());
                hd.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                hd.NOIDUNG = txtNoiDung.RtfText;
                hd.MACTY = 1;
                hd.CREATED_BY = 1;
                hd.CREATED_DATE = DateTime.Now;
                _hdld.Update(hd);
            }
        }
        // hiển thị dữ liệu lên màn hình
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.RowCount > 0)
            {
                _soHD = gvDanhSach.GetFocusedRowCellValue("SOHD").ToString();
                var hd = _hdld.getItem(_soHD);
                txtSoHD.Text = _soHD;
                dtNgayBD.Value= hd.NGAYBD.Value;
                dtNGAYKT.Value= hd.NGAYKT.Value;
                dtNGAYKY.Value = hd.NGAYKY.Value;
                cboThoiHan.Text = hd.THOIHAN;
                spHSL.Text = hd.HESOLUONG.ToString();
                spLuongCB.EditValue= hd.LUONGCOBAN;
                txtNoiDung.RtfText = hd.NOIDUNG ;
                spLANKY.Text = hd.LANKY.ToString();
                slkNhanVien.EditValue = hd.MANV;
                _listHD =_hdld.getItemFull(_soHD);

            }
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void txtNoiDung_Click(object sender, EventArgs e)
        {

        }
    }
}
