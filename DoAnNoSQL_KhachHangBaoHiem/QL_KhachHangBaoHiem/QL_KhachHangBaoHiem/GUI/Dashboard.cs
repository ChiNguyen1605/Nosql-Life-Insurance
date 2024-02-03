using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibCustomWinform;

namespace QL_KhachHangBaoHiem.GUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.loginF.Show();
            this.Hide();
        }

        private void btnMenu1_Click(object sender, EventArgs e)
        {
            QLHopDong f = new QLHopDong();
            title.Text = f.Text;
            LibDashboard.loadFormInsidePanel(mainLayout, f);
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            Form f = new QLKhachHang();
            title.Text = f.Text;
            LibDashboard.loadFormInsidePanel(mainLayout, f);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            statusBar.Text = "Welcome " + Login.nv.HoTen;
        }

        private void btnMenu4_Click(object sender, EventArgs e)
        {
            Form f = new TraCuuThongTin();
            title.Text = f.Text;
            LibDashboard.loadFormInsidePanel(mainLayout, f);
        }

        private void btnMenu3_Click(object sender, EventArgs e)
        {
            HHDaoHan f = new HHDaoHan();
            title.Text = f.Text;
            LibDashboard.loadFormInsidePanel(mainLayout, f);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Program.loginF.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
