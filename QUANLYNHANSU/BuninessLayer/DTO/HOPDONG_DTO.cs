using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuninessLayer.DTO
{
    public class HOPDONG_DTO
    {
        public int? LUONGCOBAN { get; set; }
        public string SOHD { get; set; }
        public string NGAYBD { get; set; }
        public string NGAYKT { get; set; }
        public string NGAYKY { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<int> LANKY { get; set; }
        public string THOIHAN { get; set; }
        public string DIENTHOAI { get; set; }
        public string CCCD { set; get; }
        public string DIACHI { set; get; }
        public string NGAYSINH { get; set; }
        //public string NGAYSINH { set; get; }
        public Nullable<double> HESOLUONG { get; set; }
        public Nullable<int> MANV { get; set; }
        public Nullable<int> MACTY { get; set; }
        public Nullable<int> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
        public Nullable<int> UPDATE_BY { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string HOTEN {  get; set; }
    }
}
