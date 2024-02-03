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
    public partial class HHDaoHan : Form
    {
        public HHDaoHan()
        {
            InitializeComponent();
        }

        private void HHDaoHan_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = new HopDongBaoHiem().listHopDongDaoHan();
            dataGridView1.Columns[0].HeaderText = "Mã Hợp Đồng";
            dataGridView1.Columns[1].HeaderText = "Trạng Thái Hợp Đồng";
            dataGridView1.Columns[2].HeaderText = "Tổng Phí Sản Phẩm";
            dataGridView1.Columns[3].HeaderText = "Phí Giảm Hợp Đồng";
            dataGridView1.Columns[4].HeaderText = "Tổng Phí Định Kỳ";
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            TTChiTietHopDong f = new TTChiTietHopDong();
            f.maHD = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new HopDongBaoHiem().listHopDongDaoHan();
            dataGridView1.Columns[0].HeaderText = "Mã Hợp Đồng";
            dataGridView1.Columns[1].HeaderText = "Trạng Thái Hợp Đồng";
            dataGridView1.Columns[2].HeaderText = "Tổng Phí Sản Phẩm";
            dataGridView1.Columns[3].HeaderText = "Phí Giảm Hợp Đồng";
            dataGridView1.Columns[4].HeaderText = "Tổng Phí Định Kỳ";
        }
    }
}
