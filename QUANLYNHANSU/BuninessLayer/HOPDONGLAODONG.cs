using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BuninessLayer.DTO;
using DataLayer;
using Microsoft.SqlServer.Server;

namespace BuninessLayer
{
    public class HOPDONGLAODONG
    {
        QLNHANVIENEntities db = new QLNHANVIENEntities();
        public tb_HOPDONG getItem(string sohd)
        {
            return db.tb_HOPDONG.FirstOrDefault(x => x.SOHD == sohd);
        }
        // dùng để in hợp đồng 1 lần
        public List<HOPDONG_DTO> getItemFull(string sohd)
        {
            List<tb_HOPDONG> lstHD = db.tb_HOPDONG.Where(x=>x.SOHD==sohd).ToList();
            List<HOPDONG_DTO> lstDTO = new List<HOPDONG_DTO>();
            HOPDONG_DTO hd;
            foreach (var item in lstHD)

       // LẤY DỮ LIÊU LÊN FORM IN
            {
                hd = new HOPDONG_DTO();
                hd.SOHD = item.SOHD;
                //hd.NGAYBD = "Từ ngày " + item.NGAYBD.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng" + item.NGAYBD.Value.ToString("dd/MM/yyyy").Substring(3, 2) + " năm " + item.NGAYBD.Value.ToString("dd/MM/yyyy").Substring(6);
                //hd.NGAYKT = "Từ ngày " + item.NGAYKT.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng " + item.NGAYKT.Value.ToString("dd/MM/yyyy").Substring(3, 2) + " năm " + item.NGAYKT.Value.ToString("dd/MM/yyyy").Substring(6);
                hd.NGAYBD = item.NGAYBD.Value.ToString("dd/MM/yyyy");
                hd.NGAYKT = item.NGAYKT.Value.ToString("dd/MM/yyyy");
                hd.NGAYKY = item.NGAYKY.ToString();
              
                hd.LANKY = item.LANKY;
                hd.HESOLUONG = item.HESOLUONG;
                hd.NOIDUNG = item.NOIDUNG;
                hd.MANV = item.MANV;
                hd.THOIHAN = item.THOIHAN;
                hd.LUONGCOBAN = item.LUONGCOBAN;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                hd.HOTEN = nv.HOTEN;
                hd.CCCD = nv.CCCD;
          
                hd.NGAYSINH = nv.NGAYSINH.Value.ToString("dd/MM/yyyy");
                hd.DIENTHOAI = nv.DIENTHOAI;
                hd.DIACHI = nv.DIACHI;
                hd.CREATED_BY = item.CREATED_BY;
                hd.CREATED_DATE = item.CREATED_DATE;
                hd.UPDATE_BY = item.UPDATE_BY;
                hd.UPDATE_DATE = item.UPDATE_DATE;
                hd.DELETED_BY = item.DELETED_BY;
                hd.DELETED_DATE = item.DELETED_DATE;
                hd.MACTY = item.MACTY;
                lstDTO.Add(hd);
            }
            return lstDTO;
        }
   
        public List<tb_HOPDONG> getList()
        {
            return db.tb_HOPDONG.ToList();
        }
        // lấy dữ liệu từ nhiều bảng
        public List<HOPDONG_DTO> getListFull()
        {
            List<tb_HOPDONG> lstHD = db.tb_HOPDONG.ToList();
            List<HOPDONG_DTO> lstDTO = new List<HOPDONG_DTO>();
            HOPDONG_DTO hd;
            foreach (var item in lstHD)
            {
                hd = new HOPDONG_DTO();
                hd.SOHD = item.SOHD;
                hd.NGAYBD = item.NGAYBD.Value.ToString("dd/MM/yyyy");
                hd.NGAYKT = item.NGAYKT.Value.ToString("dd/MM/yyyy");
                //hd.NGAYBD = "Từ ngày " + item.NGAYBD.Value.ToString( "dd/MM/yyyy" ).Substring( 0, 2 ) + " tháng " +item. NGAYBD.Value.ToString( "dd/MM/yyyy" ).Substring( 3, 2 ) + " năm " +item.NGAYBD.Value.ToString( "dd/MM/yyyy" ).Substring(6);
                // hd.NGAYKT= "Từ ngày " + item.NGAYKT.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng " + item.NGAYKT.Value.ToString("dd/MM/yyyy").Substring(3, 2) + " năm " + item.NGAYKT.Value.ToString("dd/MM/yyyy").Substring(6);
                hd.NGAYKY=item.NGAYKY.ToString();
                hd.LANKY=item.LANKY;
                hd.HESOLUONG=item.HESOLUONG;
                hd.NOIDUNG=item.NOIDUNG;
                hd.MANV=item.MANV;
                hd.THOIHAN=item.THOIHAN;
                hd.LUONGCOBAN=item.LUONGCOBAN;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV== item.MANV);
                hd.HOTEN = nv.HOTEN;
                hd.CCCD = nv.CCCD;
                hd.DIENTHOAI=nv.DIENTHOAI;
                hd.DIACHI=nv.DIACHI;
                
                hd.NGAYSINH = nv.NGAYSINH.Value.ToString("dd/MM/yyyy");
                hd.CREATED_BY=item.CREATED_BY;
                hd.CREATED_DATE=item.CREATED_DATE;
                hd.UPDATE_BY=item.UPDATE_BY;
                hd.UPDATE_DATE=item.UPDATE_DATE;
                hd.DELETED_BY=item.DELETED_BY;
                hd.DELETED_DATE=item.DELETED_DATE;
                hd.MACTY=item.MACTY;
                lstDTO.Add(hd);
            }
            return lstDTO;
        }
        public tb_HOPDONG Add(tb_HOPDONG hd)
        {
            try
            {
                db.tb_HOPDONG.Add(hd);
                db.SaveChanges();
                return hd;

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public tb_HOPDONG Update(tb_HOPDONG hd)
        {
            try
            {
                var _hd = db.tb_HOPDONG.FirstOrDefault(x => x.SOHD == hd.SOHD);
                _hd.NGAYBD = hd.NGAYBD;
                _hd.NGAYKT = hd.NGAYKT;
                _hd.MANV = hd.MANV;
                _hd.NGAYKY = hd.NGAYKY;
                _hd.LANKY = hd.LANKY;
                _hd.LUONGCOBAN = hd.LUONGCOBAN;
                _hd.HESOLUONG = hd.HESOLUONG;
                _hd.NOIDUNG = hd.NOIDUNG;
                _hd.THOIHAN = hd.THOIHAN;
                _hd.SOHD = hd.SOHD;
                _hd.MACTY = hd.MACTY;
                _hd.UPDATE_BY = hd.UPDATE_BY;
                _hd.UPDATE_DATE = hd.UPDATE_DATE;
              
                db.SaveChanges();
                return hd;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // ko xóa trên form mà chi có hiển thị xóa DELETED_BY, DELETED_DATE số lần và thời gian xóa
        public void Delete(string sohd, int manv)
        {
            var _hd = db.tb_HOPDONG.FirstOrDefault(x => x.SOHD == sohd);
            _hd.DELETED_BY = manv;
            _hd.DELETED_DATE = DateTime.Now;

            db.SaveChanges();
          
        }

        public string MaxSoHopDong()
        {
            // lấy ra theo ngày giảm dần. .FirstOrDefault lấy ra dòng đầu tiên
            var _hd = db.tb_HOPDONG.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_hd != null)
            {
                // nếu có thì lấy hợp đồng
                return _hd.SOHD;
            }
            else
              return "00000";
        }

        public List<HOPDONG_DTO> getlenluong()
        {
            List<tb_HOPDONG> lstHD = db.tb_HOPDONG.Where(x =>(x.NGAYBD.Value.Month - DateTime.Now.Month) == 0 && (DateTime.Now.Year - x.NGAYBD.Value.Year)==2).ToList();
            List<HOPDONG_DTO> lstDTO = new List<HOPDONG_DTO>();
            HOPDONG_DTO hd;
            foreach (var item in lstHD)
            {
                hd = new HOPDONG_DTO();
                hd.SOHD = item.SOHD;
                hd.NGAYBD = item.NGAYBD.Value.ToString("dd/MM/yyyy");
                hd.NGAYKT = item.NGAYKT.Value.ToString("dd/MM/yyyy");
                //hd.NGAYBD = "Từ ngày " + item.NGAYBD.Value.ToString( "dd/MM/yyyy" ).Substring( 0, 2 ) + " tháng " +item. NGAYBD.Value.ToString( "dd/MM/yyyy" ).Substring( 3, 2 ) + " năm " +item.NGAYBD.Value.ToString( "dd/MM/yyyy" ).Substring(6);
                // hd.NGAYKT= "Từ ngày " + item.NGAYKT.Value.ToString("dd/MM/yyyy").Substring(0, 2) + " tháng " + item.NGAYKT.Value.ToString("dd/MM/yyyy").Substring(3, 2) + " năm " + item.NGAYKT.Value.ToString("dd/MM/yyyy").Substring(6);
                hd.NGAYKY = item.NGAYKY.ToString();
                hd.LANKY = item.LANKY;
                hd.HESOLUONG = item.HESOLUONG;
                hd.LUONGCOBAN= item.LUONGCOBAN;
                hd.NOIDUNG = item.NOIDUNG;
                hd.MANV = item.MANV;
                hd.THOIHAN = item.THOIHAN;
                hd.LUONGCOBAN = item.LUONGCOBAN;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                hd.HOTEN = nv.HOTEN;
                hd.CCCD = nv.CCCD;
                hd.DIENTHOAI = nv.DIENTHOAI;
                hd.DIACHI = nv.DIACHI;

                hd.NGAYSINH = nv.NGAYSINH.Value.ToString("dd/MM/yyyy");
                hd.CREATED_BY = item.CREATED_BY;
                hd.CREATED_DATE = item.CREATED_DATE;
                hd.UPDATE_BY = item.UPDATE_BY;
                hd.UPDATE_DATE = item.UPDATE_DATE;
                hd.DELETED_BY = item.DELETED_BY;
                hd.DELETED_DATE = item.DELETED_DATE;
                hd.MACTY = item.MACTY;
                lstDTO.Add(hd);
            }
            return lstDTO;
        }
    
    }
}
