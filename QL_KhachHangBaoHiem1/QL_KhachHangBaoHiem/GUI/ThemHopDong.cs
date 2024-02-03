using QL_KhachHangBaoHiem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QL_KhachHangBaoHiem.GUI
{
    public partial class ThemHopDong : Form
    {
        public ThemHopDong()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            string maTTKH = txtMaTTKH.Text;
            DateTime dt = DateTime.Now;
            string tenNguoiMua = txtTenNguoiMua.Text;
            string tenNguoiBH = txtTenNguoiBH.Text;
            string gioiTinh = txtGioiTinh.Text;
            string nganhNghe = txtNganhNghe.Text;
            string noiSinh = txtNoiSinh.Text;
            List<SPBaoHiem> lsp = new List<SPBaoHiem>();
            foreach(DataGridViewRow dr in dataGridView1.Rows)
            {
                if(dr.Cells[0].Value != null)
                {
                    SPBaoHiem item = new SPBaoHiem()
                    {
                        MaSP = dr.Cells["MaSP"].Value.ToString(),
                        TenSanPham = dr.Cells["TenSP"].Value.ToString(),
                        ThoiHanBH = int.Parse(dr.Cells["ThoiHanBH"].Value.ToString()),
                        MucThamDinh = dr.Cells["MucThamDinh"].Value.ToString(),
                        SoTienBH = long.Parse(dr.Cells["SoTienBH"].Value.ToString()),
                        PhiDinhKy = long.Parse(dr.Cells["SoTienBH"].Value.ToString()) / int.Parse(dr.Cells["ThoiHanBH"].Value.ToString())
                    };
                    lsp.Add(item);
                }
                
            }
            bool trangThaiHD = chkBoxKichHoat.Checked;

            HopDongBaoHiem hd = new HopDongBaoHiem()
            {
                MaHopDong = maHD,
                ThongTinKhachHang = new TTKhachHang() { 
                    MaTTKH = maTTKH,
                    TenNguoiBaoHiem = tenNguoiBH,
                    TenNguoiMua = tenNguoiMua,
                    GioiTinh = gioiTinh,
                    NganhNghe = nganhNghe,
                    NoiSinh = noiSinh
                },
                SanPhamBH = lsp,
                TrangThaiHopDong = trangThaiHD,
                TongPhiSanPham = lsp.Sum(t=>t.SoTienBH),
                PhiGiamHopDong = ((long)Math.Floor(lsp.Sum(t => t.SoTienBH) * 0.05)),
                TongPhiBHDinhKy = lsp.Sum(t => t.PhiDinhKy),
                NgayKyHopDong = dt
            };
            try
            {
                hd.insertHopDong(hd);
                MessageBox.Show("Tạo Hợp Đồng Thành Công !");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
