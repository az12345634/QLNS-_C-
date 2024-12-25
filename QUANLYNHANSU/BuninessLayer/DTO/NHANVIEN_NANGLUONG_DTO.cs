using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuninessLayer.DTO
{
    public class NHANVIEN_NANGLUONG_DTO
    {
        public string HOTEN { get; set; }
        public string SOQD { get; set; }
        public string SOHD { get; set; }
        public Nullable<double> HESOLUONGHIENTAI { get; set; }
        public Nullable<double> HESOLUONGMOI { get; set; }
        public Nullable<System.DateTime> NGAYLENLUONG { get; set; }
        public Nullable<System.DateTime> NGAYKY { get; set; }
        public Nullable<int> CREATE_BY { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public Nullable<int> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
        public Nullable<int> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
        public Nullable<int> MANV { get; set; }
        public string GHICHU { get; set; }
    }
}
