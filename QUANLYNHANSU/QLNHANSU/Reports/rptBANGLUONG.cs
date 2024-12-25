using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DataLayer;
using System.Collections.Generic;
using DevExpress.Office.Utils;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;

namespace QLNHANSU.Reports
{
    public partial class rptBANGLUONG : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBANGLUONG()
        {
            InitializeComponent();
        }
        List<tb_BANGLUONG> _lst;
        int _namky;
        public rptBANGLUONG(List<tb_BANGLUONG> _lstBangLuong, int namky )
        {
            InitializeComponent();
            this._lst = _lstBangLuong;
            this._namky = namky;
            this.DataSource = _lst;
            lblThangNam.Text = "Tháng " + _namky.ToString().Substring(4) + " năm "+ _namky.ToString().Substring(0,4);
            LoadData();
        }

        void LoadData()
        {
            lblMANV.DataBindings.Add("Text", DataSource, "MANV");
            lblHOTEN.DataBindings.Add("Text", DataSource, "HOTEN");
            lblNGAYCONG.DataBindings.Add("Text", DataSource, "NGAYCONGTRONGTHANG");
            lblLUONGPHEP.DataBindings.Add("Text", DataSource, "NGAYPHEP");
            lblLUONGLE.DataBindings.Add("Text", DataSource, "NGAYLE");
            lblLUONGCN.DataBindings.Add("Text", DataSource, "NGAYCHUNHAT");
            lblTANGCA.DataBindings.Add("Text", DataSource, "TANGCA");
            lblPHUCAP.DataBindings.Add("Text", DataSource, "PHUCAP");
            lblUNGLUONG.DataBindings.Add("Text", DataSource, "UNGLUONG");
            lblLUONGNGAYTHUONG.DataBindings.Add("Text", DataSource, "NGAYTHUONG");
            lblTHUCLANH.DataBindings.Add("Text", DataSource, "THUCLANH");
      
        }

    }
}
