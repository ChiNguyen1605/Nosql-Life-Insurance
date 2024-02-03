using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachHangBaoHiem.BLL
{
    public class NhanVien
    {
        [BsonElement("_id")]
        public ObjectId Id { get; set; }
        [BsonElement("MaNV")]
		public string MaNV { get; set; }
        [BsonElement("HoTen")]
        public string HoTen { get; set; }

        [BsonElement("NgaySinh")]
        public BsonDateTime NgaySinh { get; set; }
        [BsonElement("SDT")]
        public string SDT { get; set; }
        [BsonElement("NoiSong")]
        public string NoiSong { get; set; }
        [BsonElement("TaiKhoan")]
        public TaiKhoan TaiKhoan { get; set; }

        public NhanVien() { }
    }
}
