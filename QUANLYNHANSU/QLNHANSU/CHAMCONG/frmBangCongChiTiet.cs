using BuninessLayer;
using DataLayer;
using DevExpress.Office.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraRichEdit.Import.Html;
using DevExpress.XtraSplashScreen;
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
    public partial class frmBangCongChiTiet : DevExpress.XtraEditors.XtraForm
    {
        public frmBangCongChiTiet()
        {
            InitializeComponent();
        }
        // lấy ở frmBAngCOng
        NHANVIEN _nhanvien;
        BANGCONG_NHANVIEN_CT _bangcongct;
        KYCONGCHITIET _kcct;
        public int _macty;
        public int _thang;
        public int _nam;
        public int _makycong;
        KYCONG _kycong;

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void frmBangCongChiTiet_Load(object sender, EventArgs e)
        {
            _bangcongct = new BANGCONG_NHANVIEN_CT();
            _nhanvien = new NHANVIEN();
            _kycong = new KYCONG();
            _kcct = new KYCONGCHITIET();
            gcBangCongChiTiet.DataSource = _kcct.getList(_makycong);// dùng đẻ load dữ liệu và hiển thị
            CustomView(_thang, _nam);
            cboThang.Text = _thang.ToString();
            cboNam.Text = _nam.ToString();
            gvBangCongChiTiet.OptionsBehavior.Editable = false;// ko cho viết vào form


        }

        public void loadBangCong()
        {
            _kcct = new KYCONGCHITIET();// làm mới lại dữ liệu khi cập nhật ngày phép
            gcBangCongChiTiet.DataSource = _kcct.getList(int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text));
            CustomView(int.Parse(cboThang.Text), int.Parse(cboNam.Text));
            gvBangCongChiTiet.OptionsBehavior.Editable = false;// ko cho viết vào form

        }

        private void gcBangCongChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void btnPhatSinhKyCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaitint), true, true);

            // kiểm tra mã kỳ công  xem phát sinh hay chưa
            if (_kycong.KiemtraPhatSinhKyCong(int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text)))
            {
                MessageBox.Show("Kỳ công đã được phát sinh", "Thông báo");
                SplashScreenManager.CloseForm();
                return;
            }
            // lấy danh sách nhân viên
            List<tb_NHANVIEN> lstnhanhvien = _nhanvien.getList();

         
            _kcct.phatSinhKyCongChiTiet (_macty, int.Parse(cboThang.Text), int.Parse(cboNam.Text)); // truyền vào các tham só

            // sau khi phát sinh kỳ công theo mã kỳ công thì thêm db vào bảng bảng công nhân viên chi tiết
           
            foreach(var item in lstnhanhvien)
            {
                // add ngày công trong tháng cho mỗi nhân viên
                for (int i = 1; i <= GetDayNumber(int.Parse(cboThang.Text), int.Parse(cboNam.Text)); i++)
                {
                    tb_BANGCONG_NHANVIEN_CT bcct = new tb_BANGCONG_NHANVIEN_CT();
                    bcct.MANV = item.MANV;
                    bcct.MACTY = item.MACTY;
                    bcct.HOTEN = item.HOTEN;
                    bcct.GIOVAO = "08:00";
                    bcct.GIORA = "17:00";
                    bcct.NGAY = DateTime.Parse (cboNam.Text + " - " + cboThang.Text + " - " + i.ToString());
                    bcct.THU = HAMDUNGCHUNG_functions.layThuTrongTuan( int.Parse(cboNam.Text), int.Parse(cboThang.Text), i);
                    bcct.NGAYPHEP = 0;
                    bcct.CONGNGAYLE = 0;
                    bcct.CONGCHUNHAT = 0;

                    if (bcct.THU == "Chủ nhật")
                    {
                        bcct.KYHIEU = "CN";
                        bcct.NGAYCONG = 0;
                    }
                    else
                    {
                        bcct.KYHIEU = "X";
                        bcct.NGAYCONG = 1;
                    }
                    

                    bcct.MAKYCONG = _makycong;
                    bcct.CREATED_DATE = DateTime.Now;
                    bcct.CREATED_BY = 1;
                    _bangcongct.Add(bcct);
                }
            }

            SplashScreenManager.CloseForm();
            var kc= _kycong.getItem(int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text)); // khi có kỳ công rồi update trạng thái thành true, dòng 68,69
            kc.TRANGTHAI = true;

            _kycong.Update(kc);
            loadBangCong();

        }

        private void btnXemBangCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadBangCong();
        }

        private void btnIN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadBangCong();
        }

        private void CustomView(int thang, int nam)
        {
            // chạy lại layout
            gvBangCongChiTiet.RestoreLayoutFromXml(Application.StartupPath + @"\layout_bangcong.xml");
            int i;
            foreach (GridColumn gridColumn in gvBangCongChiTiet.Columns)
            {
                if (gridColumn.FieldName == "HOTEN") continue;
                // ràng buộc k cho gõ số
                RepositoryItemTextEdit textEdit = new RepositoryItemTextEdit();
                textEdit.Mask.MaskType = MaskType.RegEx;
                textEdit.Mask.EditMask = @"\p{Lu}+";
                gridColumn.ColumnEdit = textEdit;
            }

            for (i = 1; i <= GetDayNumber(thang, nam); i++)
            {
                DateTime newDate = new DateTime(nam, thang, i);

                GridColumn column = new GridColumn();
                column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                string fieldName = "D" + i;
                switch (newDate.DayOfWeek.ToString())
                {
                    case "Monday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Hai " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        //column.Width = 30;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        break;

                    case "Tuesday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Ba " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        //column.Width = 30;
                        break;

                    case "Wednesday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Tư " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        //column.Width = 30;
                        break;
                    case "Thursday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Năm " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        //column.Width = 30;
                        break;
                    case "Friday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Sáu " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        //column.Width = 30;
                        break;
                    case "Saturday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Bảy " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Red;
                        column.AppearanceHeader.BackColor = Color.Violet;
                        column.AppearanceHeader.BackColor2 = Color.Violet;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Khaki;
                        column.OptionsColumn.AllowFocus = true;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        //column.Width = 30;
                        break;
                    case "Sunday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "CN " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = false;
                        column.AppearanceHeader.ForeColor = Color.Red;
                        column.AppearanceHeader.BackColor = Color.GreenYellow;
                        column.AppearanceHeader.BackColor2 = Color.GreenYellow;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Orange;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        //column.Width = 30;
                        //column.OptionsColumn.AllowFocus = false;
                        break;
                }
            }
            // ẩn cột trông nếu tháng ko đủ ngày 
            while (i <= 31)
            {
                // vd có 28 ngày thì ẩn cột ngày 29 30 31
                gvBangCongChiTiet.Columns[i + 1].Visible = false;
                i++;
            }

        }
        // lấy ngày của tháng
        private int GetDayNumber(int thang, int nam)
        {
            int dayNumber = 0;
            switch (thang)
            {
                case 2:
                    dayNumber = (nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0 ? 29 : 28;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    dayNumber = 30;
                    break;

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dayNumber = 31;
                    break;
            }

            return dayNumber;
        }

        private void bntHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcBangCongChiTiet_Click_1(object sender, EventArgs e)
        {

        }

        private void mnCapNhatNgayCong_Click(object sender, EventArgs e)
        {
            frmCAPNHAPNGAYCONG frm = new frmCAPNHAPNGAYCONG();
            frm._makycong = _makycong;
            frm._manv =int.Parse (gvBangCongChiTiet.GetFocusedRowCellValue("MANV").ToString());
            frm._hoten = gvBangCongChiTiet.GetFocusedRowCellValue("HOTEN").ToString();
            frm._ngay = gvBangCongChiTiet.FocusedColumn.FieldName.ToString();// lấy tên cột colum
            frm.ShowDialog();
        }

        private void gvBangCongChiTiet_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if ( e.CellValue == null )
            {

            }
            else
            {
                if (e.CellValue.ToString()=="CT")
                {
                    e.Appearance.BackColor = Color.DarkGreen;
                    e.Appearance.ForeColor = Color.White;
                }

                if (e.CellValue.ToString() == "VR")
                {
                    e.Appearance.BackColor = Color.Violet;
                    e.Appearance.ForeColor = Color.White;
                }

                if (e.CellValue.ToString() == "P")
                {
                    e.Appearance.BackColor = Color.Silver;
                    e.Appearance.ForeColor = Color.White;
                }

                if (e.CellValue.ToString() == "V")
                {
                    e.Appearance.BackColor = Color.Brown;
                    e.Appearance.ForeColor = Color.White;
                }

            }
        }
    }
}