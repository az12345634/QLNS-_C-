using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Pdf.Native.BouncyCastle.Utilities;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using QLNHANSU.CHAMCONG;
using QLNHANSU.TINHLUONG;

namespace QLNHANSU
{
    public partial class MainFrom : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string LoaiTKhoan { get; set; }
        public MainFrom(String LoaiTKhoan)
        {


            this.IsMdiContainer = true;
            InitializeComponent();
          MessageBox.Show("LoaiTKhoan: " + LoaiTKhoan, "Thông báo");
            this.LoaiTKhoan = LoaiTKhoan;

            if (LoaiTKhoan == "0")
            {
                ribbonPage1.Visible = true;
                ribbonPage2.Visible = true;
                ribbonPage3.Visible = true;
            }
            else
            {
                ribbonPage1.Visible = false;
                ribbonPage2.Visible = true;
                ribbonPage3.Visible = true;
                
            }
        }

        //IOverlaySplashScreenHandle ShowProgressPanel(Control control, OverlayWindowOptions options)
        //{
        //    return SplashScreenManager.ShowOverlayForm(control,options);
        //}

        // khi ấn vào dân tộc, tôn giáo, nếu có rồi thì nó không tạo nữa
        void openForm(Type typForm)
        {
            foreach (var frm in MdiChildren)
            {
                if (frm.GetType() == typForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typForm);
            f.MdiParent = this;
            f.Show();
        }

        private void btnBangCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmBANGCONG));
        }
        // khi ấn vào form main, nó hiện thị các phần cùng trong main ko phải sang trang khác
        private void btnDanToc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // để show form dân tộc
            //openForm(typeof(frmDanToc));
            frmDanToc frm = new frmDanToc();
            frm.LoaiTKhoan = this.LoaiTKhoan;  // Truyền giá trị LoaiTKhoan từ MainForm vào frmDanToc

            // Kiểm tra LoaiTKhoan và ẩn các nút "Thêm", "Sửa", "Xóa" nếu LoaiTKhoan là "1"
            if (this.LoaiTKhoan == "1")
            {
                // Ẩn các nút "Thêm", "Sửa", "Xóa" trên form frmDanToc
                frm._showHide(false);  // Ẩn các nút
            }
            else
            {
                frm._showHide(true);  // Hiển thị các nút nếu LoaiTKhoan không phải "1"
            }

            frm.Show();
        }

        private void btnTonGiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // để show form dân tộc
            openForm(typeof(frmTonGiao));
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Blue";// trang dao diện muốn hiển thị lục khởi chạy
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
           skins();// load dao diện
           //Commons.handle=ShowProgressPanel (this,options);
           ribbonControl1.SelectedPage = ribbonPage2; // mặc định khi đăng nhập hiển khi form nhân sự
            // dùng đăng nhập vào hệ thống
           /* MainFrom frm = new MainFrom();*/// dùng cho form login hiển thị trên main
            //frm.ShowDialog();

           
        }

        private void btnTrinhDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmTRINHDO));
        }

        private void btnPhongBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmPhongBan));
        }

        private void btnCty_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmCongTy));
        }

        private void btnBoPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmBoPhan));
        }

        private void btnChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmChucVu));
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           openForm(typeof(frmNhanVien));
        }

        private void btnHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmHOPDONGLD));
        }

        private void BtnKhenThuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmKHENTHUONG));
        }

        private void btnThoiViec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmTHOIVIEC));
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnKyLuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmKYLUAT));
        }

        // sử dụng dụng event Form_CLosing. hiển thị thông báo khi thoát
        private void MainFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dr;
            //dr = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dr == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }

        private void btnLoaiCa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmLoaiCa));
        }

        private void btnLoaiCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmLOAICONG));
        }

        private void btnPhuCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmPHUCAP));
        }

        private void btnTangCa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmTANGCA));
        }

        private void btnUngLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmUNGLUONG));
        }

        private void btnBangLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmBANGLUONG));
        }

        private void btnNangLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmQuanLyNangLuong));
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmTaikhoan));
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(THONGKE));
        }
    }
}
