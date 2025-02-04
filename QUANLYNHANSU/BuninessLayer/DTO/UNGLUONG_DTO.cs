﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuninessLayer.DTO
{
    public class UNGLUONG_DTO
    {
        public string HOTEN { get; set; }
        public int ID { get; set; }
        public Nullable<int> NAM { get; set; }
        public Nullable<int> THANG { get; set; }
        public Nullable<int> NGAY { get; set; }
        public Nullable<double> SOTIEN { get; set; }
        public string GHICHU { get; set; }
        public Nullable<int> MANV { get; set; }
        public Nullable<int> CREATE_BY { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public Nullable<int> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
        public Nullable<int> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
    }
}
