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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static NhanVien nv;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            if ((nv = tk.checkLogin(txtUser.Text, txtPass.Text))!= null)
            {
                MessageBox.Show("Welcome "+nv.HoTen+" To Application", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                if (Program.dashboardF.IsDisposed)
                    Program.dashboardF = new Dashboard();
                Program.dashboardF.Show();
            }
            else
            {
                MessageBox.Show("Username or password incorrect. Please try again !","Login Fail",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
