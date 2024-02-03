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
    public partial class QLKhachHang : Form
    {
        public QLKhachHang()
        {
            InitializeComponent();
        }

        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            TTKhachHang t = new TTKhachHang();
            dG_KhachHang.DataSource = t.GetTTKhachHangs();
            dG_KhachHang.Columns[0].ReadOnly = true;
            dG_KhachHang.Columns[1].ReadOnly = true;
            dG_KhachHang.Columns[2].ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                new HopDongBaoHiem().capNhatThongTinKhachHang(
                dG_KhachHang.CurrentRow.Cells[0].Value.ToString(),
                dG_KhachHang.CurrentRow.Cells[1].Value.ToString(),
                dG_KhachHang.CurrentRow.Cells[2].Value.ToString(),
                dG_KhachHang.CurrentRow.Cells[3].Value.ToString(),
                dG_KhachHang.CurrentRow.Cells[5].Value.ToString(),
                DateTime.Parse(dG_KhachHang.CurrentRow.Cells[4].Value.ToString()),
                dG_KhachHang.CurrentRow.Cells[6].Value.ToString()
                );
                MessageBox.Show("Cập nhật thành công !","Thành Công");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Cập nhật thất bại !");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TTKhachHang t = new TTKhachHang();
            dG_KhachHang.DataSource = t.GetTTKhachHangs();
        }
    }
}
