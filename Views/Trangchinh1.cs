using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATN.Models;
namespace DATN.Views
{
    public partial class Trangchinh1 : Form
    {
        public Trangchinh1()
        {
            InitializeComponent();
        }
        public static int kt;
        Nhanvien_Model nvm = new Nhanvien_Model();        
        public void setMenu()
        {
            if (Nhanvien_Model.chucvu=="Kho")
            {
                menuKho.Enabled = true;
                menuCuahang.Enabled = true; 
            }
                              
        }
        private void Trangchinh1_Load(object sender, EventArgs e)
        {
            setMenu();
        }
        public static Dangnhap dn;
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (dn == null)
            {
                dn = new Dangnhap();
                dn.MdiParent = this;
                dn.StartPosition = FormStartPosition.CenterParent;
                dn.WindowState = FormWindowState.Maximized;
                dn.Show();
            }
            else
                dn.Activate();
            
        }
        private void quanrToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public static Nhanvien_View nv;
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nv == null)
            {
                nv = new Nhanvien_View();
                nv.StartPosition = FormStartPosition.CenterScreen;
                nv.WindowState = FormWindowState.Maximized;
                nv.MdiParent = this;
                nv.Show();
            }
            else
                nv.Activate();
        }
        public static Khachhang_View kh;
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kh == null)
            {
                kh = new Khachhang_View();
                kh.StartPosition = FormStartPosition.CenterScreen;
                kh.WindowState = FormWindowState.Maximized;
                kh.MdiParent = this;
                kh.Show();
            }
            else
                kh.Activate();
        }
        public static Sanpham_View sp;
        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sp == null)
            {
                sp = new Sanpham_View();
                sp.StartPosition = FormStartPosition.CenterScreen;
                sp.WindowState = FormWindowState.Maximized;
                sp.MdiParent = this;
                sp.Show();
            }
            else
                sp.Activate();
        }
        public static Kho_View k;
        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (k == null)
            {
                k = new Kho_View();
                k.StartPosition = FormStartPosition.CenterScreen;
                k.WindowState = FormWindowState.Maximized;
                k.MdiParent = this;
                k.Show();
            }
            else
                k.Activate();
        }
        public static Nhacungcap_View ncc;
        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ncc == null)
            {
                ncc = new Nhacungcap_View();
                ncc.StartPosition = FormStartPosition.CenterScreen;
                ncc.WindowState = FormWindowState.Maximized;
                ncc.MdiParent = this;
                ncc.Show();
            }
            else
                ncc.Activate();
        }
        public static Doimatkhau dmk;
        private void menuDoimatkhau_Click(object sender, EventArgs e)
        {
            if (dmk == null)
            {
                dmk = new Doimatkhau();
                dmk.StartPosition = FormStartPosition.CenterScreen;
                dmk.WindowState = FormWindowState.Maximized;
                dmk.MdiParent = this;
                dmk.Show();
            }
            else
                dmk.Activate();
        }
        public static Capnhatthongtin cntt;
        private void menuCapnhat_Click(object sender, EventArgs e)
        {
            if (cntt == null)
            {
                cntt = new Capnhatthongtin();
                cntt.StartPosition = FormStartPosition.CenterScreen;
                cntt.WindowState = FormWindowState.Maximized;
                cntt.MdiParent = this;
                cntt.Show();
            }
            else
                cntt.Activate();
        }

        private void kháchCóThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoadonKCTT hdkctt = new HoadonKCTT();
            hdkctt.Show();
        }

        private void kháchChưaCóThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoadonKCCTT hdkcctt = new HoadonKCCTT();
            hdkcctt.Show();
        }

        
    }
}
