using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BuninessLayer
{
    public class TONGIAO
    {
        QLNHANVIENEntities db = new QLNHANVIENEntities();
        public tb_TONGIAO getItem(int ID)
        {
            return db.tb_TONGIAO.FirstOrDefault(x => x.ID == ID);
        }
        public List<tb_TONGIAO> getList()
        {
            return db.tb_TONGIAO.ToList();
        }

        public tb_TONGIAO Add(tb_TONGIAO dt)
        {
            try
            {
                db.tb_TONGIAO.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }

        public tb_TONGIAO update(tb_TONGIAO dt)
        {
            try
            {
                var _dt = db.tb_TONGIAO.FirstOrDefault(x => x.ID == dt.ID);
                _dt.TENTG = dt.TENTG;
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
                var _dt = db.tb_TONGIAO.FirstOrDefault(x => x.ID == id);
                db.tb_TONGIAO.Remove(_dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }
    }
}

