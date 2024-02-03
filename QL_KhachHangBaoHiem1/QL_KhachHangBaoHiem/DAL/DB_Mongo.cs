using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver;
using MongoDB.Bson;
using System;
using QL_KhachHangBaoHiem.BLL;


namespace QL_KhachHangBaoHiem.DAL
{
    public class DB_Mongo
    {
        private string DBName = "QL_BaoHiem";
        private string connectionString = Properties.Settings.Default.StrConnectMongoDB;
        private MongoClient client = null;
        private IMongoDatabase db = null;

        public MongoClient Client {  get => client; }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public DB_Mongo() {
            client = new MongoClient(ConnectionString);
            db = client.GetDatabase(DBName);
        }

        public IMongoCollection<NhanVien> getCollectionNhanVien()
        {
            return db.GetCollection<NhanVien>("NhanVien");
        }

        public IMongoCollection<HopDongBaoHiem> getCollectionHopDongBaoHiem()
        {
            return db.GetCollection<HopDongBaoHiem>("HDBH");
        }
    }
}
