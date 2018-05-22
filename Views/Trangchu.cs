using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DATN.Views.Danhmuc;
using DATN.Models;
namespace DATN.Views
{
    public partial class Trangchu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Trangchu()
        {
            InitializeComponent();
        }
        private Form Kiemtratontai(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType) //Nếu form được truyền vào đã được mở
                {
                    return f;
                }
            }
            return null;
        }
        public void SetButtonBH()
        {
            bbtNhaphang.Enabled = false;
            bbtXuathang.Enabled = false;
            bbtNhanvien.Enabled = false;
            bbtKho.Enabled = false;
            bbtNhomsp.Enabled = false;
            bbtNhacungcap.Enabled = false;
            bbtHoadonban.Enabled = false;
            bbtHoadonnhap.Enabled = false;
            bbtHoadonxuat.Enabled = false;

        }
        public void setButtonK()
        {
            bbtKhachCTT.Enabled = false;
            bbtKhachCCTT.Enabled = false;
            bbtDoihang.Enabled = false;
            bbtKhachhang.Enabled = false;
            bbtNhanvien.Enabled = false;
            bbtSanpham.Enabled = false;
            bbtNhomsp.Enabled = false;
            bbtHoadonban.Enabled = false;
            bbtHoadonnhap.Enabled = false;
            bbtHoadonxuat.Enabled = false;
        }
        
        private void Trangchu_Load(object sender, EventArgs e)
        {
            bbtNhaphang.Enabled = true;
            bbtXuathang.Enabled = true;
            bbtNhanvien.Enabled = true;
            bbtKho.Enabled = true;
            bbtNhomsp.Enabled = true;
            bbtNhacungcap.Enabled = true;
            bbtHoadonban.Enabled = true;
            bbtHoadonnhap.Enabled = true;
            bbtHoadonxuat.Enabled = true;
            bbtKhachCTT.Enabled = true;
            bbtKhachCCTT.Enabled = true;
            bbtDoihang.Enabled = true;
            bbtKhachhang.Enabled = true;
            bbtNhanvien.Enabled = true;
            bbtSanpham.Enabled = true;
            if (Nhanvien_Model.chucvu == "Nhân viên bán hàng")
            {
                SetButtonBH();
            }
            else
                if (Nhanvien_Model.chucvu == "Nhân viên kho")
                {
                    setButtonK();
                }
            //lbHoten.Text = "Xin chào " + Nhanvien_Model.hoten + "_Chức vụ của bạn là " +Nhanvien_Model.chucvu;
        }

        private void bbtDoimatkhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Doimatkhau));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Doimatkhau dmk = new Doimatkhau();
                dmk.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                dmk.WindowState = FormWindowState.Maximized;
                dmk.Show();
            }
        }

        private void bbtCapnhat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Capnhatthongtin));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Capnhatthongtin cntt = new Capnhatthongtin();
                cntt.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                cntt.WindowState = FormWindowState.Maximized;
                cntt.Show();
            }
        }

        private void bbtDangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();        
        }

        private void bbtNhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Nhanvien_View));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Nhanvien_View nv = new Nhanvien_View();
                nv.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                nv.WindowState = FormWindowState.Maximized;
                nv.Show();
            }
        }

        private void bbtKhachhang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Khachhang_View));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Khachhang_View kh = new Khachhang_View();
                kh.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                kh.WindowState = FormWindowState.Maximized;
                kh.Show();
            }
        }

        private void bbtNhomsp_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Nhomsanpham_View));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Nhomsanpham_View nsp = new Nhomsanpham_View();
                nsp.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                nsp.WindowState = FormWindowState.Maximized;
                nsp.Show();
            }
        }

        private void bbtKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Kho_View));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Kho_View k = new Kho_View();
                k.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                k.WindowState = FormWindowState.Maximized;
                k.Show();
            }
        }

        private void bbtSanpham_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Sanpham_View));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Sanpham_View sp = new Sanpham_View();
                sp.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                sp.WindowState = FormWindowState.Maximized;
                sp.Show();
            }
        }

        private void bbtNhacungcap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Nhacungcap_View));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Nhacungcap_View ncc = new Nhacungcap_View();
                ncc.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                ncc.WindowState = FormWindowState.Maximized;
                ncc.Show();
            }
        }

        private void bbtHoadonban_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Hoadonbanhang_View));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Hoadonbanhang_View hdb = new Hoadonbanhang_View();
                hdb.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                hdb.WindowState = FormWindowState.Maximized;
                hdb.Show();
            }
        }

        private void bbtHoadonnhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Hoadonnhaphang_View));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Hoadonnhaphang_View hdn = new Hoadonnhaphang_View();
                hdn.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                hdn.WindowState = FormWindowState.Maximized;
                hdn.Show();
            }
        }

        private void bbtHoadonxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Hoadonxuathang_View));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Hoadonxuathang_View hdx = new Hoadonxuathang_View();
                hdx.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                hdx.WindowState = FormWindowState.Maximized;
                hdx.Show();
            }
        }

        private void bbtNhaphang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Chitiethoadonnh_View));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Chitiethoadonnh_View cthdn = new Chitiethoadonnh_View();
                cthdn.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                cthdn.WindowState = FormWindowState.Maximized;
                cthdn.Show();
            }
        }

        private void bbtXuathang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Chitiethoadonxh_View));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Chitiethoadonxh_View cthdx = new Chitiethoadonxh_View();
                cthdx.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                cthdx.WindowState = FormWindowState.Maximized;
                cthdx.Show();
            }
        }

        private void bbtKhachCTT_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(HoadonKCTT));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                HoadonKCTT kctt = new HoadonKCTT();
                kctt.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                kctt.WindowState = FormWindowState.Maximized;
                kctt.Show();
            }
        }

        private void bbtKhachCCTT_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(HoadonKCCTT));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                HoadonKCCTT kcctt = new HoadonKCCTT();
                kcctt.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                kcctt.WindowState = FormWindowState.Maximized;
                kcctt.Show();
            }
        }

        private void bbtDoihang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(ChinhsuaHoadon));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                ChinhsuaHoadon tdh = new ChinhsuaHoadon();
                tdh.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                tdh.WindowState = FormWindowState.Maximized;
                tdh.Show();
            }
        }

        private void bbtDanhsachnv_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Nhanvien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Nhanvien nv = new Nhanvien();
                nv.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                nv.WindowState = FormWindowState.Maximized;
                nv.Show();
            }
        }

        private void bbtDanhsachkh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Khachhang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Khachhang kh = new Khachhang();
                kh.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                kh.WindowState = FormWindowState.Maximized;
                kh.Show();
            }
        }

        private void bbtDanhsachk_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Kho));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Kho k = new Kho();
                k.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                k.WindowState = FormWindowState.Maximized;
                k.Show();
            }
        }

        private void bbtDanhsachsp_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Sanpham));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Sanpham sp = new Sanpham();
                sp.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                sp.WindowState = FormWindowState.Maximized;
                sp.Show();
            }
        }

        private void bbtDanhsachncc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Nhacungcap));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Nhacungcap ncc = new Nhacungcap();
                ncc.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                ncc.WindowState = FormWindowState.Maximized;
                ncc.Show();
            }
        }

        private void bbtDanhsachhdb_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Hoadonbanhang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Hoadonbanhang hdb = new Hoadonbanhang();
                hdb.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                hdb.WindowState = FormWindowState.Maximized;
                hdb.Show();
            }
        }

        private void bbtDanhsachhdn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Hoadonnhaphang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Hoadonnhaphang hdn = new Hoadonnhaphang();
                hdn.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                hdn.WindowState = FormWindowState.Maximized;
                hdn.Show();
            }
        }

        private void bbtDanhsachhdx_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.Kiemtratontai(typeof(Hoadonxuathang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Hoadonxuathang hdx = new Hoadonxuathang();
                hdx.MdiParent = this;
                //dmk.StartPosition = FormStartPosition.CenterParent;
                hdx.WindowState = FormWindowState.Maximized;
                hdx.Show();
            }
        }
    }
}