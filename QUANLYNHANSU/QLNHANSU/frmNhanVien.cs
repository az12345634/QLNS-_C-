using BuninessLayer;
using BuninessLayer.DTO;
using DataLayer;
using DevExpress.XtraEditors;
using QLNHANSU.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.UI;

namespace QLNHANSU
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        NHANVIEN _nhanvien;
        DANTOC _dantoc;
        TONGIAO _tongiao;
        CHUCVU _chucvu;
        TRINHDO _trinhdo;
        PHONGBAN _phongban;
        BOPHAN _bophan;
        bool _them;
        int _id;
        List<NHANVIEN_DTO> _listNVDTO;
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
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            _nhanvien = new NHANVIEN();
            _dantoc = new DANTOC();
            _tongiao = new TONGIAO();
            _chucvu = new CHUCVU();
            _trinhdo = new TRINHDO();
            _phongban = new PHONGBAN();
            _bophan = new BOPHAN();
            loadData();
            loadCombo();
            splitContainer1.Panel1Collapsed = true;
        }

        void loadCombo()
        {
            //picHinhAnh.Image = Base64ToImage(nv.HINHANH);
            cboBOPHAN.DataSource = _bophan.getList();
            cboBOPHAN.DisplayMember = "TENBP";
            cboBOPHAN.ValueMember = "IDBP";

            cboPHONGBAN.DataSource = _phongban.getList();
            cboPHONGBAN.DisplayMember = "TENPB";
            cboPHONGBAN.ValueMember = "IDPB";

            cboTRINHDO.DataSource = _trinhdo.getList();
            cboTRINHDO.DisplayMember = "TENTD";
            cboTRINHDO.ValueMember = "IDTD";

            cboCHUCVU.DataSource = _chucvu.getList();
            cboCHUCVU.DisplayMember = "TENCV";
            cboCHUCVU.ValueMember = "IDCV";

            cboDANTOC.DataSource = _dantoc.getList();
            cboDANTOC.DisplayMember = "TENDT";
            cboDANTOC.ValueMember = "ID";

            cboTonGiao.DataSource = _tongiao.getList();
            cboTonGiao.DisplayMember = "TENTG";
            cboTonGiao.ValueMember = "ID";
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
            txtHoTen.Enabled = !kt;
            txtCCCD.Enabled = !kt;
            txtDIENTHOAI.Enabled = !kt;
            txtDIACHI.Enabled = !kt;
            chkGioiTinh.Enabled = !kt;
            //picHinhAnh.Enabled = !kt; 
            cboBOPHAN.Enabled = !kt;
            cboPHONGBAN.Enabled = !kt;
            cboTRINHDO.Enabled = !kt;
            cboCHUCVU.Enabled = !kt;
            cboDANTOC.Enabled = !kt;
            cboTonGiao.Enabled = !kt;
            btnHinhAnh.Enabled = !kt;
            dtNgaySinh.Enabled = !kt;
        }

        void _reset()
        {
            txtHoTen.Text = String.Empty;
            txtCCCD.Text = String.Empty;
            txtDIENTHOAI.Text = String.Empty;
            txtDIACHI.Text = String.Empty;
            chkGioiTinh.Checked = false;
            
        }
        void loadData()
        {
            gcDanhSach.DataSource = _nhanvien.getListDTO();
            gvDanhSach.OptionsBehavior.Editable = false;
            _listNVDTO = _nhanvien.getListDTO();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _nhanvien.Delete(_id);
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

        void SaveData()
        {
            if (_them)
            {
                tb_NHANVIEN nv = new tb_NHANVIEN();
                nv.HOTEN = txtHoTen.Text;
                nv.GIOITINH = chkGioiTinh.Checked;
                nv.NGAYSINH = dtNgaySinh.Value;
                nv.DIENTHOAI = txtDIENTHOAI.Text;
                nv.CCCD = txtCCCD.Text;
                nv.DIENTHOAI = txtDIENTHOAI.Text;
                nv.DIACHI = txtDIACHI.Text;
                nv.HINHANH = ImageToBase64(picHinhAnh.Image, picHinhAnh.Image.RawFormat);
                nv.IDBP = int.Parse (cboBOPHAN.SelectedValue.ToString());
                nv.IDPB = int.Parse(cboPHONGBAN.SelectedValue.ToString());
                nv.IDTD = int.Parse(cboTRINHDO.SelectedValue.ToString());
                nv.IDCV = int.Parse(cboCHUCVU.SelectedValue.ToString());
                nv.IDDT = int.Parse(cboDANTOC.SelectedValue.ToString());
                nv.IDTG = int.Parse(cboTonGiao.SelectedValue.ToString());
                nv.MACTY = 1;
                _nhanvien.Add(nv);

            }
            else
            {
                var nv = _nhanvien.getItem(_id);
                nv.HOTEN = txtHoTen.Text;
                nv.GIOITINH = chkGioiTinh.Checked;
                nv.NGAYSINH = dtNgaySinh.Value;
                nv.DIENTHOAI = txtDIENTHOAI.Text;
                nv.CCCD = txtCCCD.Text;
                nv.DIENTHOAI = txtDIENTHOAI.Text;
                nv.DIACHI = txtDIACHI.Text;
                nv.HINHANH = ImageToBase64(picHinhAnh.Image, picHinhAnh.Image.RawFormat);
                nv.IDBP = int.Parse(cboBOPHAN.SelectedValue.ToString());
                nv.IDPB = int.Parse(cboPHONGBAN.SelectedValue.ToString());
                nv.IDTD = int.Parse(cboTRINHDO.SelectedValue.ToString());
                nv.IDCV = int.Parse(cboCHUCVU.SelectedValue.ToString());
                nv.IDDT = int.Parse(cboDANTOC.SelectedValue.ToString());
                nv.IDTG = int.Parse(cboTonGiao.SelectedValue.ToString());
                nv.MACTY = 1;
                _nhanvien.update(nv);
            }
        }

        // Hàm chuyển đổi hình ảnh lưu vào database

        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using ( MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        } 
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
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
            rptDanhSachNhanVien rpt = new rptDanhSachNhanVien(_listNVDTO);
            rpt.ShowRibbonPreview();// dùng để show các lệnh cơ bản trong word or ShowPreview về măcj định
        }

        private void dtNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barDockControlTop_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlBottom_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlLeft_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlRight_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void txtTen_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void chkGioiTinh_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void picHinhAnh_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void labelControl11_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MANV").ToString());
            // lấy id hình ảnh
            var nv = _nhanvien.getItem(_id); //getItem trong đoạn mã có chức năng tìm và trả về một đối tượng
            // khi nhấp vào tên dân tộc, nó hiển thị lên 
            txtHoTen.Text = nv.HOTEN;
            chkGioiTinh.Checked=nv.GIOITINH.Value;
            dtNgaySinh.Value= nv.NGAYSINH.Value;
            txtDIENTHOAI.Text= nv.DIENTHOAI;
            txtCCCD.Text=nv.CCCD;
            txtDIACHI.Text = nv.DIACHI;
            picHinhAnh.Image = Base64ToImage(nv.HINHANH);
            cboBOPHAN.SelectedValue = nv.IDBP;
            cboPHONGBAN.SelectedValue = nv.IDPB;
            cboTRINHDO.SelectedValue = nv.IDTD;
            cboCHUCVU.SelectedValue = nv.IDCV;
            cboDANTOC.SelectedValue = nv.IDDT;
            cboTonGiao.SelectedValue = nv.IDTG;
           // nv.MACTY = 1;
        }

        private void btnHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png, .jpg)|*.png;*.jpg";
            openFile.Title = "Chọn hình ảnh";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(openFile.FileName);
                picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}