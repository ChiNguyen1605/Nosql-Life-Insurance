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
    public partial class QLHopDong : Form
    {
        public QLHopDong()
        {
            InitializeComponent();
        }

        private void QLHopDong_Load(object sender, EventArgs e)
        {
            HopDongBaoHiem hd = new HopDongBaoHiem();
            dG_HopDong.DataSource = hd.GetHopDongBaoHiems();
            dG_HopDong.Columns[0].HeaderText = "Mã Hợp Đồng";
            dG_HopDong.Columns[1].HeaderText = "Trạng Thái Hợp Đồng";
            dG_HopDong.Columns[2].HeaderText = "Tổng Phí Sản Phẩm";
            dG_HopDong.Columns[3].HeaderText = "Phí Giảm Hợp Đồng";
            dG_HopDong.Columns[4].HeaderText = "Tổng Phí Định Kỳ";
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            TTChiTietHopDong f = new TTChiTietHopDong();
            f.maHD = dG_HopDong.CurrentRow.Cells[0].Value.ToString();
            f.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                new HopDongBaoHiem().XoaHopDong(dG_HopDong.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Xóa thành công Hợp Đồng!","Thành Công");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message,"Xóa Thất Bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HopDongBaoHiem hd = new HopDongBaoHiem();
            dG_HopDong.DataSource = hd.GetHopDongBaoHiems();
            dG_HopDong.Columns[0].HeaderText = "Mã Hợp Đồng";
            dG_HopDong.Columns[1].HeaderText = "Trạng Thái Hợp Đồng";
            dG_HopDong.Columns[2].HeaderText = "Tổng Phí Sản Phẩm";
            dG_HopDong.Columns[3].HeaderText = "Phí Giảm Hợp Đồng";
            dG_HopDong.Columns[4].HeaderText = "Tổng Phí Định Kỳ";
        }
    }
}
