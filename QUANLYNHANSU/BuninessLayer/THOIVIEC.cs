using BuninessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuninessLayer
{
    public class THOIVIEC
    {
        QLNHANVIENEntities db = new QLNHANVIENEntities();
        public tb_THOIVIEC getItem(string soqd)
        {
            return db.tb_THOIVIEC.FirstOrDefault(x=>x.SOQD==soqd);
        }
        public List<tb_THOIVIEC> getList() 
        {
            return db.tb_THOIVIEC.ToList();
        }
        public tb_THOIVIEC Add(tb_THOIVIEC tv)
        {
            try
            {
                db.tb_THOIVIEC.Add(tv);
                db.SaveChanges();
                return tv;
            }catch (Exception ex) 
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public List<THOIVIEC_DTO> getListFull()
        {
            var lst = db.tb_THOIVIEC.ToList();
            List<THOIVIEC_DTO> lstDTO = new List<THOIVIEC_DTO>();
            THOIVIEC_DTO dto;
            // lặp danh sách
            foreach (var item in lst)
            {
                dto = new THOIVIEC_DTO();
                dto.SOQD = item.SOQD;
                dto.NGAYNOPDON = item.NGAYNOPDON;
                dto.NGAYNGHI = item.NGAYNGHI;       
                dto.MANV = item.MANV;
                dto.LYDO=item.LYDO;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                dto.HOTEN = nv.HOTEN;
                dto.GHICHU = item.GHICHU;
                dto.CREATED_BY = item.CREATED_BY;
                dto.CREATED_DATE = item.CREATED_DATE;
                dto.UPDATE_BY = item.UPDATE_BY;
                dto.UPDATE_DATE = item.UPDATE_DATE;
                dto.DELETED_BY = item.DELETED_BY;
                dto.DELETED_DATE = item.DELETED_DATE;
                lstDTO.Add(dto);

            }
            return lstDTO;
        }

        public tb_THOIVIEC Update(tb_THOIVIEC tv)
        {
            try
            {
               var _tv= db.tb_THOIVIEC.FirstOrDefault(x => x.SOQD == tv.SOQD);
                _tv.NGAYNOPDON = tv.NGAYNOPDON;
                _tv.NGAYNGHI = tv.NGAYNGHI;
                _tv.MANV = tv.MANV;
                _tv.LYDO= tv.LYDO;
                _tv.GHICHU= tv.GHICHU;
                _tv.UPDATE_BY = tv.UPDATE_BY;
                _tv.UPDATE_DATE = tv.UPDATE_DATE;
                db.SaveChanges();
                return tv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(string soqd, int iduser)
        {
            try
            {
                var _tv = db.tb_THOIVIEC.FirstOrDefault(x => x.SOQD == soqd);
                
                _tv.DELETED_BY = iduser;
                _tv.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
               
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public string MaxSoQuyetDinh()
        {
            // LẤY RA CÁC LOẠI VÀ LẤY SỐ ĐẦU TIÊN RA
            var _hd = db.tb_THOIVIEC.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_hd != null)
            {
                // nếu có thì lấy hợp đồng
                return _hd.SOQD;
            }
            else
                return "00000";
        }

    }
}
