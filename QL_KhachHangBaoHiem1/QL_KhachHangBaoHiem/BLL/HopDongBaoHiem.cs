using MongoDB.Bson;
using QL_KhachHangBaoHiem.DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachHangBaoHiem.BLL
{
    public class HopDongBaoHiem
    {
        public ObjectId _id { get; set; }
        public string MaHopDong { get ; set; }
        public TTKhachHang ThongTinKhachHang { get; set; }
        public List<SPBaoHiem> SanPhamBH { get; set; }
        public bool TrangThaiHopDong { get ; set; }
        public long TongPhiSanPham { get; set; }
        public long PhiGiamHopDong { get; set; }
        public long TongPhiBHDinhKy { get; set; }
        public DateTime NgayKyHopDong { get; set; }

        public HopDongBaoHiem() { }

        public List<object> GetHopDongBaoHiems()
        {
            return new HDBaoHiemDAL().getListHopDongBaoHiem().Select(t=> new {
                t.MaHopDong,
                t.TrangThaiHopDong,
                t.TongPhiSanPham,
                t.PhiGiamHopDong,
                t.TongPhiBHDinhKy
            }).ToList<object>();
        }

        public HopDongBaoHiem GetHopDongBaoHiems(string maHD)
        {
            return new HDBaoHiemDAL().getListHopDongBaoHiem().Where(t => t.MaHopDong == maHD).FirstOrDefault();
        }

        public List<SPBaoHiem> GetListSanPhamOfHopBaoHiems(string maHD)
        {
            return new HDBaoHiemDAL().getListHopDongBaoHiem().Where(t => t.MaHopDong == maHD).FirstOrDefault().SanPhamBH;
        }

        public void XoaHopDong(string maHD)
        {
            try
            {
                new HDBaoHiemDAL().deleteHopDong(maHD);
            }
            catch(Exception err)
            {
                throw err;
            }
        }

        public HopDongBaoHiem traCuuThongTinHopDong(string strSearch)
        {
            HopDongBaoHiem rs = null;
            if (strSearch.StartsWith("HD"))
            {
                rs = new HDBaoHiemDAL().getListHopDongBaoHiem().Where(t => t.MaHopDong == strSearch).FirstOrDefault();
            }
            else if(strSearch.StartsWith("TTKH"))
            {
                rs = new HDBaoHiemDAL().getListHopDongBaoHiem().Where(t => t.ThongTinKhachHang.MaTTKH == strSearch).FirstOrDefault();
            }
            else
            {
                rs = new HDBaoHiemDAL().getListHopDongBaoHiem().Where(t => t.ThongTinKhachHang.TenNguoiBaoHiem == strSearch).FirstOrDefault();
                if(rs == null)
                {
                    rs = new HDBaoHiemDAL().getListHopDongBaoHiem().Where(t => t.ThongTinKhachHang.TenNguoiMua == strSearch).FirstOrDefault();
                }
            }
            return rs;
        }

        public List<object> listHopDongDaoHan()
        {
            return new HDBaoHiemDAL().getListHopDongBaoHiem().ToList().Where(t => (int)(DateTime.Now.Subtract(t.NgayKyHopDong.Date).TotalDays) > t.SanPhamBH.Max(sp => sp.ThoiHanBH)).Select(rs => new
            {
                rs.MaHopDong,
                rs.TrangThaiHopDong,
                rs.TongPhiSanPham,
                rs.PhiGiamHopDong,
                rs.TongPhiBHDinhKy
            }).ToList<object>();
        }

        public void capNhatThongTinKhachHang(string maKH, string tenNguoiMua, string tenNguoiBH, string gioiTinh, string nganhNghe, DateTime NgaySinh, string noiSinh)
        {
            try
            {
                new HDBaoHiemDAL().CapNhatKhachHang(maKH, tenNguoiBH, tenNguoiBH, gioiTinh, nganhNghe, NgaySinh, noiSinh);

            }
            catch(Exception err)
            {
                throw err;
            }
        }

        public void insertHopDong(HopDongBaoHiem hd)
        {
            try
            {
                new HDBaoHiemDAL().ThemHopDong(hd);
            } 
            catch(Exception err)
            {
                throw err;
            }
        }
    }
}
