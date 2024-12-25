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
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;

namespace QLNHANSU
{
    public partial class frmQuanLyNangLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLyNangLuong()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        NHANVIEN_NANGLUONG _nvnl;
        HOPDONGLAODONG _hopdong;
        NHANVIEN _nhanvien;

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmQuanLyNangLuong_Load(object sender, EventArgs e)
        {
            _nvnl = new NHANVIEN_NANGLUONG();
            _hopdong = new HOPDONGLAODONG();
            _nhanvien = new NHANVIEN();
            _them = false;
            loadData();
            _showHide(true);
            loadHopDong();
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
            txtSoQD.Enabled = !kt;
            txtNoiDung.Enabled = !kt;

            slkHopDONG.Enabled = !kt;


        }

        private void _reset()
        {
            txtSoQD.Text = String.Empty;
            txtNoiDung.Text = String.Empty;
            DTNGAYKY.Value = DateTime.Now;
            dtNGAYLENLUONG.Value = dtNGAYLENLUONG.Value.AddDays(45);

        }
        // lấy danh sách nhân viên
        void loadHopDong()
        {
            slkHopDONG.Properties.DataSource = _hopdong.getListFull();
            slkHopDONG.Properties.ValueMember = "SOHD";
            slkHopDONG.Properties.DisplayMember = "SOHD";
        }

        // load dữ liệu hiển thị lên màn hình
        private void loadData()
        {
            gcDanhSach.DataSource = _nvnl.getListFull();
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
                _nvnl.Delete(_soQD, 1);
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

        private void SaveData()
        {
            tbb_NHANVIEN_NANGLUONG nl;
            if (_them)
            {
                // số hợp đồng có dạng 00001/2021/HDLD
                var maxSoQD = _nvnl.MaxSoQuyetDinh();
                // biến int Substring(0,5)); bắt đầu từ 0 lấy 5 kí tự
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;
                nl = new tbb_NHANVIEN_NANGLUONG();
                nl.SOQD = so.ToString("00000") + @"/2024/QDNL";
                nl.SOHD = slkHopDONG.EditValue.ToString();
                nl.NGAYKY = DTNGAYKY.Value;
                nl.NGAYLENLUONG = dtNGAYLENLUONG.Value;
                nl.HESOLUONGHIENTAI = _hopdong.getItem(slkHopDONG.EditValue.ToString()).HESOLUONG;
                nl.HESOLUONGMOI = double.Parse (spHSLmoi.EditValue.ToString());
                nl.GHICHU = txtNoiDung.Text;
                nl.MANV = _hopdong.getItem(slkHopDONG.EditValue.ToString()).MANV;
                nl.CREATE_BY = 1;
               
                nl.CREATE_DATE = DateTime.Now;
                _nvnl.Add(nl);
            }
            else
            {
                nl = _nvnl.getItem(_soQD);
                nl.SOHD = slkHopDONG.EditValue.ToString();
                nl.NGAYKY = DTNGAYKY.Value;
                nl.NGAYLENLUONG = dtNGAYLENLUONG.Value;
                nl.HESOLUONGHIENTAI = _hopdong.getItem(slkHopDONG.EditValue.ToString()).HESOLUONG;
                nl.HESOLUONGMOI = double.Parse(spHSLmoi.EditValue.ToString());
                nl.GHICHU = txtNoiDung.Text;
                nl.MANV = _hopdong.getItem(slkHopDONG.EditValue.ToString()).MANV;
                nl.UPDATED_BY = 1;

                nl.UPDATED_DATE = DateTime.Now;
                _nvnl.Update(nl);
            }
            var hd = _hopdong.getItem(slkHopDONG.EditValue.ToString());
            hd.HESOLUONG = double.Parse (spHSLmoi.EditValue.ToString());
            _hopdong.Update(hd);
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _soQD = gvDanhSach.GetFocusedRowCellValue("SOQD").ToString();
                var nl = _nvnl.getItem(_soQD);
                txtSoQD.Text = _soQD;
                //dtNgayBD.Value = hd.NGAYBD.Value;
                //dtNGAYKT.Value = hd.NGAYKT.Value;
                txtNoiDung.Text = nl.GHICHU;
                slkHopDONG.EditValue = nl.SOHD;
               
                DTNGAYKY.Value = nl.NGAYKY.Value;
                dtNGAYLENLUONG.Value = nl.NGAYLENLUONG.Value;
                spHSLcu.EditValue = nl.HESOLUONGHIENTAI;
                spHSLmoi.EditValue = nl.HESOLUONGMOI;


              

            }
        }

        private void slkHopDONG_EditValueChanged(object sender, EventArgs e)
        {
            var hd = _hopdong.getItemFull(slkHopDONG.EditValue.ToString());
            if (hd.Count != 0)
            {
                txtNhanVien.Text = hd[0].MANV + " - "+ hd[0].HOTEN;
                spHSLcu.EditValue = hd[0].HESOLUONG;
            }
        }
    }
}