using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuninessLayer
{
    public class BOPHAN
    {
        QLNHANVIENEntities db = new QLNHANVIENEntities();
        public tb_BOPHAN getItem(int ID)
        {
            return db.tb_BOPHAN.FirstOrDefault(x => x.IDBP == ID);
        }
        public List<tb_BOPHAN> getList()
        {
            return db.tb_BOPHAN.ToList();
        }

        public tb_BOPHAN Add(tb_BOPHAN dt)
        {
            try
            {
                db.tb_BOPHAN.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }

        public tb_BOPHAN update(tb_BOPHAN dt)
        {
            try
            {
                var _dt = db.tb_BOPHAN.FirstOrDefault(x => x.IDBP == dt.IDBP);
                _dt.TENBP = dt.TENBP;
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
                var _dt = db.tb_BOPHAN.FirstOrDefault(x => x.IDBP == id);
                db.tb_BOPHAN.Remove(_dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(" Lỗi: " + ex.Message);
            }
        }
    }
}