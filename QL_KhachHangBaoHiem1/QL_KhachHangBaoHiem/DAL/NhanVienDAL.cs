using MongoDB.Driver.Linq;
using MongoDB.Driver;
using QL_KhachHangBaoHiem.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachHangBaoHiem.DAL
{
    public class NhanVienDAL
    {
        DB_Mongo mongo = new DB_Mongo();
        IMongoQueryable<NhanVien> collection = null;

        public NhanVienDAL()
        {
            collection = mongo.getCollectionNhanVien().AsQueryable();
        }

        public IQueryable<NhanVien> getListNhanVien()
        {
            return collection.Select(t => t);
        }

        public bool checkTaiKhoan(string username, string password)
        {
            return collection.Select(t => t.TaiKhoan).Where(t => t.TenNguoiDung.Contains(username) && t.MatKhau.Equals(password)).Count() != 0 ? true : false;
        }

    }
}
