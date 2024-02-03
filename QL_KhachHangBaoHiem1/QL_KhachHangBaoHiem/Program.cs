using MongoDB.Bson;
using MongoDB.Driver;
using QL_KhachHangBaoHiem.DAL;
using QL_KhachHangBaoHiem.GUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachHangBaoHiem
{
    internal static class Program
    {

        public static Login loginF = null;
        public static Dashboard dashboardF = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //HDBaoHiemDAL t = new HDBaoHiemDAL();
            //var e = t.getListKhachHang();
            //foreach ( var item in e )
            //{
            //    Console.WriteLine(item.MaTTKH);
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            loginF = new Login();
            dashboardF = new Dashboard();
            Application.Run(loginF);
        }
    }
}
