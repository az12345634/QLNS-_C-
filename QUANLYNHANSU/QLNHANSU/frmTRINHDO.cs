﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuninessLayer;
using DataLayer;
namespace QLNHANSU
{
    public partial class frmTRINHDO : DevExpress.XtraEditors.XtraForm
    {
        public frmTRINHDO()
        {
            InitializeComponent();
        }
        TRINHDO _trinhdo;
        bool _them;
        int _id;
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            bntHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIN.Enabled = kt;
            txtTen.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _trinhdo.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }


        private void frmTest_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            _trinhdo = new TRINHDO();
            loadData();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            // tự động lấy id
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDTD").ToString());
            // khi nhấp vào tên dân tộc, nó hiển thị lên 
            txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENTD").ToString();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            txtTen.Text = string.Empty;
        }

        private void bntSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _trinhdo.Delete(_id);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _showHide(true);
            _them = false;
        }

        void SaveData()
        {
            if (_them)
            {
                tb_TRINHDO dt = new tb_TRINHDO();
                dt.TENTD = txtTen.Text;
                _trinhdo.Add(dt);

            }
            else
            {
                var dt = _trinhdo.getItem(_id);
                dt.TENTD = txtTen.Text;
                _trinhdo.update(dt);
            }
        }

        private void bntHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(true);
            _them = false;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnIN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}