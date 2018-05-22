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
    public partial class Chitiethoadonxh_View : Form
    {
        public Chitiethoadonxh_View()
        {
            InitializeComponent();
        }
        Kho_Model km = new Kho_Model();
        Hoadonxuathang_Model hdxm = new Hoadonxuathang_Model();
        Hoadonxuathang_Controller hdxc = new Hoadonxuathang_Controller();
        Chitiethoadonxh_Controller cthdxc = new Chitiethoadonxh_Controller();
        Chitiethoadonxh_Model cthdxm = new Chitiethoadonxh_Model();
        public static int tt = 0;
        private void Chitiethoadonxh_View_Load(object sender, EventArgs e)
        {
            if (tt == 0)
            {
                Mahoadontangdan();
                dgvHoadonxuat.DataSource = cthdxm.LoadDulieu();
                cbMasp.DataSource = km.LoadDulieu();
                cbMasp.ValueMember = "Masp";
                cbMasp.DisplayMember = "Tensp";
                txtManv.Text = Dangnhap.manv;
            }
            else
                if (tt == 1)
                {
                    dgvHoadonxuat.DataSource = cthdxm.LoadDulieu();
                    cbMasp.DataSource = km.LoadDulieu();
                    cbMasp.ValueMember = "Masp";
                    cbMasp.DisplayMember = "Tensp";
                    txtManv.Text = Dangnhap.manv;
                }
                else
                    if (tt == 2)
                    {
                        dgvHoadonxuat.DataSource = cthdxm.LoadDulieu1(Hoadonxuathang_View.Mahd);
                        txtMahdx.Text = Hoadonxuathang_View.Mahd;
                        cbMasp.DataSource = km.LoadDulieu();
                        cbMasp.ValueMember = "Masp";
                        cbMasp.DisplayMember = "Tensp";
                        txtManv.Text = Dangnhap.manv;
                    }
        }
        public void SetNull()
        {
            txtSoluong.Text = "";
            cbMasp.Text = "";
            txtMahdx.Text = "";
            txtMacthdx.Text = "";
        }
        public void SetNull1()
        {
            txtSoluong.Text = "";
            cbMasp.Text = "";
            txtMacthdx.Text = "";
        }
        public void Mahoadontangdan()
        {
            DataTable dt = hdxm.LoadDulieu();
            int count = 0;
            count = dt.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 0)
            {
                txtMahdx.Text = "HDX01";
            }
            else
            {
                chuoi = Convert.ToString(dt.Rows[count - 1]["Mahdx"].ToString());
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    txtMahdx.Text = "HDX0" + (chuoi2 + 1).ToString();
                else
                    if (chuoi2 + 1 < 100)
                        txtMahdx.Text = "HDX" + (chuoi2 + 1).ToString();
            }
        }
        public void Macthdtangdan()
        {
            DataTable dt = cthdxm.LoadDulieu();
            int count = 0;
            count = dt.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 0)
            {
                txtMacthdx.Text = "CTHDX01";
            }
            else
            {
                chuoi = Convert.ToString(dt.Rows[count - 1]["Macthdx"].ToString());
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 5)));
                if (chuoi2 + 1 < 10)
                    txtMacthdx.Text = "CTHDX0" + (chuoi2 + 1).ToString();
                else
                    if (chuoi2 + 1 < 100)
                        txtMacthdx.Text = "CTHDX" + (chuoi2 + 1).ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Macthdtangdan();
            DataTable dt = cthdxm.LoadDulieu1(txtMahdx.Text);
            int count = 0;
            count = dt.Rows.Count;
            if (count <= 0)
            {
                if (txtMahdx.Text == "" && txtManv.Text == "" && txtMacthdx.Text == "" && cbMasp.Text == "" && txtSoluong.Text == "")
                {
                    MessageBox.Show("Không thể lưu dữ liệu nếu không có hoặc thiếu dữ liệu");
                }
                else
                {
                    if (hdxc.Them(txtMahdx.Text, txtManv.Text, dtNgayxuat.Text) == true && cthdxc.Them(txtMacthdx.Text, cbMasp.SelectedValue.ToString(), txtMahdx.Text,txtSoluong.Text) == true)
                    {
                        MessageBox.Show("Bạn đã thêm thành công");
                        tt = 1;
                        SetNull1();
                        Chitiethoadonxh_View_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi thêm không thành công");
                    }
                }
            }
            else
            {
                if (cthdxc.Them(txtMacthdx.Text, cbMasp.SelectedValue.ToString(), txtMahdx.Text, txtSoluong.Text) == true)
                {
                    MessageBox.Show("Bạn đã thêm thành công");
                    tt = 1;
                    Chitiethoadonxh_View_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi thêm không thành công");
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cthdxc.Sua(txtMacthdx.Text, cbMasp.SelectedValue.ToString(), txtMahdx.Text, txtSoluong.Text) == true)
            {
                MessageBox.Show("Bạn đã sửa thành công");
                tt = 1;
                Chitiethoadonxh_View_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi sửa không thành công");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DataTable dt = cthdxm.LoadDulieu1(txtMahdx.Text);
            int count = 0;
            count = dt.Rows.Count;
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc muốn xóa không", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (count <= 1)
                {
                    if (hdxc.Xoa(txtMahdx.Text) == true && cthdxc.Xoa(txtMacthdx.Text))
                    {
                        MessageBox.Show("Bạn đã xóa thành công");
                        tt = 1;
                        SetNull();
                        Chitiethoadonxh_View_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi xóa không thành công");
                    }
                }
                else
                {
                    if (cthdxc.Xoa(txtMacthdx.Text) == true)
                    {
                        MessageBox.Show("Bạn đã xóa thành công");
                        tt = 1;
                        SetNull1();
                        Chitiethoadonxh_View_Load(sender, e);
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
            Chitiethoadonxh_View_Load(sender, e);
        }

        private void dgvHoadonxuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = dgvHoadonxuat.CurrentRow.Index;
                cbMasp.Text = dgvHoadonxuat.Rows[i].Cells[2].Value.ToString();
                txtMahdx.Text = dgvHoadonxuat.Rows[i].Cells[1].Value.ToString();
                txtSoluong.Text = dgvHoadonxuat.Rows[i].Cells[3].Value.ToString();
                txtMacthdx.Text = dgvHoadonxuat.Rows[i].Cells[0].Value.ToString();
            }
            catch
            {
                e.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt;
            dt = cthdxm.LoadDulieu();
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Mahdx LIKE '%{0}%'", textBox1.Text);
            dgvHoadonxuat.DataSource = dv;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
