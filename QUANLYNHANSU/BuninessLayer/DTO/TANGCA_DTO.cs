using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuninessLayer.DTO
{
    public class TANGCA_DTO
    {
        public double? SOTIEN { get; set; }
        public string HOTEN { get; set; }
        public string TENLOAICA { get; set; }
        public double? HESO { get; set; }
        public int ID { get; set; }
        public Nullable<int> NAM { get; set; }
        public Nullable<int> THANG { get; set; }
        public Nullable<int> NGAY { get; set; }
        public Nullable<double> SOGIO { get; set; }
        public Nullable<int> MANV { get; set; }
        public Nullable<int> IDLOAICA { get; set; }
        public string GHICHU { get; set; }
        public Nullable<int> CREATE_BY { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public Nullable<int> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
        public Nullable<int> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }

        public virtual tb_LOAICA tb_LOAICA { get; set; }
        public virtual tb_NHANVIEN tb_NHANVIEN { get; set; }

    }
}
