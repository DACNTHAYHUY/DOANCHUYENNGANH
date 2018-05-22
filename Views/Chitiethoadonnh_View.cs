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
using DATN.Controllers;
namespace DATN.Views
{
    public partial class Chitiethoadonnh_View : Form
    {
        public Chitiethoadonnh_View()
        {
            InitializeComponent();
        }
        public static int tt = 0;
        private void Chitiethoadonnh_View_Load(object sender, EventArgs e)
        {
            if (tt == 0)
            {
                Mahoadontangdan();
                dgvHoadonnhap.DataSource = cthdnm.LoadDulieu();
                cbMancc.DataSource = nccm.LoadDulieu();
                cbMancc.ValueMember = "Mancc";
                cbMancc.DisplayMember = "Tenncc";
                cbMasp.DataSource = spm.LoadDulieu();
                cbMasp.ValueMember = "Masp";
                cbMasp.DisplayMember = "Tensp";
                txtManv.Text = Dangnhap.manv;
            }
            else
                if (tt == 1)
                {
                    dgvHoadonnhap.DataSource = cthdnm.LoadDulieu();
                    cbMancc.DataSource = nccm.LoadDulieu();
                    cbMancc.ValueMember = "Mancc";
                    cbMancc.DisplayMember = "Tenncc";
                    cbMasp.DataSource = spm.LoadDulieu();
                    cbMasp.ValueMember = "Masp";
                    cbMasp.DisplayMember = "Tensp";
                    txtManv.Text = Dangnhap.manv;
                }
                else
                if (tt == 2)
                {
                    dgvHoadonnhap.DataSource = cthdnm.LoadDulieu1(Hoadonnhaphang_View.Mahd);
                    txtMahdn.Text = Hoadonnhaphang_View.Mahd;
                    cbMancc.DataSource = nccm.LoadDulieu();
                    cbMancc.ValueMember = "Mancc";
                    cbMancc.DisplayMember = "Tenncc";
                    cbMasp.DataSource = spm.LoadDulieu();
                    cbMasp.ValueMember = "Masp";
                    cbMasp.DisplayMember = "Tensp";
                    txtManv.Text = Dangnhap.manv;
                }
        }
        Nhacungcap_Model nccm = new Nhacungcap_Model();
        Sanpham_Model spm = new Sanpham_Model();
        Hoadonnhaphang_Model hdnm = new Hoadonnhaphang_Model();
        Hoadonnhaphang_Controller hdnc = new Hoadonnhaphang_Controller();
        Chitiethoadonnh_Controller cthdnc = new Chitiethoadonnh_Controller();
        Chitiethoadonnh_Model cthdnm = new Chitiethoadonnh_Model();
        public void SetNull()
        {
            txtDongia.Text = "";
            txtSoluong.Text = "";
            cbMasp.Text = "";
            cbMancc.Text = "";
            txtMahdn.Text = "";
            txtMacthdn.Text = "";
            txtTongtien.Text = "";
            txtThanhtien.Text = "";
        }
        public void SetNull1()
        {
            txtDongia.Text = "";
            txtSoluong.Text = "";
            cbMasp.Text = "";
            txtMacthdn.Text = "";
            txtThanhtien.Text = "";
        }
        public void Mahoadontangdan()
        {
            DataTable dt = hdnm.LoadDulieu();
            int count = 0;
            count = dt.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 0)
            {
                txtMahdn.Text = "HDN01";
            }
            else
            {
                chuoi = Convert.ToString(dt.Rows[count - 1]["Mahdn"].ToString());
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    txtMahdn.Text = "HDN0" + (chuoi2 + 1).ToString();
                else
                    if (chuoi2 + 1 < 100)
                        txtMahdn.Text = "HDN" + (chuoi2 + 1).ToString();
            }           
        }
        public void Macthdtangdan()
        {
            DataTable dt = cthdnm.LoadDulieu();
            int count = 0;
            count = dt.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 0)
            {
                txtMacthdn.Text = "CTHDN01";
            }
            else
            {
                chuoi = Convert.ToString(dt.Rows[count - 1]["Macthdn"].ToString());
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 5)));
                if (chuoi2 + 1 < 10)
                    txtMacthdn.Text = "CTHDN0" + (chuoi2 + 1).ToString();
                else
                    if (chuoi2 + 1 < 100)
                        txtMacthdn.Text = "CTHDN" + (chuoi2 + 1).ToString();
            }           
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            Macthdtangdan();
            DataTable dt = cthdnm.LoadDulieu1(txtMahdn.Text);
            int count = dt.Rows.Count;
            if(count<=0)
            {
                if (txtMahdn.Text == "" && txtManv.Text == "" && txtMacthdn.Text == "" && cbMasp.Text == "" && txtSoluong.Text == "" && txtDongia.Text == "" && cbMancc.Text == "")
                {
                    MessageBox.Show("Không thể lưu dữ liệu nếu không có hoặc thiếu dữ liệu");
                }
                else
                {
                    if (hdnc.Them(txtMahdn.Text, txtManv.Text, dtNgaynhap.Text, txtTongtien.Text,cbMancc.SelectedValue.ToString()) == true && cthdnc.Them(txtMacthdn.Text,cbMasp.SelectedValue.ToString(),txtMahdn.Text,txtDongia.Text,txtThanhtien.Text,txtSoluong.Text) == true)
                    {
                        MessageBox.Show("Bạn đã thêm thành công");
                        tt = 1;
                        SetNull1();
                        Chitiethoadonnh_View_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi thêm không thành công");
                    }
                }
            }
            else
            {
                if (cthdnc.Them(txtMacthdn.Text, cbMasp.SelectedValue.ToString(),txtMahdn.Text, txtDongia.Text, txtThanhtien.Text, txtSoluong.Text) == true)
                {
                    MessageBox.Show("Bạn đã thêm thành công");
                    tt = 1;
                    Chitiethoadonnh_View_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi thêm không thành công");
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cthdnc.Sua(txtMacthdn.Text, cbMasp.SelectedValue.ToString(),txtMahdn.Text, txtDongia.Text, txtThanhtien.Text, txtSoluong.Text) == true)
            {
                MessageBox.Show("Bạn đã sửa thành công");
                tt = 1;
                Chitiethoadonnh_View_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi sửa không thành công");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DataTable dt = cthdnm.LoadDulieu1(txtMahdn.Text);
            int count = 0;
            count = dt.Rows.Count;
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc muốn xóa không", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (count <= 1)
                {
                    if (hdnc.Xoa(txtMahdn.Text) == true && cthdnc.Xoa(txtMacthdn.Text))
                    {
                        MessageBox.Show("Bạn đã xóa thành công");
                        tt = 1;
                        SetNull();
                        Chitiethoadonnh_View_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi xóa không thành công");
                    }
                }
                else
                {
                    if (cthdnc.Xoa(txtMacthdn.Text) == true)
                    {
                        MessageBox.Show("Bạn đã xóa thành công");
                        tt = 1;
                        SetNull1();
                        Chitiethoadonnh_View_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi xóa không thành công");
                    }
                }               
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            SetNull1();
        }

        private void btTaomoi_Click(object sender, EventArgs e)
        {
            tt = 0;
            Chitiethoadonnh_View_Load(sender, e);
        }

        private void dgvHoadonnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = dgvHoadonnhap.CurrentRow.Index;
                cbMasp.Text = dgvHoadonnhap.Rows[i].Cells[2].Value.ToString();
                txtMahdn.Text = dgvHoadonnhap.Rows[i].Cells[1].Value.ToString();
                txtDongia.Text = dgvHoadonnhap.Rows[i].Cells[4].Value.ToString();
                txtThanhtien.Text = dgvHoadonnhap.Rows[i].Cells[5].Value.ToString();
                txtSoluong.Text = dgvHoadonnhap.Rows[i].Cells[3].Value.ToString();
                txtMacthdn.Text = dgvHoadonnhap.Rows[i].Cells[0].Value.ToString();               
            }
            catch
            {
                e.ToString();
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt;
            dt = cthdnm.LoadDulieu();
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Mahdn LIKE '%{0}%'", txtTimkiem.Text);
            dgvHoadonnhap.DataSource = dv;
        }
        private void txtTimkiem_Enter(object sender, EventArgs e)
        {
            txtTimkiem.Text = "";
        }
    }
}
