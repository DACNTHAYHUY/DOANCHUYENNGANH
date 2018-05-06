using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DATN.Models;
using DATN.Controllers;
namespace DATN.Views
{
    public partial class Kho_View : Form
    {
        public Kho_View()
        {
            InitializeComponent();
        }
        Kho_Controller kc = new Kho_Controller();
        Kho_Model km = new Kho_Model();
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
            txtTensp.Text = "";
            txtLoai.Text = "";
        }
        bool thaotac = true;
        private void btThem_Click(object sender, EventArgs e)
        {
            thaotac = true;
            SetNull();
            SetButton_Close();
            DataTable dt = km.LoadDulieu();
            int count = 0;
            count = dt.Rows.Count;
            if(count<=0)
            {
                txtMasp.Text = "SP01";
            }
            else
            {
                string chuoi = "";
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

        private void Kho_View_Load(object sender, EventArgs e)
        {
            SetButton_Open();
            dgvKho.DataSource = km.LoadDulieu();
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
                if (txtMasp.Text == "" && txtTensp.Text == "")
                {
                    MessageBox.Show("Không thể lưu dữ liệu nếu không có hoặc thiếu dữ liệu");
                }
                else
                {
                    if (kc.Them(txtMasp.Text, txtTensp.Text, txtGia.Text, txtSoluong.Text,txtLoai.Text) == true)
                    {

                        MessageBox.Show("Bạn đã thêm thành công");
                        Kho_View_Load(sender, e);
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
                if (kc.Sua(txtMasp.Text, txtTensp.Text, txtGia.Text, txtSoluong.Text,txtLoai.Text) == true)
                {

                    MessageBox.Show("Bạn đã sửa thành công");
                    Kho_View_Load(sender, e);
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
            Kho_View_Load(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc muốn xóa không", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (kc.Xoa(txtMasp.Text) == true)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi xóa không thành công");
                }
            }
            SetNull();
            Kho_View_Load(sender, e);
        }

        private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = dgvKho.CurrentRow.Index;
                txtMasp.Text = dgvKho.Rows[i].Cells["Masp"].Value.ToString();
                txtTensp.Text = dgvKho.Rows[i].Cells["Tensp"].Value.ToString();
                txtGia.Text = dgvKho.Rows[i].Cells["Dongia"].Value.ToString();
                txtSoluong.Text = dgvKho.Rows[i].Cells["Soluong"].Value.ToString();
                txtLoai.Text = dgvKho.Rows[i].Cells["Loai"].Value.ToString();
            }
            catch
            {
                e.ToString();
            }
        }

        private void Kho_View_FormClosed(object sender, FormClosedEventArgs e)
        {
            Trangchinh1.k = null;
        }
    }
}
