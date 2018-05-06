using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATN.Controllers;
using DATN.Models;
namespace DATN.Views
{
    public partial class Hoadonbanhang_View : Form
    {
        public Hoadonbanhang_View()
        {
            InitializeComponent();
        }
        Hoadonbanhang_Controller hdbc = new Hoadonbanhang_Controller();
        Hoadonbanhang_Model hdbm = new Hoadonbanhang_Model();
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
            cbMakh.Text = "";
            txtTongtien.Text = "";
            txtMahdb.Text = "";
            cbManv.Text = "";
        }
        Khachhang_Model khm = new Khachhang_Model();
        Nhanvien_Model nvm = new Nhanvien_Model();
        public String Makhh;
        private void Hoadonbanhang_View_Load(object sender, EventArgs e)
        {
            SetButton_Open();
            cbMakh.DataSource = khm.LoadDulieu();
            cbMakh.ValueMember = "Makh";
            cbMakh.DisplayMember = "Makh";
            cbManv.DataSource = nvm.LoadDulieu();
            cbManv.ValueMember = "Manv";
            cbManv.DisplayMember = "Manv";
            dgvHoadonban.DataSource = hdbm.LoadDulieu();
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
                if (txtMahdb.Text == "" && cbManv.Text == ""&& cbMakh.Text == "")
                {
                    MessageBox.Show("Không thể lưu dữ liệu nếu không có hoặc thiếu dữ liệu");
                }
                else
                {
                    if (hdbc.Them(txtMahdb.Text,cbManv.Text,cbMakh.Text,dtNgayban.Text,txtTongtien.Text) == true)
                    {
                        MessageBox.Show("Bạn đã thêm thành công");
                        Hoadonbanhang_View_Load(sender, e);
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
                if (hdbc.Sua(txtMahdb.Text, cbManv.Text, cbMakh.Text, dtNgayban.Text, txtTongtien.Text) == true)
                {
                    MessageBox.Show("Bạn đã sửa thành công");
                    Hoadonbanhang_View_Load(sender, e);
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
            Hoadonbanhang_View_Load(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc muốn xóa không", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hdbc.Xoa(txtMahdb.Text) == true)
                {
                    MessageBox.Show("Bạn đã xóa thành công");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi xóa không thành công");
                }
            }
            SetNull();
            Hoadonbanhang_View_Load(sender, e);
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            thaotac = true;
            SetNull();
            SetButton_Close();
            DataTable dt = hdbm.LoadDulieu();
            int count = 0;
            count = dt.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if(count<=0)
            {
                txtMahdb.Text = "HDB01";
            }
            else
            {
                chuoi = Convert.ToString(dt.Rows[count - 1][0].ToString());
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    txtMahdb.Text = "HDB0" + (chuoi2 + 1).ToString();
                else
                    if (chuoi2 + 1 < 100)
                        txtMahdb.Text = "HDB" + (chuoi2 + 1).ToString();
            }           
        }

        private void dgvHoadonban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = dgvHoadonban.CurrentRow.Index;
                cbMakh.Text = dgvHoadonban.Rows[i].Cells["Makh"].Value.ToString();
                txtMahdb.Text = dgvHoadonban.Rows[i].Cells["Mahdb"].Value.ToString();
                cbManv.Text = dgvHoadonban.Rows[i].Cells["Manv"].Value.ToString();
                txtTongtien.Text = dgvHoadonban.Rows[i].Cells["Tongtien"].Value.ToString();
                dtNgayban.Text = dgvHoadonban.Rows[i].Cells["Ngayban"].Value.ToString();
            }
            catch
            {
                e.ToString();
            }
        }

        private void Hoadonbanhang_View_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
