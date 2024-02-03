using QL_KhachHangBaoHiem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachHangBaoHiem.BLL
{
    public class TTKhachHang
    {
        public string MaTTKH { get; set; }
        public string TenNguoiMua { get; set; }
        public string TenNguoiBaoHiem { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string NganhNghe { get; set; }
        public string NoiSinh { get; set; }

        private HDBaoHiemDAL hdbh = new HDBaoHiemDAL();
        public TTKhachHang() { }

        public List<TTKhachHang> GetTTKhachHangs()
        {
            return hdbh.getListKhachHang().Select(t=>t).ToList();
        }
    }
}
