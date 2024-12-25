using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuninessLayer.DTO;
using DataLayer;

namespace BuninessLayer
{
    public class KHENTHUONG_KYLUAT
    {
        QLNHANVIENEntities db = new QLNHANVIENEntities();
        public tb_KHENTHUONG_KYLLUAT getItem(string soQD)
        {
            return db.tb_KHENTHUONG_KYLLUAT.FirstOrDefault(x=>x.SOQUYETDINH==soQD);
        }

        public List<tb_KHENTHUONG_KYLLUAT> getList(int loai)
        {
            return db.tb_KHENTHUONG_KYLLUAT.Where(x => x.LOAI ==loai).ToList();
        }

        public List<KHENTHUONG_KYLUAT_DTO> getListFull(int loai)
        {
            List<tb_KHENTHUONG_KYLLUAT> lstkt = db.tb_KHENTHUONG_KYLLUAT.Where(x => x.LOAI == loai).ToList();
            List<KHENTHUONG_KYLUAT_DTO> lstDTO = new List<KHENTHUONG_KYLUAT_DTO>();
            KHENTHUONG_KYLUAT_DTO kt;
            foreach (var item in lstkt)

            // LẤY DỮ LIÊU LÊN FORM IN
            {
                kt = new KHENTHUONG_KYLUAT_DTO();
                kt.SOQUYETDINH = item.SOQUYETDINH;
                //hd.NGAYBD = "Từ ngày " + item.NGAYBD.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng" + item.NGAYBD.Value.ToString("dd/MM/yyyy").Substring(3, 2) + " năm " + item.NGAYBD.Value.ToString("dd/MM/yyyy").Substring(6);
                //hd.NGAYKT = "Từ ngày " + item.NGAYKT.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng " + item.NGAYKT.Value.ToString("dd/MM/yyyy").Substring(3, 2) + " năm " + item.NGAYKT.Value.ToString("dd/MM/yyyy").Substring(6);
                //kt.NGAYBD = item.NGAYBD.Value.ToString("dd/MM/yyyy");
                //kt.NGAYKT = item.NGAYKT.Value.ToString("dd/MM/yyyy");

                kt.TUNGAY = item.TUNGAY;
                kt.DENNGAY = item.DENNGAY;

                kt.NOIDUNG = item.NOIDUNG;
                kt.MANV = item.MANV;
                 kt.LOAI = item.LOAI;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                kt.HOTEN = nv.HOTEN;
                kt.LYDO =item.LYDO;
                kt.NGAY = item.NGAY;
               
                kt.CREATE_BY = item.CREATE_BY;
                kt.CREATE_DATE = item.CREATE_DATE;
                kt.UPDATED_BY = item.UPDATED_BY;
                kt.UPDATED_DATE = item.UPDATED_DATE;
                kt.DELETED_BY = item.DELETED_BY;
                kt.DELETED_DATE = item.DELETED_DATE;
               
                lstDTO.Add(kt);
            }
            return lstDTO;
        }

        public tb_KHENTHUONG_KYLLUAT Add( tb_KHENTHUONG_KYLLUAT kt)
        {
            try
            {
                db.tb_KHENTHUONG_KYLLUAT.Add(kt);
                db.SaveChanges();
                return kt;
            }catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public tb_KHENTHUONG_KYLLUAT Update(tb_KHENTHUONG_KYLLUAT kt)
        {
            try
            {
                tb_KHENTHUONG_KYLLUAT _kt = db.tb_KHENTHUONG_KYLLUAT.FirstOrDefault(x => x.SOQUYETDINH == kt.SOQUYETDINH);
                _kt.NGAY = kt.NGAY;
                _kt.TUNGAY = kt.TUNGAY;
                _kt.DENNGAY = kt.DENNGAY;
                _kt.LYDO= kt.LYDO;
                _kt.NOIDUNG = kt.NOIDUNG;
                _kt.LOAI= kt.LOAI;
                _kt.MANV= kt.MANV;
                _kt.UPDATED_BY = kt.UPDATED_BY;
                _kt.UPDATED_DATE = kt.UPDATED_DATE;
                db.SaveChanges();
                return kt;

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void  Delete(string soQD , int maNV)
        {
            try
            {
               tb_KHENTHUONG_KYLLUAT _kt = db.tb_KHENTHUONG_KYLLUAT.FirstOrDefault(x => x.SOQUYETDINH == soQD);
               _kt.DELETED_BY = maNV;
               _kt.DELETED_DATE =DateTime.Now ;
               db.SaveChanges();
              

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public string MaxSoQuyetDinh(int loai)
        {
            // LẤY RA CÁC LOẠI VÀ LẤY SỐ ĐẦU TIÊN RA
            var _hd = db.tb_KHENTHUONG_KYLLUAT.Where(x=>x.LOAI==loai).OrderByDescending(x => x.CREATE_DATE).FirstOrDefault();
            if (_hd != null)
            {
                // nếu có thì lấy hợp đồng
                return _hd.SOQUYETDINH;
            }
            else
                return "00000";
        }
    }
}
