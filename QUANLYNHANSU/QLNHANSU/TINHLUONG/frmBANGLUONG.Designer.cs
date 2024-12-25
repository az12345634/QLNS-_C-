namespace QLNHANSU.TINHLUONG
{
    partial class frmBANGLUONG
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBANGLUONG));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTinhLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnIN = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.bntHuy = new DevExpress.XtraBars.BarButtonItem();
            this.bntSua = new DevExpress.XtraBars.BarButtonItem();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnXembl = new DevExpress.XtraEditors.SimpleButton();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAKYCONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYCONGTRONGTHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYPHEP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYCHUNHAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYTHUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TANGCA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PHUCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UNGLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THUCLANH = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTinhLuong,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.bntHuy,
            this.btnDong,
            this.btnIN,
            this.bntSua});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar2.BarAppearance.Normal.Options.UseFont = true;
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTinhLuong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIN, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Caption = "Tính lương";
            this.btnTinhLuong.Id = 0;
            this.btnTinhLuong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTinhLuong.ImageOptions.Image")));
            this.btnTinhLuong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTinhLuong.ImageOptions.LargeImage")));
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTinhLuong_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 5;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.LargeImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // btnIN
            // 
            this.btnIN.Caption = "In";
            this.btnIN.Id = 6;
            this.btnIN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIN.ImageOptions.Image")));
            this.btnIN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnIN.ImageOptions.LargeImage")));
            this.btnIN.Name = "btnIN";
            this.btnIN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIN_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1216, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 285);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1216, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 255);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1216, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 255);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            // 
            // bntHuy
            // 
            this.bntHuy.Caption = "Hủy";
            this.bntHuy.Id = 4;
            this.bntHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntHuy.ImageOptions.Image")));
            this.bntHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bntHuy.ImageOptions.LargeImage")));
            this.bntHuy.Name = "bntHuy";
            // 
            // bntSua
            // 
            this.bntSua.Caption = "Sửa";
            this.bntSua.Id = 9;
            this.bntSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntSua.ImageOptions.Image")));
            this.bntSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bntSua.ImageOptions.LargeImage")));
            this.bntSua.Name = "bntSua";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(75, 95);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 21);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Tháng";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnXembl);
            this.splitContainer1.Panel1.Controls.Add(this.cboThang);
            this.splitContainer1.Panel1.Controls.Add(this.cboNam);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1216, 255);
            this.splitContainer1.SplitterDistance = 398;
            this.splitContainer1.TabIndex = 9;
            // 
            // btnXembl
            // 
            this.btnXembl.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnXembl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXembl.Appearance.Options.UseFont = true;
            this.btnXembl.Appearance.Options.UseForeColor = true;
            this.btnXembl.Location = new System.Drawing.Point(120, 148);
            this.btnXembl.Name = "btnXembl";
            this.btnXembl.Size = new System.Drawing.Size(147, 29);
            this.btnXembl.TabIndex = 8;
            this.btnXembl.Text = "Xem bảng lương";
            this.btnXembl.Click += new System.EventHandler(this.btnXembl_Click);
            // 
            // cboThang
            // 
            this.cboThang.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(146, 87);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(121, 29);
            this.cboThang.TabIndex = 7;
            // 
            // cboNam
            // 
            this.cboNam.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027"});
            this.cboNam.Location = new System.Drawing.Point(146, 37);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(121, 29);
            this.cboNam.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(87, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 21);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Năm";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(814, 255);
            this.gcDanhSach.TabIndex = 5;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.MAKYCONG,
            this.HOTEN,
            this.NGAYCONGTRONGTHANG,
            this.MANV,
            this.NGAYPHEP,
            this.NGAYCHUNHAT,
            this.NGAYTHUONG,
            this.TANGCA,
            this.PHUCAP,
            this.UNGLUONG,
            this.THUCLANH});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.ID.AppearanceHeader.Options.UseFont = true;
            this.ID.Caption = "ID";
            this.ID.DisplayFormat.FormatString = "n0";
            this.ID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ID.FieldName = "ID";
            this.ID.MaxWidth = 30;
            this.ID.MinWidth = 30;
            this.ID.Name = "ID";
            this.ID.Width = 30;
            // 
            // MAKYCONG
            // 
            this.MAKYCONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MAKYCONG.AppearanceHeader.Options.UseFont = true;
            this.MAKYCONG.Caption = "KỲ CÔNG";
            this.MAKYCONG.FieldName = "MAKYCONG";
            this.MAKYCONG.MaxWidth = 60;
            this.MAKYCONG.MinWidth = 80;
            this.MAKYCONG.Name = "MAKYCONG";
            this.MAKYCONG.Visible = true;
            this.MAKYCONG.VisibleIndex = 0;
            this.MAKYCONG.Width = 80;
            // 
            // HOTEN
            // 
            this.HOTEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.HOTEN.AppearanceHeader.Options.UseFont = true;
            this.HOTEN.Caption = "HỌ TÊN";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 200;
            this.HOTEN.MinWidth = 80;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            this.HOTEN.Width = 80;
            // 
            // NGAYCONGTRONGTHANG
            // 
            this.NGAYCONGTRONGTHANG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NGAYCONGTRONGTHANG.AppearanceHeader.Options.UseFont = true;
            this.NGAYCONGTRONGTHANG.Caption = "NGÀY CÔNG";
            this.NGAYCONGTRONGTHANG.FieldName = "NGAYCONGTRONGTHANG";
            this.NGAYCONGTRONGTHANG.MaxWidth = 100;
            this.NGAYCONGTRONGTHANG.MinWidth = 60;
            this.NGAYCONGTRONGTHANG.Name = "NGAYCONGTRONGTHANG";
            this.NGAYCONGTRONGTHANG.Visible = true;
            this.NGAYCONGTRONGTHANG.VisibleIndex = 2;
            this.NGAYCONGTRONGTHANG.Width = 80;
            // 
            // MANV
            // 
            this.MANV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MANV.AppearanceHeader.Options.UseFont = true;
            this.MANV.Caption = "Mã Nhân Viên";
            this.MANV.FieldName = "MANV";
            this.MANV.MaxWidth = 80;
            this.MANV.MinWidth = 50;
            this.MANV.Name = "MANV";
            this.MANV.Width = 50;
            // 
            // NGAYPHEP
            // 
            this.NGAYPHEP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NGAYPHEP.AppearanceHeader.Options.UseFont = true;
            this.NGAYPHEP.Caption = "NGÀY PHÉP";
            this.NGAYPHEP.DisplayFormat.FormatString = "n0";
            this.NGAYPHEP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.NGAYPHEP.FieldName = "NGAYPHEP";
            this.NGAYPHEP.MaxWidth = 100;
            this.NGAYPHEP.MinWidth = 60;
            this.NGAYPHEP.Name = "NGAYPHEP";
            this.NGAYPHEP.Visible = true;
            this.NGAYPHEP.VisibleIndex = 3;
            this.NGAYPHEP.Width = 80;
            // 
            // NGAYCHUNHAT
            // 
            this.NGAYCHUNHAT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NGAYCHUNHAT.AppearanceHeader.Options.UseFont = true;
            this.NGAYCHUNHAT.Caption = "NGÀY LỄ";
            this.NGAYCHUNHAT.DisplayFormat.FormatString = "n0";
            this.NGAYCHUNHAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.NGAYCHUNHAT.FieldName = "NGAYCHUNHAT";
            this.NGAYCHUNHAT.MaxWidth = 150;
            this.NGAYCHUNHAT.MinWidth = 70;
            this.NGAYCHUNHAT.Name = "NGAYCHUNHAT";
            this.NGAYCHUNHAT.Visible = true;
            this.NGAYCHUNHAT.VisibleIndex = 4;
            this.NGAYCHUNHAT.Width = 70;
            // 
            // NGAYTHUONG
            // 
            this.NGAYTHUONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NGAYTHUONG.AppearanceHeader.Options.UseFont = true;
            this.NGAYTHUONG.Caption = "NGÀY THƯỜNG";
            this.NGAYTHUONG.DisplayFormat.FormatString = "n0";
            this.NGAYTHUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.NGAYTHUONG.FieldName = "NGAYTHUONG";
            this.NGAYTHUONG.MaxWidth = 150;
            this.NGAYTHUONG.MinWidth = 60;
            this.NGAYTHUONG.Name = "NGAYTHUONG";
            this.NGAYTHUONG.Visible = true;
            this.NGAYTHUONG.VisibleIndex = 5;
            this.NGAYTHUONG.Width = 80;
            // 
            // TANGCA
            // 
            this.TANGCA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TANGCA.AppearanceHeader.Options.UseFont = true;
            this.TANGCA.Caption = "TĂNG CA";
            this.TANGCA.DisplayFormat.FormatString = "n0";
            this.TANGCA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TANGCA.FieldName = "TANGCA";
            this.TANGCA.MaxWidth = 150;
            this.TANGCA.MinWidth = 60;
            this.TANGCA.Name = "TANGCA";
            this.TANGCA.Visible = true;
            this.TANGCA.VisibleIndex = 6;
            this.TANGCA.Width = 125;
            // 
            // PHUCAP
            // 
            this.PHUCAP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.PHUCAP.AppearanceHeader.Options.UseFont = true;
            this.PHUCAP.Caption = "PHỤ CẤP";
            this.PHUCAP.DisplayFormat.FormatString = "n0";
            this.PHUCAP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.PHUCAP.FieldName = "PHUCAP";
            this.PHUCAP.MaxWidth = 150;
            this.PHUCAP.MinWidth = 100;
            this.PHUCAP.Name = "PHUCAP";
            this.PHUCAP.Visible = true;
            this.PHUCAP.VisibleIndex = 7;
            this.PHUCAP.Width = 150;
            // 
            // UNGLUONG
            // 
            this.UNGLUONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.UNGLUONG.AppearanceHeader.Options.UseFont = true;
            this.UNGLUONG.Caption = "ỨNG LƯƠNG";
            this.UNGLUONG.DisplayFormat.FormatString = "n0";
            this.UNGLUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.UNGLUONG.FieldName = "UNGLUONG";
            this.UNGLUONG.MaxWidth = 150;
            this.UNGLUONG.MinWidth = 100;
            this.UNGLUONG.Name = "UNGLUONG";
            this.UNGLUONG.Visible = true;
            this.UNGLUONG.VisibleIndex = 8;
            this.UNGLUONG.Width = 100;
            // 
            // THUCLANH
            // 
            this.THUCLANH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.THUCLANH.AppearanceHeader.Options.UseFont = true;
            this.THUCLANH.Caption = "THỰC LÃNH";
            this.THUCLANH.DisplayFormat.FormatString = "n0";
            this.THUCLANH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.THUCLANH.FieldName = "THUCLANH";
            this.THUCLANH.MaxWidth = 250;
            this.THUCLANH.MinWidth = 100;
            this.THUCLANH.Name = "THUCLANH";
            this.THUCLANH.Visible = true;
            this.THUCLANH.VisibleIndex = 9;
            this.THUCLANH.Width = 250;
            // 
            // frmBANGLUONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 305);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBANGLUONG";
            this.Text = "Bảng lương nhân viên";
            this.Load += new System.EventHandler(this.frmBANGLUONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnTinhLuong;
        private DevExpress.XtraBars.BarButtonItem bntSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem bntHuy;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarButtonItem btnIN;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn MAKYCONG;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYCONGTRONGTHANG;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNam;
        private DevExpress.XtraEditors.SimpleButton btnXembl;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYPHEP;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYCHUNHAT;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYTHUONG;
        private DevExpress.XtraGrid.Columns.GridColumn TANGCA;
        private DevExpress.XtraGrid.Columns.GridColumn PHUCAP;
        private DevExpress.XtraGrid.Columns.GridColumn THUCLANH;
        private DevExpress.XtraGrid.Columns.GridColumn UNGLUONG;
    }
}