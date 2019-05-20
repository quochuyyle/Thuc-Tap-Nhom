using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_li_diem_HS_tieu_hoc
{
    public class HocSinh
    {
        private string _MaHS;
        public string MaHS
        {
            get {return _MaHS; }
            set {_MaHS=value; }
        }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string Lop { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
    }
}
