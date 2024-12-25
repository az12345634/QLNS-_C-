using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuninessLayer
{
    public class CONGTY
    {
        QLNHANVIENEntities db = new QLNHANVIENEntities();
        public tb_CONGTY getItem(int ID)
        {
            return db.tb_CONGTY.FirstOrDefault(x => x.MACTY == ID);
        }
        public List<tb_CONGTY> getList()
        {
            return db.tb_CONGTY.ToList();
        }

        public tb_CONGTY Add(tb_CONGTY dt)
        {
            try
            {
                db.tb_CONGTY.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }

        public tb_CONGTY update(tb_CONGTY dt)
        {
            try
            {
                var _dt = db.tb_CONGTY.FirstOrDefault(x => x.MACTY == dt.MACTY);
                _dt.TENCTY = dt.TENCTY;
                _dt.DIACHI = dt.DIACHI;
                _dt.DIENTHOAI = dt.DIENTHOAI;
                _dt.EMAIL = dt.EMAIL;
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }

        public void Delete(int id)
        {

            try
            {
                var _dt = db.tb_CONGTY.FirstOrDefault(x => x.MACTY == id);
                db.tb_CONGTY.Remove(_dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }
    }
}