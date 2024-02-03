using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachHangBaoHiem.BLL
{
    public class SPBaoHiem
    {
        public string MaSP { get; set; }
        public string TenSanPham { get; set; }
        public int ThoiHanBH {  get; set; }
        public string MucThamDinh {get; set;}
        public long SoTienBH { get; set; }
        public long PhiDinhKy {  get; set; }

        public SPBaoHiem() { }
    }
}
