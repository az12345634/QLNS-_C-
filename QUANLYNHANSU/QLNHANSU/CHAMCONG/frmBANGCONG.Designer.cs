namespace QLNHANSU.CHAMCONG
{
    partial class frmBANGCONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBANGCONG));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.bntSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemBangCong = new DevExpress.XtraBars.BarButtonItem();
            this.bntHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnIN = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkTRANGTHAI = new System.Windows.Forms.CheckBox();
            this.chkKhoa = new System.Windows.Forms.CheckBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAKYCONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYTINHCONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYCONGTRONGTHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRANGTHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DELETED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.bntHuy,
            this.btnDong,
            this.btnIN,
            this.bntSua,
            this.barButtonItem1,
            this.btnXemBangCong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 12;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bntSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXemBangCong, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bntHuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIN, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // bntSua
            // 
            this.bntSua.Caption = "Sửa";
            this.bntSua.Id = 9;
            this.bntSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntSua.ImageOptions.Image")));
            this.bntSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bntSua.ImageOptions.LargeImage")));
            this.bntSua.Name = "bntSua";
            this.bntSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnXemBangCong
            // 
            this.btnXemBangCong.Caption = "Xem bảng công";
            this.btnXemBangCong.Id = 11;
            this.btnXemBangCong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemBangCong.ImageOptions.Image")));
            this.btnXemBangCong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXemBangCong.ImageOptions.LargeImage")));
            this.btnXemBangCong.Name = "btnXemBangCong";
            this.btnXemBangCong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXemBangCong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemBangCong_ItemClick);
            // 
            // bntHuy
            // 
            this.bntHuy.Caption = "Hủy";
            this.bntHuy.Id = 4;
            this.bntHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntHuy.ImageOptions.Image")));
            this.bntHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bntHuy.ImageOptions.LargeImage")));
            this.bntHuy.Name = "bntHuy";
            this.bntHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntHuy_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1440, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 491);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1440, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 461);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1440, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 461);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Xem bảng công";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(28, 121);
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
            this.splitContainer1.Panel1.Controls.Add(this.chkTRANGTHAI);
            this.splitContainer1.Panel1.Controls.Add(this.chkKhoa);
            this.splitContainer1.Panel1.Controls.Add(this.cboThang);
            this.splitContainer1.Panel1.Controls.Add(this.cboNam);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1440, 461);
            this.splitContainer1.SplitterDistance = 398;
            this.splitContainer1.TabIndex = 6;
            // 
            // chkTRANGTHAI
            // 
            this.chkTRANGTHAI.AutoSize = true;
            this.chkTRANGTHAI.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chkTRANGTHAI.Location = new System.Drawing.Point(206, 169);
            this.chkTRANGTHAI.Name = "chkTRANGTHAI";
            this.chkTRANGTHAI.Size = new System.Drawing.Size(108, 25);
            this.chkTRANGTHAI.TabIndex = 9;
            this.chkTRANGTHAI.Text = "Trạng thái";
            this.chkTRANGTHAI.UseVisualStyleBackColor = true;
            // 
            // chkKhoa
            // 
            this.chkKhoa.AutoSize = true;
            this.chkKhoa.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chkKhoa.Location = new System.Drawing.Point(102, 169);
            this.chkKhoa.Name = "chkKhoa";
            this.chkKhoa.Size = new System.Drawing.Size(69, 25);
            this.chkKhoa.TabIndex = 8;
            this.chkKhoa.Text = "Khóa";
            this.chkKhoa.UseVisualStyleBackColor = true;
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
            this.cboThang.Location = new System.Drawing.Point(102, 118);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(226, 29);
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
            "2027",
            "2028"});
            this.cboNam.Location = new System.Drawing.Point(102, 56);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(226, 29);
            this.cboNam.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(40, 59);
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
            this.gcDanhSach.Size = new System.Drawing.Size(1038, 461);
            this.gcDanhSach.TabIndex = 5;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAKYCONG,
            this.THANG,
            this.NAM,
            this.KHOA,
            this.NGAYTINHCONG,
            this.NGAYCONGTRONGTHANG,
            this.TRANGTHAI,
            this.DELETED_BY});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // MAKYCONG
            // 
            this.MAKYCONG.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MAKYCONG.AppearanceCell.Options.UseFont = true;
            this.MAKYCONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MAKYCONG.AppearanceHeader.Options.UseFont = true;
            this.MAKYCONG.Caption = "MÃ KỲ CÔNG";
            this.MAKYCONG.FieldName = "MAKYCONG";
            this.MAKYCONG.MaxWidth = 150;
            this.MAKYCONG.MinWidth = 150;
            this.MAKYCONG.Name = "MAKYCONG";
            this.MAKYCONG.Visible = true;
            this.MAKYCONG.VisibleIndex = 0;
            this.MAKYCONG.Width = 150;
            // 
            // THANG
            // 
            this.THANG.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.THANG.AppearanceCell.Options.UseFont = true;
            this.THANG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.THANG.AppearanceHeader.Options.UseFont = true;
            this.THANG.Caption = "THÁNG";
            this.THANG.FieldName = "THANG";
            this.THANG.MaxWidth = 80;
            this.THANG.MinWidth = 80;
            this.THANG.Name = "THANG";
            this.THANG.Visible = true;
            this.THANG.VisibleIndex = 1;
            this.THANG.Width = 80;
            // 
            // NAM
            // 
            this.NAM.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NAM.AppearanceCell.Options.UseFont = true;
            this.NAM.Caption = "NĂM";
            this.NAM.FieldName = "NAM";
            this.NAM.MaxWidth = 100;
            this.NAM.MinWidth = 100;
            this.NAM.Name = "NAM";
            this.NAM.Visible = true;
            this.NAM.VisibleIndex = 2;
            this.NAM.Width = 100;
            // 
            // KHOA
            // 
            this.KHOA.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.KHOA.AppearanceCell.Options.UseFont = true;
            this.KHOA.Caption = "KHÓA";
            this.KHOA.FieldName = "KHOA";
            this.KHOA.MaxWidth = 50;
            this.KHOA.MinWidth = 50;
            this.KHOA.Name = "KHOA";
            this.KHOA.Visible = true;
            this.KHOA.VisibleIndex = 3;
            this.KHOA.Width = 50;
            // 
            // NGAYTINHCONG
            // 
            this.NGAYTINHCONG.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NGAYTINHCONG.AppearanceCell.Options.UseFont = true;
            this.NGAYTINHCONG.Caption = "NGÀY TÍNH CÔNG";
            this.NGAYTINHCONG.FieldName = "NGAYTINHCONG";
            this.NGAYTINHCONG.MaxWidth = 125;
            this.NGAYTINHCONG.MinWidth = 125;
            this.NGAYTINHCONG.Name = "NGAYTINHCONG";
            this.NGAYTINHCONG.Visible = true;
            this.NGAYTINHCONG.VisibleIndex = 4;
            this.NGAYTINHCONG.Width = 125;
            // 
            // NGAYCONGTRONGTHANG
            // 
            this.NGAYCONGTRONGTHANG.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NGAYCONGTRONGTHANG.AppearanceCell.Options.UseFont = true;
            this.NGAYCONGTRONGTHANG.Caption = "NGÀY CÔNG TRONG THÁNG";
            this.NGAYCONGTRONGTHANG.FieldName = "NGAYCONGTRONGTHANG";
            this.NGAYCONGTRONGTHANG.MaxWidth = 200;
            this.NGAYCONGTRONGTHANG.MinWidth = 200;
            this.NGAYCONGTRONGTHANG.Name = "NGAYCONGTRONGTHANG";
            this.NGAYCONGTRONGTHANG.Visible = true;
            this.NGAYCONGTRONGTHANG.VisibleIndex = 5;
            this.NGAYCONGTRONGTHANG.Width = 200;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TRANGTHAI.AppearanceCell.Options.UseFont = true;
            this.TRANGTHAI.Caption = "TRẠNG THÁI";
            this.TRANGTHAI.FieldName = "TRANGTHAI";
            this.TRANGTHAI.MaxWidth = 125;
            this.TRANGTHAI.MinWidth = 125;
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Visible = true;
            this.TRANGTHAI.VisibleIndex = 6;
            this.TRANGTHAI.Width = 125;
            // 
            // DELETED_BY
            // 
            this.DELETED_BY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.DELETED_BY.AppearanceCell.Options.UseFont = true;
            this.DELETED_BY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.DELETED_BY.AppearanceHeader.Options.UseFont = true;
            this.DELETED_BY.Caption = "XÓA";
            this.DELETED_BY.FieldName = "DELETED_BY";
            this.DELETED_BY.MaxWidth = 50;
            this.DELETED_BY.MinWidth = 50;
            this.DELETED_BY.Name = "DELETED_BY";
            this.DELETED_BY.Visible = true;
            this.DELETED_BY.VisibleIndex = 7;
            this.DELETED_BY.Width = 50;
            // 
            // frmBANGCONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 511);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBANGCONG";
            this.Text = "Bảng công";
            this.Load += new System.EventHandler(this.frmBANGCONG_Load);
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
        private DevExpress.XtraBars.BarButtonItem btnThem;
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
        private System.Windows.Forms.CheckBox chkKhoa;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNam;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn MAKYCONG;
        private DevExpress.XtraGrid.Columns.GridColumn THANG;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraGrid.Columns.GridColumn NAM;
        private DevExpress.XtraGrid.Columns.GridColumn KHOA;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYTINHCONG;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYCONGTRONGTHANG;
        private DevExpress.XtraGrid.Columns.GridColumn TRANGTHAI;
        private DevExpress.XtraGrid.Columns.GridColumn DELETED_BY;
        private System.Windows.Forms.CheckBox chkTRANGTHAI;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnXemBangCong;
    }
}