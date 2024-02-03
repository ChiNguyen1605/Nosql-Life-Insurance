using QL_KhachHangBaoHiem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachHangBaoHiem.BLL
{
    public class TaiKhoan
    {
        public List<string> TenNguoiDung;
        public string MatKhau;
        public string Quyen;
        NhanVienDAL nv = new NhanVienDAL();
        public TaiKhoan() {
        }

        public NhanVien checkLogin(string username, string password)
        {
            if(!nv.checkTaiKhoan(username, password))
            {
                return null;
            }
            return nv.getListNhanVien().FirstOrDefault(t =>
                t.TaiKhoan.TenNguoiDung.Contains(username) 
                && t.TaiKhoan.MatKhau.Equals(password)
            );
        }
    }
}
