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
using System.Data.SqlClient;
namespace DATN.Views
{
    public partial class Sanpham_View : Form
    {
        public Sanpham_View()
        {
            InitializeComponent();
        }
        Sanpham_Model spm = new Sanpham_Model();
        Sanpham_Controller spc = new Sanpham_Controller();
        Kho_Model km = new Kho_Model();
        private void Sanpham_View_Load(object sender, EventArgs e)
        {
            SetButton_Open();
            dgvSanpham.DataSource = spm.LoadDulieu();
            cbTensp.DataSource = km.LoadDulieu();
            cbTensp.DisplayMember = "Tensp";
        }
        public void SetButton_Open()
        {
            btThem.Enabled = true;
            btHuy.Enabled = false;
            btLuu.Enabled = false;
            btSua.Enabled = true;
            btXoa.Enabled = true;
        }
        public void SetButton_Close()
        {
            btThem.Enabled = false;
            btHuy.Enabled = true;
            btLuu.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }
        public void SetNull()
        {
            txtGia.Text = "";
            txtMasp.Text = "";
            txtSoluong.Text = "";
            cbTensp.Text = "";
        }
        bool thaotac = true;
        private void button1_Click(object sender, EventArgs e)
        {
            thaotac = true;
            SetNull();
            SetButton_Close();
            DataTable dt = spm.LoadDulieu();
            int count = 0;
            count = dt.Rows.Count;
            string chuoi = "";
            if(count <=0)
            {
                txtMasp.Text = "SP01";
            }
            else
            {
                 int chuoi2 = 0;
            chuoi = Convert.ToString(dt.Rows[count - 1][0].ToString());
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
                txtMasp.Text = "SP0" + (chuoi2 + 1).ToString();
            else
                if (chuoi2 + 1 < 100)
                    txtMasp.Text = "SP" + (chuoi2 + 1).ToString();
            }         
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            thaotac = false;
            SetButton_Close();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (thaotac == true)
            {
                if (txtMasp.Text == "" && cbTensp.Text == "")
                {
                    MessageBox.Show("Không thể lưu dữ liệu nếu không có hoặc thiếu dữ liệu");
                }
                else
                {
                    if (spc.Them(txtMasp.Text,cbTensp.Text,txtGia.Text,txtSoluong.Text) == true)
                    {

                        MessageBox.Show("Bạn đã thêm thành công");
                        Sanpham_View_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi thêm không thành công");
                        SetButton_Close();
                    }
                }
            }
            else
            {
                if (spc.Sua(txtMasp.Text, cbTensp.Text, txtGia.Text, txtSoluong.Text) == true)
                {

                    MessageBox.Show("Bạn đã sửa thành công");
                    Sanpham_View_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi sửa không thành công");
                    SetButton_Close();
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            SetNull();
            Sanpham_View_Load(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc muốn xóa không", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (spc.Xoa(txtMasp.Text) == true)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi xóa không thành công");
                }
            }
            SetNull();
            Sanpham_View_Load(sender, e);
        }

        private void dgvSanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Sanpham_View_FormClosed(object sender, FormClosedEventArgs e)
        {
            Trangchinh1.sp = null;
        }

        private void dgvSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = dgvSanpham.CurrentRow.Index;
                txtMasp.Text = dgvSanpham.Rows[i].Cells["Masp"].Value.ToString();
                cbTensp.Text = dgvSanpham.Rows[i].Cells["Tensp"].Value.ToString();
                txtGia.Text = dgvSanpham.Rows[i].Cells["Giaban"].Value.ToString();
                txtSoluong.Text = dgvSanpham.Rows[i].Cells["Soluong"].Value.ToString();
            }
            catch
            {
                e.ToString();
            }
        }
    }
}
