using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuninessLayer
{
    public class TAIKHOAN
    {
        QLNHANVIENEntities db = new QLNHANVIENEntities();
        public tb_tblTaiKhoan getItem(string ID)
        {
            return db.tb_tblTaiKhoan.FirstOrDefault(x => x.Ten_TKhoan == ID);
        }
        public List<tb_tblTaiKhoan> getList()
        {
            return db.tb_tblTaiKhoan.ToList();
        }

        public tb_tblTaiKhoan Add(tb_tblTaiKhoan dt)
        {
            try
            {
                db.tb_tblTaiKhoan.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }

        public tb_tblTaiKhoan update(tb_tblTaiKhoan dt)
        {
            try
            {
                var _dt = db.tb_tblTaiKhoan.FirstOrDefault(x => x.Ten_TKhoan == dt.Ten_TKhoan);
                _dt.Ten_TKhoan = dt.Ten_TKhoan;
                _dt.Loai_TKhoan = dt.Loai_TKhoan;
                _dt.Mat_Khau = dt.Mat_Khau;
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }

        public void Delete(string id)
        {

            try
            {
                var _dt = db.tb_tblTaiKhoan.FirstOrDefault(x => x.Ten_TKhoan == id);
                db.tb_tblTaiKhoan.Remove(_dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }
    }
}
