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
    public partial class Nhanvien_View : Form
    {
        public Nhanvien_View()
        {
            InitializeComponent();
        }
        bool thaotac = true;
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
            txtManv.Text = "";
            txtDiachi.Text = "";
            txtGioitinh.Text = "";
            txtMatkhau.Text = "";
            txtSdt.Text = "";
            txtTennv.Text = "";
            cbChucvu.Text = "";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        Nhanvien_Model nvm = new Nhanvien_Model();
        private void Nhanvien_View_Load(object sender, EventArgs e)
        {
            SetButton_Open();
            dgvNhanvien.DataSource = nvm.LoadDulieu();
        }
        Nhanvien_Controller nvc = new Nhanvien_Controller();

        private void btThem_Click(object sender, EventArgs e)
        {
            thaotac = true;
            SetNull();
            SetButton_Close();
            DataTable dt = nvm.LoadDulieu();
            int count = 0;
            count = dt.Rows.Count;
            if(count <=0)
            {
                txtManv.Text = "NV01";
            }
            else
            {
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(dgvNhanvien.Rows[count - 1].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                if (chuoi2 + 1 < 10)
                    txtManv.Text = "NV0" + (chuoi2 + 1).ToString();
                else
                    if (chuoi2 + 1 < 100)
                        txtManv.Text = "NV" + (chuoi2 + 1).ToString();
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
                if (txtManv.Text == "" && txtTennv.Text == "")
                {
                    MessageBox.Show("Không thể lưu dữ liệu nếu không có hoặc thiếu dữ liệu");
                }
                else
                {
                    if(txtGioitinh.Text=="Nam"||txtGioitinh.Text=="Nữ")
                    {
                        if (nvc.Them(txtManv.Text, txtMatkhau.Text, txtTennv.Text, txtGioitinh.Text, txtDiachi.Text, txtSdt.Text, cbChucvu.Text) == true)
                        {

                            MessageBox.Show("Bạn đã thêm thành công");
                            Nhanvien_View_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi thêm không thành công");
                            SetButton_Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu giới tính phải nhập Nam hoặc Nữ");
                    }
                }
            }
            else
            {
                if(nvc.Sua(txtManv.Text, txtMatkhau.Text, txtTennv.Text, txtGioitinh.Text, txtDiachi.Text, txtSdt.Text, cbChucvu.SelectedText)==true)
                {
                    
                    MessageBox.Show("Bạn đã sửa thành công");
                    Nhanvien_View_Load(sender, e);
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
            Nhanvien_View_Load(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc muốn xóa không", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if(nvc.Xoa(txtManv.Text)==true)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi xóa không thành công");
                }
            }
            SetNull();
            Nhanvien_View_Load(sender, e);
        }

        private void Nhanvien_View_FormClosed(object sender, FormClosedEventArgs e)
        {
            Trangchinh1.nv = null;
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = dgvNhanvien.CurrentRow.Index;
                txtManv.Text = dgvNhanvien.Rows[i].Cells["Manv"].Value.ToString();
                txtMatkhau.Text = dgvNhanvien.Rows[i].Cells["Matkhau"].Value.ToString();
                txtTennv.Text = dgvNhanvien.Rows[i].Cells["Tennv"].Value.ToString();
                txtGioitinh.Text = dgvNhanvien.Rows[i].Cells["Gioitinh"].Value.ToString();
                txtDiachi.Text = dgvNhanvien.Rows[i].Cells["Diachi"].Value.ToString();
                txtSdt.Text = dgvNhanvien.Rows[i].Cells["Sodienthoai"].Value.ToString();
                cbChucvu.Text = dgvNhanvien.Rows[i].Cells["Chucvu"].Value.ToString();
            }
            catch
            {
                e.ToString();
            }
        }
    }
}
