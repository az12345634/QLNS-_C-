using BuninessLayer.DTO;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNHANSU.Reports
{
    public partial class rptHOPDONGLAODONG : DevExpress.XtraReports.UI.XtraReport
    {
        public rptHOPDONGLAODONG()
        {
            InitializeComponent();
        }

        public rptHOPDONGLAODONG(List<HOPDONG_DTO> lstHD)
        {
            // lấy dữ liệu 
            InitializeComponent();
            this._lstHD = lstHD;
            this.DataSource = _lstHD;  
            loadDate();
        }
        List<HOPDONG_DTO> _lstHD;
        void loadDate()
        {
            // hiển thị dữ liệu
            lblSoHD.DataBindings.Add("Text", _lstHD, "SOHD");
        }
    }
}
