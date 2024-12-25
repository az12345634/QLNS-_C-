using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuninessLayer
{
    public class CHUCVU
    {
        QLNHANVIENEntities db = new QLNHANVIENEntities();
        public tb_CHUCVU getItem(int ID)
        {
            return db.tb_CHUCVU.FirstOrDefault(x => x.IDCV == ID);
        }
        public List<tb_CHUCVU> getList()
        {
            return db.tb_CHUCVU.ToList();
        }

        public tb_CHUCVU Add(tb_CHUCVU dt)
        {
            try
            {
                db.tb_CHUCVU.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }

        public tb_CHUCVU update(tb_CHUCVU dt)
        {
            try
            {
                var _dt = db.tb_CHUCVU.FirstOrDefault(x => x.IDCV == dt.IDCV);
                _dt.TENCV = dt.TENCV;
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
                var _dt = db.tb_CHUCVU.FirstOrDefault(x => x.IDCV == id);
                db.tb_CHUCVU.Remove(_dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }
    }
}
