using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BuninessLayer
{
    public class TRINHDO
    {
        QLNHANVIENEntities db = new QLNHANVIENEntities();
        public tb_TRINHDO getItem(int ID)
        {
            return db.tb_TRINHDO.FirstOrDefault(x => x.IDTD == ID);
        }
        public List<tb_TRINHDO> getList()
        {
            return db.tb_TRINHDO.ToList();
        }

        public tb_TRINHDO Add(tb_TRINHDO dt)
        {
            try
            {
                db.tb_TRINHDO.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }

        public tb_TRINHDO update(tb_TRINHDO dt)
        {
            try
            {
                var _dt = db.tb_TRINHDO.FirstOrDefault(x => x.IDTD == dt.IDTD);
                _dt.TENTD = dt.TENTD;
                
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
                var _dt = db.tb_TRINHDO.FirstOrDefault(x => x.IDTD == id);
                db.tb_TRINHDO.Remove(_dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }
    }
}
