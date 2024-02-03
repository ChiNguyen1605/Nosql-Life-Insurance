using QL_KhachHangBaoHiem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachHangBaoHiem.GUI
{
    public partial class TraCuuThongTin : Form
    {
        public TraCuuThongTin()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string str = txtSearch.Text;
            HopDongBaoHiem rs = new HopDongBaoHiem().traCuuThongTinHopDong(str);

            if(rs == null)
            {
                MessageBox.Show("Không tìm thấy thông tin !");
                return;
            }

            treeView1.Nodes.Add("Mã Hợp Đồng: "+  rs.MaHopDong);
            treeView1.Nodes.Add("Trạng thái: " + (rs.TrangThaiHopDong ? "Hoạt Động" : "Dừng Hoạt Động"));
            treeView1.Nodes.Add("Ngày Ký: " + rs.NgayKyHopDong.ToString("dd/MM/yyyy hh:mm:ss"));
            treeView1.Nodes.Add("TTKH","Thông tin khách hàng");
            treeView1.Nodes["TTKH"].Nodes.Add("Mã Thông Tin KH: " + rs.ThongTinKhachHang.MaTTKH);
            treeView1.Nodes["TTKH"].Nodes.Add("Tên Người Mua: " + rs.ThongTinKhachHang.TenNguoiBaoHiem);
            treeView1.Nodes["TTKH"].Nodes.Add("Tên Người Hưởng: " + rs.ThongTinKhachHang.TenNguoiBaoHiem);
            treeView1.Nodes["TTKH"].Nodes.Add("Giới tính: " + rs.ThongTinKhachHang.GioiTinh);
            treeView1.Nodes["TTKH"].Nodes.Add("Ngày Sinh: " + rs.ThongTinKhachHang.NgaySinh.ToString("dd/MM/yyyy"));
            treeView1.Nodes["TTKH"].Nodes.Add("Ngành Nghề: " + rs.ThongTinKhachHang.NganhNghe);
            treeView1.Nodes["TTKH"].Nodes.Add("Nơi Sinh: " + rs.ThongTinKhachHang.NoiSinh);

            treeView1.Nodes.Add("SPBH","Sản Phẩm Bảo Hiểm Đã Mua");
            for (int i = 0; i < rs.SanPhamBH.Count; i++) 
            {
                treeView1.Nodes["SPBH"].Nodes.Add("Mã SP: " + rs.SanPhamBH[i].MaSP);
                treeView1.Nodes["SPBH"].Nodes.Add("Tên Sản Phẩm: " + rs.SanPhamBH[i].TenSanPham);
                treeView1.Nodes["SPBH"].Nodes.Add("Thời Hạn Đăng Ký: " + rs.SanPhamBH[i].ThoiHanBH);
                treeView1.Nodes["SPBH"].Nodes.Add("Số Tiền Bảo Hiểm: " + rs.SanPhamBH[i].SoTienBH.ToString());
                treeView1.Nodes["SPBH"].Nodes.Add("Phí Định Kỳ Dự tính: " + rs.SanPhamBH[i].PhiDinhKy.ToString());
            }

            treeView1.Nodes.Add("Tổng Phí Sản Phẩm Mua: " + rs.TongPhiSanPham);
            treeView1.Nodes.Add("Tổng Phí Triết Khấu Hợp Đồng: " + rs.PhiGiamHopDong);
            treeView1.Nodes.Add("Tổng Phí Đóng Định Kỳ: " + rs.TongPhiBHDinhKy);
            treeView1.ExpandAll();
        }
    }
}
