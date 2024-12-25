using BuninessLayer.DTO;
using DevExpress.XtraReports.Serialization;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNHANSU.Reports
{
    public partial class rptDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachNhanVien()
        {
            InitializeComponent();
        }
        //o vờ roai lại phương thức
        // biến hứng dữ liệu
        List<NHANVIEN_DTO> _lstNV;
        public rptDanhSachNhanVien(List<NHANVIEN_DTO> lstNV)
        {
            InitializeComponent();
            //Lấy dữ liệu ra
            this._lstNV = lstNV;
            // load dữ liệu lên 
            this.DataSource = lstNV; //gán data source cho reports
            loadData();
        }
        // lấy dữ liệu cho contoll( nội dung các trg)
        void loadData()
        {
            lblMaNV.DataBindings.Add("Text", _lstNV, "MANV");
            lblHoTen.DataBindings.Add("Text", _lstNV, "HOTEN");
            lblGioiTinh.DataBindings.Add("Text", _lstNV, "GIOITINH");
            lblNgaySinh.DataBindings.Add("Text", _lstNV, "NGAYSINH");
            lblCCCD.DataBindings.Add("Text", _lstNV, "CCCD");
            lblDienThoai.DataBindings.Add("Text", _lstNV, "DIENTHOAI");
            lblPhongBan.DataBindings.Add("Text", _lstNV, "TENPB");
            lblChucVu.DataBindings.Add("Text", _lstNV, "TENCV");
            lblTrinhDO.DataBindings.Add("Text", _lstNV, "TENTD");
            lblTonGiao.DataBindings.Add("Text", _lstNV, "TENTG");
            lblDANTOC.DataBindings.Add("Text", _lstNV, "TENDT");
            lblDiaChi.DataBindings.Add("Text", _lstNV, "DIACHI");


        }
    }
}
