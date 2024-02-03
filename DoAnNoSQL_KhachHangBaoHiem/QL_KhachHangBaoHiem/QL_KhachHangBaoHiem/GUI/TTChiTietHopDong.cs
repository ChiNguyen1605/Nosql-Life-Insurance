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
    public partial class TTChiTietHopDong : Form
    {
        public string maHD;


        public TTChiTietHopDong()
        {
            InitializeComponent();
        }

        private void TTChiTietHopDong_Load(object sender, EventArgs e)
        {
            Text = maHD;
            HopDongBaoHiem t = new HopDongBaoHiem().GetHopDongBaoHiems(maHD);
            txtNguoiHuongBH.Text = t.ThongTinKhachHang.TenNguoiBaoHiem;
            txtNguoiMua.Text = t.ThongTinKhachHang.TenNguoiMua;
            txtPhiDinhKy.Text = t.TongPhiBHDinhKy.ToString();
            txtTongPhiSP.Text = t.TongPhiSanPham.ToString();

            dg_SPMua.DataSource = t.GetListSanPhamOfHopBaoHiems(maHD);
        }
    }
}
