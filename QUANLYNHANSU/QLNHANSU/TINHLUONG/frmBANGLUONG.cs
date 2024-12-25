using BuninessLayer;
using DevExpress.XtraEditors;
using QLNHANSU.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.Office.Utils;
using DataLayer;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;

namespace QLNHANSU.TINHLUONG
{
    public partial class frmBANGLUONG : DevExpress.XtraEditors.XtraForm
    {
        public frmBANGLUONG()
        {
            InitializeComponent();
        }
        List<tb_BANGLUONG> _lstBangLuong;
        int _namky;
        BANGLUONG _bangluong;

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmBANGLUONG_Load(object sender, EventArgs e)
        {
            _bangluong = new BANGLUONG();
            cboNam.Text = System.DateTime.Now.Year.ToString();
            cboThang.Text = System.DateTime.Now.Month.ToString();
        }

        private void btnTinhLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _bangluong.TinhLuongNhanVien(int.Parse(cboNam.Text) *100 + int.Parse(cboThang.Text));
            loadData();
            
        }
        void loadData()
        {
            gcDanhSach.DataSource = _bangluong.getList(int.Parse(cboNam.Text) * 100 +int.Parse(cboThang.Text));
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstBangLuong = _bangluong.getList(int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text));
            _namky = int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text);

        }
        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnIN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptBANGLUONG rpt = new rptBANGLUONG(_lstBangLuong,_namky);
            rpt.ShowPreviewDialog();
        }

        private void btnXembl_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}