using BuninessLayer.DTO;
using DataLayer;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuninessLayer
{
    public class NHANVIEN_NANGLUONG
    {
        QLNHANVIENEntities db = new QLNHANVIENEntities();
        public tbb_NHANVIEN_NANGLUONG getItem(string soqd)
        {
            return db.tbb_NHANVIEN_NANGLUONG.FirstOrDefault(x => x.SOQD == soqd);
        }

        public List <tbb_NHANVIEN_NANGLUONG> getList( )
        {
            return db.tbb_NHANVIEN_NANGLUONG.ToList();
        }

        public List<NHANVIEN_NANGLUONG_DTO> getListFull()
        {
            var lstnl =db.tbb_NHANVIEN_NANGLUONG.ToList();
            List<NHANVIEN_NANGLUONG_DTO> lstDTO = new List<NHANVIEN_NANGLUONG_DTO>();
            NHANVIEN_NANGLUONG_DTO nlDTO;
            foreach (var item in lstnl)
            {
                nlDTO = new NHANVIEN_NANGLUONG_DTO();
                nlDTO.SOHD = item.SOHD;
                nlDTO.SOQD = item.SOQD;
                nlDTO.HESOLUONGHIENTAI = item.HESOLUONGHIENTAI;
                nlDTO.HESOLUONGMOI = item.HESOLUONGMOI;
                nlDTO.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(x=>x.MANV == item.MANV);
                nlDTO.HOTEN = nv.HOTEN;
                nlDTO.NGAYKY = item.NGAYKY;
                nlDTO.NGAYLENLUONG = item.NGAYLENLUONG;
                nlDTO.CREATE_BY = item.CREATE_BY;
                nlDTO.CREATE_DATE = item.CREATE_DATE;
                nlDTO.UPDATED_BY = item.UPDATED_BY;
                nlDTO.UPDATED_DATE = item.UPDATED_DATE;
                nlDTO.DELETED_BY = item.DELETED_BY;
                nlDTO.DELETED_DATE = item.DELETED_DATE;
                lstDTO.Add(nlDTO);
            }
            return lstDTO;
        }

        public tbb_NHANVIEN_NANGLUONG Add(tbb_NHANVIEN_NANGLUONG nl)
        {
            try
            {
                db.tbb_NHANVIEN_NANGLUONG.Add(nl);
                db.SaveChanges();
                return nl;
            }catch (Exception ex)
            {
                throw new Exception("llõi" + ex.Message);
            }

        }

        public tbb_NHANVIEN_NANGLUONG Update(tbb_NHANVIEN_NANGLUONG nl)
        {
            try
            {
                var _nl = db.tbb_NHANVIEN_NANGLUONG.FirstOrDefault(x => x.SOQD == nl.SOQD);
               _nl.SOQD = nl.SOQD;
                _nl.HESOLUONGHIENTAI = nl.HESOLUONGHIENTAI;
                _nl.HESOLUONGMOI = nl.HESOLUONGMOI;
                _nl.NGAYKY = nl.NGAYKY;
                _nl.GHICHU= nl.GHICHU;
                _nl.NGAYLENLUONG = nl.NGAYLENLUONG;
                _nl.MANV = nl.MANV;
                _nl.UPDATED_BY = nl.UPDATED_BY;
                _nl.UPDATED_DATE  = nl.UPDATED_DATE;
                db.SaveChanges();
                return nl;
            }
            catch (Exception ex)
            {
                throw new Exception("llõi" + ex.Message);
            }

        }


        public void Delete(string soqd, int uid)
        {
            try
            {
                var _nl = db.tbb_NHANVIEN_NANGLUONG.FirstOrDefault(x => x.SOQD == soqd);
                _nl.DELETED_BY = uid;
                _nl.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("llõi" + ex.Message);
            }

        }

        public string MaxSoQuyetDinh()
        {
            // LẤY RA CÁC LOẠI VÀ LẤY SỐ ĐẦU TIÊN RA
            var _hd = db.tbb_NHANVIEN_NANGLUONG.OrderByDescending(x => x.CREATE_DATE).FirstOrDefault();
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
