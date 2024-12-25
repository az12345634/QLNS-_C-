namespace QLNHANSU.TINHLUONG
{
    partial class frmTANGCA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTANGCA));
            this.IDLOAICA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOGIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOAICA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HESO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DELETED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.bntSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.bntHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnIN = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.TENCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboLoaica = new System.Windows.Forms.ComboBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lkNhanVien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.spSoGio = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSoGio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDLOAICA
            // 
            this.IDLOAICA.Caption = "IDLC";
            this.IDLOAICA.FieldName = "IDLOAICA";
            this.IDLOAICA.MinWidth = 25;
            this.IDLOAICA.Name = "IDLOAICA";
            this.IDLOAICA.Width = 94;
            // 
            // MANV
            // 
            this.MANV.Caption = "Mã Nhân Viên";
            this.MANV.FieldName = "MANV";
            this.MANV.MinWidth = 25;
            this.MANV.Name = "MANV";
            this.MANV.Width = 434;
            // 
            // GHICHU
            // 
            this.GHICHU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.GHICHU.AppearanceHeader.Options.UseFont = true;
            this.GHICHU.Caption = "Ghi Chú";
            this.GHICHU.FieldName = "GHICHU";
            this.GHICHU.MaxWidth = 300;
            this.GHICHU.MinWidth = 200;
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.Visible = true;
            this.GHICHU.VisibleIndex = 5;
            this.GHICHU.Width = 200;
            // 
            // SOGIO
            // 
            this.SOGIO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.SOGIO.AppearanceHeader.Options.UseFont = true;
            this.SOGIO.Caption = "Số Giờ";
            this.SOGIO.FieldName = "SOGIO";
            this.SOGIO.MaxWidth = 100;
            this.SOGIO.MinWidth = 80;
            this.SOGIO.Name = "SOGIO";
            this.SOGIO.Visible = true;
            this.SOGIO.VisibleIndex = 2;
            this.SOGIO.Width = 80;
            // 
            // TENLOAICA
            // 
            this.TENLOAICA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TENLOAICA.AppearanceHeader.Options.UseFont = true;
            this.TENLOAICA.Caption = "Loại ca";
            this.TENLOAICA.FieldName = "TENLOAICA";
            this.TENLOAICA.MaxWidth = 170;
            this.TENLOAICA.MinWidth = 120;
            this.TENLOAICA.Name = "TENLOAICA";
            this.TENLOAICA.Visible = true;
            this.TENLOAICA.VisibleIndex = 1;
            this.TENLOAICA.Width = 120;
            // 
            // HOTENNV
            // 
            this.HOTENNV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.HOTENNV.AppearanceHeader.Options.UseFont = true;
            this.HOTENNV.Caption = "Họ Tên";
            this.HOTENNV.FieldName = "HOTEN";
            this.HOTENNV.MaxWidth = 200;
            this.HOTENNV.MinWidth = 200;
            this.HOTENNV.Name = "HOTENNV";
            this.HOTENNV.Visible = true;
            this.HOTENNV.VisibleIndex = 0;
            this.HOTENNV.Width = 200;
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
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.HOTENNV,
            this.TENLOAICA,
            this.SOGIO,
            this.HESO,
            this.SOTIEN,
            this.GHICHU,
            this.MANV,
            this.DELETED_BY,
            this.IDLOAICA});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // HESO
            // 
            this.HESO.Caption = "Hệ Số";
            this.HESO.FieldName = "HESO";
            this.HESO.MaxWidth = 50;
            this.HESO.MinWidth = 70;
            this.HESO.Name = "HESO";
            this.HESO.Visible = true;
            this.HESO.VisibleIndex = 3;
            this.HESO.Width = 70;
            // 
            // SOTIEN
            // 
            this.SOTIEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.SOTIEN.AppearanceHeader.Options.UseFont = true;
            this.SOTIEN.Caption = "Số Tiền";
            this.SOTIEN.DisplayFormat.FormatString = "n0";
            this.SOTIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.SOTIEN.FieldName = "SOTIEN";
            this.SOTIEN.MaxWidth = 80;
            this.SOTIEN.MinWidth = 125;
            this.SOTIEN.Name = "SOTIEN";
            this.SOTIEN.Visible = true;
            this.SOTIEN.VisibleIndex = 4;
            this.SOTIEN.Width = 125;
            // 
            // DELETED_BY
            // 
            this.DELETED_BY.Caption = "Xoá";
            this.DELETED_BY.FieldName = "DELETED_BY";
            this.DELETED_BY.MaxWidth = 50;
            this.DELETED_BY.MinWidth = 50;
            this.DELETED_BY.Name = "DELETED_BY";
            this.DELETED_BY.Visible = true;
            this.DELETED_BY.VisibleIndex = 6;
            this.DELETED_BY.Width = 50;
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(937, 346);
            this.gcDanhSach.TabIndex = 5;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bntSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.barDockControlTop.Size = new System.Drawing.Size(1339, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 376);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1339, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 346);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1339, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 346);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            // 
            // TENCV
            // 
            this.TENCV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TENCV.AppearanceHeader.Options.UseFont = true;
            this.TENCV.Caption = "Chức Vụ";
            this.TENCV.FieldName = "TENCV";
            this.TENCV.Name = "TENCV";
            this.TENCV.Visible = true;
            this.TENCV.VisibleIndex = 2;
            this.TENCV.Width = 100;
            // 
            // HOTEN
            // 
            this.HOTEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.HOTEN.AppearanceHeader.Options.UseFont = true;
            this.HOTEN.Caption = "Họ Tên";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            this.HOTEN.Width = 222;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 66;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.HOTEN,
            this.TENCV});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cboLoaica
            // 
            this.cboLoaica.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboLoaica.FormattingEnabled = true;
            this.cboLoaica.Location = new System.Drawing.Point(129, 111);
            this.cboLoaica.Name = "cboLoaica";
            this.cboLoaica.Size = new System.Drawing.Size(213, 29);
            this.cboLoaica.TabIndex = 13;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtNoiDung.Location = new System.Drawing.Point(129, 207);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(213, 28);
            this.txtNoiDung.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(55, 214);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 21);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Ghi chú";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(55, 114);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 21);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Loại ca";
            // 
            // lkNhanVien
            // 
            this.lkNhanVien.Location = new System.Drawing.Point(129, 60);
            this.lkNhanVien.MenuManager = this.barManager1;
            this.lkNhanVien.Name = "lkNhanVien";
            this.lkNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lkNhanVien.Properties.Appearance.Options.UseFont = true;
            this.lkNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNhanVien.Properties.PopupView = this.searchLookUpEdit1View;
            this.lkNhanVien.Size = new System.Drawing.Size(213, 26);
            this.lkNhanVien.TabIndex = 8;
            // 
            // spSoGio
            // 
            this.spSoGio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spSoGio.Location = new System.Drawing.Point(129, 157);
            this.spSoGio.MenuManager = this.barManager1;
            this.spSoGio.Name = "spSoGio";
            this.spSoGio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.spSoGio.Properties.Appearance.Options.UseFont = true;
            this.spSoGio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spSoGio.Size = new System.Drawing.Size(213, 28);
            this.spSoGio.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(62, 160);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 21);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Số giờ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(40, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 21);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Nhân viên";
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
            this.splitContainer1.Panel1.Controls.Add(this.cboLoaica);
            this.splitContainer1.Panel1.Controls.Add(this.txtNoiDung);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.lkNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.spSoGio);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1339, 346);
            this.splitContainer1.SplitterDistance = 398;
            this.splitContainer1.TabIndex = 7;
            // 
            // frmTANGCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 396);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTANGCA";
            this.Text = "Tăng ca";
            this.Load += new System.EventHandler(this.frmTANGCA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSoGio.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn IDLOAICA;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn GHICHU;
        private DevExpress.XtraGrid.Columns.GridColumn SOGIO;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOAICA;
        private DevExpress.XtraGrid.Columns.GridColumn HOTENNV;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn DELETED_BY;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
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
        private System.Windows.Forms.ComboBox cboLoaica;
        private System.Windows.Forms.TextBox txtNoiDung;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit lkNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn TENCV;
        private DevExpress.XtraEditors.SpinEdit spSoGio;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraGrid.Columns.GridColumn HESO;
        private DevExpress.XtraGrid.Columns.GridColumn SOTIEN;
    }
}