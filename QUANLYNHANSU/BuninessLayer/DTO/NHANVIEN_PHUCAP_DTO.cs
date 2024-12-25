using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuninessLayer.DTO
{
    public class NHANVIEN_PHUCAP_DTO
    {
        public string HOTEN { get; set; }
        public string TENCN { get; set; }
        public string TENPC { get; set; }
        public int ID { get; set; }
        public Nullable<int> MANV { get; set; }
        public Nullable<int> IDPC { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<double> SOTIEN { get; set; }
        public Nullable<int> CREATE_BY { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public Nullable<int> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
        public Nullable<int> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
    }
}
