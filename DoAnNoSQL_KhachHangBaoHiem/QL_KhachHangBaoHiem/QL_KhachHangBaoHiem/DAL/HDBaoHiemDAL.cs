using MongoDB.Driver;
using MongoDB.Driver.Linq;
using QL_KhachHangBaoHiem.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MongoDB.Driver.WriteConcern;

namespace QL_KhachHangBaoHiem.DAL
{
    public class HDBaoHiemDAL
    {
        DB_Mongo mongo = new DB_Mongo();
        IMongoQueryable<HopDongBaoHiem> collection = null;

        public HDBaoHiemDAL()
        {
            collection = mongo.getCollectionHopDongBaoHiem().AsQueryable();     
        }

        public IQueryable<TTKhachHang> getListKhachHang()
        {
            return collection.Select(e => e.ThongTinKhachHang);
        }

        public IQueryable<HopDongBaoHiem> getListHopDongBaoHiem()
        {
            return collection.Select(t => t);
        }

        public void deleteHopDong(string maHD)
        {
            try
            {
                var filter = Builders<HopDongBaoHiem>.Filter.Eq(t => t.MaHopDong, maHD);
                mongo.getCollectionHopDongBaoHiem().DeleteOne(filter);
            }
            catch(Exception err)
            {
                throw err;
            }
        }

        public void CapNhatKhachHang(string maKH, string tenNguoiMua, string tenNguoiBH ,string gioiTinh, string nganhNghe, DateTime NgaySinh, string noiSinh)
        {
            TTKhachHang tt = new TTKhachHang();
            tt.MaTTKH = maKH;
            tt.TenNguoiBaoHiem = tenNguoiBH;
            tt.TenNguoiMua = tenNguoiBH;
            tt.GioiTinh = gioiTinh;
            tt.NganhNghe = nganhNghe;
            tt.NgaySinh = NgaySinh;
            tt.NoiSinh = noiSinh;

            var filter = Builders<HopDongBaoHiem>.Filter.Eq(t => t.ThongTinKhachHang.MaTTKH, maKH);

            var update = Builders<HopDongBaoHiem>.Update.Set(t => t.ThongTinKhachHang, tt);

            mongo.getCollectionHopDongBaoHiem().UpdateOne(filter, update);
        }
    }
}
