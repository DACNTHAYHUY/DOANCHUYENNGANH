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
    public partial class Khachhang_View : Form
    {
        public Khachhang_View()
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
            txtMakh.Text = "";
            txtDiachi.Text = "";
            txtGioitinh.Text = "";
            txtSdt.Text = "";
            txtTenkh.Text = "";
        }
        Khachhang_Controller khc = new Khachhang_Controller();
        private void btThem_Click(object sender, EventArgs e)
        {
            thaotac = true;
            SetNull();
            SetButton_Close();
            DataTable dt = khm.LoadDulieu();
            int count = 0;
            count = dt.Rows.Count;
            if(count<=0)
            {
                txtMakh.Text = "KH01";
            }
            else
            {
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(dt.Rows[count - 1][0].ToString());
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                if (chuoi2 + 1 < 10)
                    txtMakh.Text = "KH0" + (chuoi2 + 1).ToString();
                else
                    if (chuoi2 + 1 < 100)
                        txtMakh.Text = "KH" + (chuoi2 + 1).ToString();
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
                if (txtMakh.Text == "" && txtTenkh.Text == "")
                {
                    MessageBox.Show("Không thể lưu dữ liệu nếu không có hoặc thiếu dữ liệu");
                }
                else
                {
                    if(khc.Them(txtMakh.Text,txtTenkh.Text, txtGioitinh.Text, txtDiachi.Text, txtSdt.Text)==true)
                    {                        
                        MessageBox.Show("Bạn đã thêm thành công");
                        Khachhang_View_Load(sender, e);
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
                if(khc.Sua(txtMakh.Text, txtTenkh.Text, txtGioitinh.Text, txtDiachi.Text, txtSdt.Text)==true)
                {                    
                    MessageBox.Show("Bạn đã sửa thành công");
                    Khachhang_View_Load(sender, e);
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
            Khachhang_View_Load(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc muốn xóa không", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if(khc.Xoa(txtMakh.Text)==true)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                }
                else   
                {
                   MessageBox.Show("Đã xảy ra lỗi xóa không thành công");
                }
            }
            SetNull();
            Khachhang_View_Load(sender, e);
        }

        private void dgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        Khachhang_Model khm = new Khachhang_Model();
        private void Khachhang_View_Load(object sender, EventArgs e)
        {
            SetButton_Open();
            dgvKhachhang.DataSource = khm.LoadDulieu();
        }

        private void Khachhang_View_FormClosed(object sender, FormClosedEventArgs e)
        {
            Trangchinh1.kh = null;
        }

        private void dgvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = dgvKhachhang.CurrentRow.Index;
                txtMakh.Text = dgvKhachhang.Rows[i].Cells["Makh"].Value.ToString();
                txtTenkh.Text = dgvKhachhang.Rows[i].Cells["Tenkh"].Value.ToString();
                txtGioitinh.Text = dgvKhachhang.Rows[i].Cells["Gioitinh"].Value.ToString();
                txtDiachi.Text = dgvKhachhang.Rows[i].Cells["Diachi"].Value.ToString();
                txtSdt.Text = dgvKhachhang.Rows[i].Cells["Sodienthoai"].Value.ToString();

            }
            catch
            {
                e.ToString();
            }
        }
    }
}
